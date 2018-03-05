using System;
using System.Collections.Generic;

namespace Vega.Core.Models
{
    public class Model
    {
        public Model()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public Make Make { get; set; }

        public Guid MakeId { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
