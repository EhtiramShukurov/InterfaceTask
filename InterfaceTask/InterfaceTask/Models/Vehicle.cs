using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Models
{
    internal abstract class Vehicle
    {
		private double _driveTime;
        private double _drivePath;
        public double DriveTime
		{
			get { return _driveTime; }
			set {
				if (value > 0)
				{
                    _driveTime = value;
                }
				else
				{
					Console.WriteLine("Wrong Input");
				}
				}
		}
		public double DrivePath
		{
			get { return _drivePath; }
			set {

				if (value > 0)
				{
                    _drivePath = value;
                }
				else
				{
					Console.WriteLine("Wrong input");
				}
				}
		}
		public abstract double AverageSpeed();
	}
}
