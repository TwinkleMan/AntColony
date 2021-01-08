using System;
using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary
{
    public class City
    {
        private const int radius = 8;
        private const int distPlateWidth = 30;
        private const int distPlateHeight = 10;
        Font font = new Font("Arial", 8);
        
        private Point location;

        public City()
        {
            location = Point.Empty;
        }

        public City(Point point)
        {
            location = point;
        }

        public void Draw(Graphics canvas,int cityNumber)
        {
            canvas.DrawEllipse(Pens.Black,location.X - radius,location.Y - radius,radius * 2,radius * 2);
            canvas.DrawString(Convert.ToString(cityNumber),font,Brushes.Black,location.X - radius,location.Y - radius);
        }

        public void DrawFinish(Graphics canvas)
        {
            canvas.FillEllipse(Brushes.Red,location.X - radius,location.Y - radius,radius * 2,radius * 2);
            canvas.DrawEllipse(Pens.Black,location.X - radius,location.Y - radius,radius * 2,radius * 2);
        }

        public Point getLocation()
        {
            return location;
        }

        public void setLocation(int x,int y)
        {
            location.X = x;
            location.Y = y;
        }

        public void buiildRoad(City second,Graphics canvas)
        {
            //отрисовка дороги
            canvas.DrawLine(Pens.Black,location.X,location.Y,second.location.X,second.location.Y);

            //вычисление середины прямой, соединяющей города
            int middle_X = (location.X + second.location.X) / 2;
            int middle_Y = (location.Y + second.location.Y) / 2;
            int plateStart_X = middle_X - distPlateWidth / 2;
            int plateStart_Y = middle_Y - distPlateHeight / 2;
            
            //вычисление расстояния между городами
            double dist = (Math.Round(Math.Sqrt(Math.Pow((location.X - second.location.X), 2) +
                                                Math.Pow((location.Y - second.location.Y), 2)), 1));
            
            //отрисовка таблички с расстоянием (отключено для разргрузки визулъального восприятия)
            /*Rectangle distPlate = new Rectangle(plateStart_X, plateStart_Y, distPlateWidth, distPlateHeight);
            canvas.DrawRectangle(Pens.Black,distPlate);
            canvas.DrawString(Convert.ToString(dist),font,Brushes.Black,plateStart_X,plateStart_Y);*/
        }
        
        public bool isCityNear(List<City> cities)
        {
            bool result = false;

            foreach (City city in cities)
            {
                //переписать проверку на наличие поблизости других вершин. Использование точного сравнения значений не дает нормального результата!
                //использовать > и <

                if ((Math.Abs(location.X - city.location.X) < 2*radius) &&
                    (Math.Abs(location.Y - city.location.Y) < 2*radius))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}