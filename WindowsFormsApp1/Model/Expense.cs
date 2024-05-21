﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Expense
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string DonorName { get; set; } // Добавьте поле для имени донора

        public Expense(string description, decimal amount, string donorName) // Добавьте конструктор
        {
            Description = description;
            Amount = amount;
            DonorName = donorName;
        }

    }
}
