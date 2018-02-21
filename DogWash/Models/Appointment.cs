using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DogWash.Models
{
    public class Appointment
    {
        public int ID { get; set; }
        public DateTime AppDate { get; set; }
        public virtual ICollection<Pet> pets { get; set; }
        public virtual ICollection<Owner> Owners { get; set; }
    }
}