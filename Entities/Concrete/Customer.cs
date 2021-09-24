﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public string CustomerId { get; set; }

        public string ContactName { get; set; }

        public string City { get; set; }

        public string CampanyName { get; set; }
    }
}
