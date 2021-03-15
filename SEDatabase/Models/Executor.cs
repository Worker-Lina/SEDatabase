﻿using System;
using System.Collections.Generic;

namespace SEDatabase.Models
{
    public class Executor : User // исполнитель
    {
        public int Price { get; set; }
        public ICollection<Application> Applications { get; set; }
    }
}
