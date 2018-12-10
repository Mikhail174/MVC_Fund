﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Fund3_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}