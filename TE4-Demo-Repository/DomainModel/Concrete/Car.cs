﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE4_Demo_Repository.DomainModel.Concrete
{
    class Car
    {
        public Car()
        {

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Milage { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Make, Model);
        }
    }
}
