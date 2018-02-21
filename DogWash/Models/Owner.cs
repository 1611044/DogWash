using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogWash.Models
{
    public class Owner
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public virtual ICollection<Pet> Pets { get; set; }
    }
}