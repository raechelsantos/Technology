using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch_21_Exercise
{
    public class Computer
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string OperatingSystem { get; set; }
        

        public Computer(string model, string manufacturer, string operatingSystem)
        {
            Model = model;
            Manufacturer = manufacturer;
            OperatingSystem = operatingSystem;
        }
        public string GetModel()
        {
            return this.Model;
        }

        public string GetManufacturer()
        {
            return this.Manufacturer;
        }
    }
}
