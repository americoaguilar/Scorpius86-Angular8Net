// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Galaxy.Angular.API.Infrastructure.Data.EntityFrameCore.Entities
{
    public partial class State
    {
        public State()
        {
            Customers = new HashSet<Customer>();
        }

        public int StateId { get; set; }
        public string Uuid { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}