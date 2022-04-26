﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }


    }
}
