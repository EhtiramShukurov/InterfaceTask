using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask.Interfaces
{
    internal interface IEngine
    {
        double OilCapacity { get; set; }
        double CurrentOil { get; set; }
        string FuelType { get; set; }
        double RemainOilAmount();
    }
}
