using System;
using System.Collections.Generic;

namespace Vega.Core.Dtos
{
    public class MakeDto
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public IEnumerable<ModelDto> Models { get; set; }
    }
}
