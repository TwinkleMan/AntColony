using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary
{
    public class Graph
    {
        private bool isRandom;  //true = граф генерируется случайно
        private int numberOfCities;     //количество вершин графа (городов), вводится пользователем
        private double[,] distances;    //массив расстояний
        private List<City> cityList;    //список вершин графа
        private int placedCitiesCounter; //количество расставленых пользователем вершин
        private bool isDistancesEmpty;  //флаг проверки матрицы расстояний на наполненность
        private Bitmap tempCanvas { get; set; }     //точечный рисунок (изображение графа)
        private double[,] pheromones;   //матрица феромонов на ребрах
        private bool isPheromonesEmpty;     //флаг проверки матрицы феромонов на наполненность
        private Random randomGenerator; //генератор случайных чисел

        public Graph(int canvasHeight,int canvasWidth,Graphics canvas)
        {
            isDistancesEmpty = true;
            isPheromonesEmpty = true;
            randomGenerator = new Random();
            tempCanvas = new Bitmap(canvasWidth, canvasHeight, canvas);
        }
        
        public void initializeCities(Graphics canvas)
        {
            Pen pen = new Pen(Brushes.Black);
            int city_X = 0, city_Y = 0;
            distances = new double[numberOfCities, numberOfCities];
            if (isRandom)
            {
                cityList = new List<City>();
                for (int i = 0;i < numberOfCities;i++)
                {
                    city_X = randomGenerator.Next(30, tempCanvas.Width - 30);
                    city_Y = randomGenerator.Next(30, tempCanvas.Height - 30);
                    cityList.Add(new City(new Point(city_X,city_Y)));
                    cityList[i].Draw(canvas);
                }

                placedCitiesCounter = numberOfCities;
            }
            for (int i = 0; i < placedCitiesCounter; i++)
            {
                for (int j = 0; j < placedCitiesCounter; j++)
                {
                    double x = Math.Pow((double)cityList[i].getLocation().X - (double)cityList[j].getLocation().X, 2.0);
                    double y = Math.Pow((double)cityList[i].getLocation().Y - (double)cityList[j].getLocation().Y, 2.0);
                    distances[i, j] = Math.Round(Math.Sqrt(x + y), 2);
                    isDistancesEmpty = false;
                }
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
    }
}