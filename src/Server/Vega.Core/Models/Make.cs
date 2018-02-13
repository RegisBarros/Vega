using System;
using System.Collections.Generic;

namespace Vega.Core.Models
{
    public class Make
    {
        public Make()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
