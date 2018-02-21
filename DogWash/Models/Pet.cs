﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogWash.Models
{
    public class Pet
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}