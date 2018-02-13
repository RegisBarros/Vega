using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Core.Models
{
    public class Make
    {
        public Make()
        {
            Id = Guid.NewGuid();
            Models = new Collection<Model>();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
