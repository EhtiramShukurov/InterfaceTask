using InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal class Car:Vehicle,IEngine
    {
        private int _doorCount;
        public double OilCapacity { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public int DoorCount
        {
            get { return _doorCount; }
            set { _doorCount = value; }
        }
        public Car(double oilCapacity, double currentOil, int doorCount, string fuelType, double driveTime, double drivePath)
        {
            OilCapacity = oilCapacity;
            CurrentOil = currentOil;
            DoorCount = doorCount;
            FuelType = fuelType;
            base.DriveTime = driveTime;
            base.DrivePath = drivePath;
        }
        public override double AverageSpeed()
        {
            if (DriveTime != null && DrivePath != null)
            {
                return DrivePath / DriveTime;
            }
            else
            {
                return 0;
            }
        }
        public  double RemainOilAmount()
        {
            return OilCapacity - CurrentOil;
        }
    }
}
