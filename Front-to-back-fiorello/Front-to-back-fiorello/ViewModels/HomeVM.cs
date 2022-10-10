﻿using Front_to_back_fiorello.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back_fiorello.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public SliderDetail SliderDetail { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
