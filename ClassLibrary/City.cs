using System.Collections.Generic;
using System.Drawing;

namespace ClassLibrary
{
    public class City
    {
        private const int radius = 8;
        
        private Point location;

        public City()
        {
            location = Point.Empty;
        }

        public City(Point point)
        {
            location = point;
        }

        public void Draw(Graphics canvas)
        {
            canvas.DrawEllipse(Pens.Black,location.X - radius,location.Y + radius,radius * 2,radius * 2);
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

        public bool isCityNear(List<City> cities)
        {
            bool result = false;

            foreach (City city in cities)
            {
                if ((location.X + radius == city.location.X) || (location.X - radius == city.location.X) || (location.Y + radius == city.location.Y) || (location.Y - radius == city.location.Y))
                {
                    result = true;
                }
            }

            return result;
        }
    }
}