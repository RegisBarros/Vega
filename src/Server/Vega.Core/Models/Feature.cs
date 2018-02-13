using System;

namespace Vega.Core.Models
{
    public class Feature
    {
        public Feature()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public string Name { get; set; }
    }
}
