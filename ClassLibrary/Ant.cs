using System.Collections.Generic;

namespace ClassLibrary
{
    public class Ant
    {
        private double distanceTravelled;
        private int currentLocation;
        private int nextLocation;
        public List<bool> tabuList;
        public List<int> travelMap;

        public Ant()
        {
            distanceTravelled = 0;
            currentLocation = 0;
            tabuList = new List<bool>();
            travelMap = new List<int>();
        }

        public Ant(int location,int tabuSize)
        {
            distanceTravelled = 0;
            currentLocation = location;
            tabuList = new List<bool>(tabuSize);
            for (int i = 0; i < tabuSize; i++)
            {
                tabuList.Add(false);
            }
            travelMap = new List<int>();
        }

        public double GetDistance()
        {
            return distanceTravelled;
        }

        public void ResetDistance()
        {
            distanceTravelled = 0;
        }

        public void SetNextLocation(int location)
        {
            nextLocation = location;
        }

        public void UpdateDistanceTravelled(double distance)
        {
            distanceTravelled += distance;
        }

        public int getCurrentLocation()
        {
            return currentLocation;
        }

        public void setCurrentLocation(int location)
        {
            currentLocation = location;
        }
    }
}