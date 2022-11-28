using InterfaceTask.Interfaces;
namespace InterfaceTask.Models
{
    internal class Bicycle:Vehicle,IEngine
    {
        private string _pedalKind;
        public string PedalKind
        {
            get { return _pedalKind; }
            set { _pedalKind = value; }
        }
        public double OilCapacity { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public Bicycle(double oilCapacity, double currentOil, string pedalKind, string fuelType, double driveTime, double drivePath)
        {
            OilCapacity = oilCapacity;
            CurrentOil = currentOil;
            PedalKind = pedalKind;
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
