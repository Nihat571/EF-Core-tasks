﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Practice.Models;

public class Meal:BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
}
