﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Animals
{
    internal class Bird:Animal
    {
        public Bird(string name, double age, string Gender, string photolocate) : base(name, age, Gender, AnimalType.Others,photolocate)
        {

        }
        
        public override string ToString()
        {
            return $"Bird: {base.ToString()}";
        }
    }
}
