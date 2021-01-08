using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Principal;

namespace ClassLibrary
{
    public class Graph
    {
        private bool isRandom;  //true = граф генерируется случайно
        private bool isManuallyBuilt;   //true = граф построен "руками"
        private int numberOfCities;     //количество вершин графа (городов), вводится пользователем
        public int numberOfClicks;     //количество вершин, введенных пользователем вручную
        private double[,] distances;    //массив расстояний
        private List<City> cityList;    //список вершин графа
        private bool isDistancesEmpty;  //флаг проверки матрицы расстояний на наполненность
        private Bitmap tempCanvas { get; set; }     //точечный рисунок (изображение графа)
        private double[,] pheromones;   //матрица феромонов на ребрах
        private bool isPheromonesEmpty;     //флаг проверки матрицы феромонов на наполненность
        private Random randomGenerator; //генератор случайных чисел

        private List<Ant> antList;
        private int numberOfAnts;
        private double alpha, beta, rho;
        private int Q;
        
        private List<Image> antSteps = new List<Image>();   //список с изображениями, отображающими шаги алгоритма
        private double bestTourLength = -1;  //Длина лучшего маршрута
        private List<int> bestTourList = new List<int>();   //Лучший маршрут, найденный алгоритмом
        private int iterations; //количество итераций алгоритма
        

        public Graph(int canvasHeight,int canvasWidth,Graphics canvas)
        {
            numberOfCities = 0;
            numberOfClicks = 0;
            numberOfAnts = 0;
            isDistancesEmpty = true;
            isPheromonesEmpty = true;
            randomGenerator = new Random();
            tempCanvas = new Bitmap(canvasWidth, canvasHeight, canvas);
        }

        public void placeCity(Graphics canvas,Point city)
        {
            City temp = new City();
            if (numberOfClicks == 0) cityList = new List<City>();
            
            temp.setLocation(city.X,city.Y); 
            cityList.Add(new City(new Point(city.X,city.Y))); 
            cityList[numberOfClicks].Draw(canvas,numberOfClicks);
            numberOfClicks++;

        }

        public void allDraw()
        {
            int k = 0;
            
            foreach (City city in cityList)
            {
                city.Draw(Graphics.FromImage(tempCanvas),k);
                k++;
            }

            ConnectCities(Graphics.FromImage(tempCanvas));
        }
        
        public void initializeCities(Graphics canvas)
        {
            bool cityNear = true;
            City temp = new City();
            antList = new List<Ant>(numberOfAnts);

            int city_X = 0, city_Y = 0;
            distances = new double[numberOfCities, numberOfCities];
            pheromones = new double[numberOfCities, numberOfCities];
            if (isRandom)
            {
                cityList = new List<City>();
                for (int i = 0;i < numberOfCities;i++)
                {
                    while (cityNear)
                    {
                        city_X = randomGenerator.Next(30, tempCanvas.Width - 30);
                        city_Y = randomGenerator.Next(30, tempCanvas.Height - 30);
                        temp.setLocation(city_X,city_Y);
                        cityNear = temp.isCityNear(cityList);
                    }
                    cityNear = true;
                    cityList.Add(new City(new Point(city_X,city_Y)));
                    cityList[i].Draw(canvas,i);
                }
            }
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    double x = Math.Pow((double)cityList[i].getLocation().X - (double)cityList[j].getLocation().X, 2.0);
                    double y = Math.Pow((double)cityList[i].getLocation().Y - (double)cityList[j].getLocation().Y, 2.0);
                    distances[i, j] = Math.Round(Math.Sqrt(x + y), 2);
                    isDistancesEmpty = false;
                    
                    pheromones[i, j] = Math.Round((1.0 / numberOfCities),2);
                    isPheromonesEmpty = false;
                }
            }

            ConnectCities(canvas);
            //tempCanvas = Bitmap.FromHbitmap(canvas.GetHdc());
            tempCanvas = new Bitmap(tempCanvas.Width, tempCanvas.Height, canvas);
        }

        private void ConnectCities(Graphics canvas)
        {
            foreach (City city1 in cityList)
            {
                foreach (City city2 in cityList)
                {
                    if (city1 != city2) city1.buiildRoad(city2,canvas);
                }
            }
        }
        
        public int checkEnteredValues(string numOfCities_s,string alpha_s, string beta_s, string rho_s, string iterations_s,string pheromones_Q_s,
            string numOfAnts_s)
        {
            //double alpha,beta,rho;
            //int numOfCities,iterations,pheromones_Q,numOfAnts;

            try
            {
                numberOfCities = Convert.ToInt32(numOfCities_s);
            }
            catch (System.FormatException)
            {
                return 1;
                
            }
            
            try
            {
                alpha = Convert.ToDouble(alpha_s);
            }
            catch (System.FormatException)
            {
                return 2;
            }

            try
            {
                beta = Convert.ToDouble(beta_s);
            }
            catch (System.FormatException)
            {
                return 3;
            }

            try
            {
                rho = Convert.ToDouble(rho_s);
            }
            catch (System.FormatException)
            {
                return 4;
            }

            try
            {
                iterations = Convert.ToInt32(iterations_s);
            }
            catch (System.FormatException)
            {
                return 5;
            }

            try
            {
                Q = Convert.ToInt32(pheromones_Q_s);
            }
            catch (System.FormatException)
            {
                return 6;
            }

            try
            {
                numberOfAnts = Convert.ToInt32(numOfAnts_s);
            }
            catch (System.FormatException)
            {
                return 7;
            }

            return 0;
        }
        
        public void Calculate()
        {
            Stream stream = new FileStream("image.bmp", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter("tempres.txt");
            Graphics graphics = Graphics.FromImage(tempCanvas);
            
            initAnts();

            for (int k = 0; k < iterations; k++)
            {
                for (int i = 0; i < numberOfCities; i++) //муравьи идут до конца
                {
                    if (antsStopped()) //двигает муравьев на один шаг вперед и проверяет, дошли ли они
                    {
                        evaporatePheromones();
                        updatePheromones();
                        bestTour(); //проверяет муравьев на наличие оптимальных маршрутов
                        initAnts(); //сбрасывает позиции муравьев
                        graphics.Clear(Color.White);
                    }
                }
                
                allDraw(); 
                cityList[bestTourList[0]].DrawFinish(graphics);
                graphics.DrawString(string.Format("Итерация " + Convert.ToString(k + 1)), new Font("Arial", 10), new SolidBrush(Color.Black), 10, 10); 
                for (int i = 0; i < bestTourList.Count; i++) 
                { 
                    Pen pen = new Pen(Color.Orange, 1); 
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor; 
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
                    int from = bestTourList[i];
                    int to = bestTourList[(i + 1) % numberOfCities];
                    graphics.DrawLine(pen,cityList[bestTourList[i]].getLocation(),cityList[bestTourList[(i + 1) % numberOfCities]].getLocation());
                }
                tempCanvas.Save(stream,System.Drawing.Imaging.ImageFormat.Bmp);
                antSteps.Add(Image.FromStream(stream));
                streamWriter.WriteLine(bestTourLength);
                foreach (int i in bestTourList)
                {
                    streamWriter.WriteLine(Convert.ToString(i) + " ");
                }
            }

            graphics = null;
            stream.Close();
            streamWriter.Close();
        }

        private bool antsStopped()
        {
            int moved = 0;

            for (int i = 0; i < numberOfAnts; i++)
            {
                if (antList[i].travelMap.Count < numberOfCities)
                {
                    goToNextCity(antList[i]);
                    moved++;
                }
            }

            if (moved == 0)
            {
                return true;
            }
            else return false;
        }

        private void goToNextCity(Ant currentAnt)
        {
            double denom = 0; //знаменатель
            double moveChanse = 0; //вероятность перехода
            
            double localMaxChance = 0;  //наибольшая вероятность перехода
            int maxChanceIndex = 0; //индекс вершины с наибольшим шансом перехода

            int currentCity = currentAnt.getCurrentLocation();

            //if (isManuallyBuilt)  //если граф создается вручную
            for (int i = 0; i < numberOfCities; i++) 
            {
                if (!currentAnt.tabuList[i] && (i != currentCity))
                {
                    denom += Math.Pow(pheromones[currentCity,i],alpha) * Math.Pow((1.0 / distances[currentCity,i]),beta);
                }
            }

            int destinationCity = 0;    //для упрощения чтения кода

            //выбор следующей вершины
            for (int count = 0; count < numberOfCities; count++)
            {
                destinationCity = count;
                if (!currentAnt.tabuList[destinationCity] && destinationCity != currentCity) //если муравей не ходил в эту вершину
                {
                    moveChanse = Math.Pow(pheromones[currentCity, destinationCity], alpha) *
                        Math.Pow((1.0 / distances[currentCity, destinationCity]), beta) / denom;
                    if (moveChanse > localMaxChance)
                    {
                        localMaxChance = moveChanse;
                        maxChanceIndex = destinationCity;
                    }
                }
            }

            currentAnt.tabuList[maxChanceIndex] = true;
            currentAnt.travelMap.Add(maxChanceIndex);
            currentAnt.UpdateDistanceTravelled(distances[currentAnt.getCurrentLocation(), maxChanceIndex]);
            //если муравей добрался до конца - идем в самое начало
            if (currentAnt.travelMap.Count == numberOfCities)
            {
                currentAnt.UpdateDistanceTravelled(
                    distances[currentAnt.travelMap[numberOfCities - 1], currentAnt.travelMap[0]]);
            }
            currentAnt.setCurrentLocation(maxChanceIndex);

        }

        private void evaporatePheromones()
        {
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int k = 0; k < numberOfCities; k++)
                {
                    pheromones[i, k] *= (1.0 - rho);
                    //значение феромонов не должно падать ниже изначального
                    if (pheromones[i, k] < (1.0 / numberOfCities))
                    {
                        pheromones[i, k] = Math.Round(1.0 / numberOfCities, 2);
                    }
                }
            }
        }

        private void updatePheromones()
        {
            for (int i = 0; i < numberOfAnts; i++)
            {
                for (int k = 0; k < numberOfCities; k++)
                {
                    int from = antList[i].travelMap[k];
                    int to = antList[i].travelMap[((k + 1) % numberOfCities)];
                    pheromones[from, to] += Math.Round((double)Q / antList[i].GetDistance(),2);
                    pheromones[to, from] = pheromones[from, to];
                }
            }
        }

        private void bestTour()
        {
            StreamWriter streamWriter = new StreamWriter("temp.txt", true);
            double bestLocalTour = antList[0].GetDistance();
            int saveIndex = 0;

            for (int i = 0; i < antList.Count; i++)
            {
                if (antList[i].GetDistance() < bestLocalTour)
                {
                    bestLocalTour = antList[i].GetDistance();
                    saveIndex = i;
                }
            }
            //сравниваем лучший "локальный" путь с лучшим "глобальным" и обновляем
            streamWriter.WriteLine(bestLocalTour);
            if (bestLocalTour < bestTourLength || bestTourLength == -1)
            {
                bestTourList = antList[saveIndex].travelMap;
                bestTourLength = bestLocalTour;
            }
            streamWriter.Close();
            
        }

        private void initAnts()
        {
            int randCity = 0;
            antList.Clear();

            for (int i = 0; i < numberOfAnts; i++)
            {
                randCity = randomGenerator.Next(0, numberOfCities);
                antList.Add(new Ant(randCity,numberOfCities));  //случайный начальный город
                antList[i].travelMap.Add(antList[i].getCurrentLocation());
                antList[i].tabuList[antList[i].getCurrentLocation()] = true;    //посетили текущую вершину
                //antList[i].tabuList[antList[i].getCurrentLocation()] = true;
            }
        }
        
        public void generate()
        {
            isRandom = true;
        }

        public void setNumberOfCities(int number)
        {
            numberOfCities = number;
        }

        public int getNumberOfCities()
        {
            return numberOfCities;
        }

        public double[,] getDistances()
        {
            return distances;
        }

        public double[,] getPheromones()
        {
            return pheromones;
        }

        public List<Image> GetImages()
        {
            return antSteps;
        }

        public double getBestTourLength()
        {
            return bestTourLength;
        }
    }
}