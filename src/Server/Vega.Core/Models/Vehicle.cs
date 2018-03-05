using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vega.Core.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }

        public Guid ModelId { get; set; }

        public Model Model { get; set; }

        public bool IsRegistered { get; set; }

        public Contact Contact { get; set; }

        public DateTime LastUpdate { get; set; }

        public ICollection<VehicleFeature> Features { get; set; }

        public Vehicle()
        {
            Features = new Collection<VehicleFeature>();
            Id = Guid.NewGuid();
        }

        public static Vehicle Create(Guid modeId, string contactName, string contactPhone, string contactEmail, IEnumerable<Guid> Features)
        {
            var vehicle = new Vehicle()
            {
                ModelId = modeId,
                Contact = new Contact()
                {
                    Name = contactName,
                    Phone = contactPhone,
                    Email = contactEmail
                },
                LastUpdate = DateTime.Now
            };

            if (Features != null)
            {
                foreach (var featureId in Features)
                {
                    vehicle.Features.Add(new VehicleFeature()
                    {
                        FeatureId = featureId,
                        VehicleId = vehicle.Id
                    });
                }
            }

            return vehicle;
        }
    }
}