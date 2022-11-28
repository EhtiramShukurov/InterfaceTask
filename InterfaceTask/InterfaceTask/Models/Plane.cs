using InterfaceTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal class Plane:Vehicle,IEngine
    {
        private double _wingLength;
        public double OilCapacity { get; set; }
        public double CurrentOil { get; set; }
        public double WingLength
        {
            get { return _wingLength; }
            set { _wingLength = value; }
        }
        public string FuelType { get ; set ; }

        public Plane(double oilCapacity,double currentOil,double wingLength,string fuelType,double driveTime,double drivePath)
        {
            OilCapacity = oilCapacity;
            CurrentOil = currentOil;
            WingLength = wingLength;
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

        public double RemainOilAmount()
        {
            return OilCapacity - CurrentOil;
        }
    }
}
