using System;
using System.Collections.Generic;

namespace Vega.Core.Dtos
{
    public class VehicleDto
    {
        public Guid ModelId { get; set; }

        public bool IsRegistered { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }

        public IEnumerable<Guid> Features { get; set; }
    }
}