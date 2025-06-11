﻿using CommunityToolkit.Mvvm.ComponentModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezeptSafe.Model
{ 
    
    public partial class Utensil : ObservableObject
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Amount { get; set; }
        [ObservableProperty]
        bool isSelected;
        public override string ToString()
        {
            return $"{Amount}x {Name}";
        }
    }
}
