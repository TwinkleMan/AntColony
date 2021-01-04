using System.Collections.Generic;

namespace ClassLibrary
{
    public class Ant
    {
        private double distanceTravelled;
        private int currentLocation { get; set; }
        private int nextLocation;
        private List<bool> tabuList;
        public List<int> travelMap;

        public Ant()
        {
            distanceTravelled = 0;
            currentLocation = 0;
            tabuList = new List<bool>();
        }

        public Ant(int location,int tabuSize)
        {
            distanceTravelled = 0;
            currentLocation = location;
            tabuList = new List<bool>(tabuSize);
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
    }
}