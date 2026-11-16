using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FailSafeRentals.ConsoleApp.Models
{
    public class DamageReports
    {
        public int Id { get; set; }

        [Required,MaxLength(1000)]
        public string Description { get; set; } = null!;

        [Required, MaxLength(20)]
        public string Severity { get; set; } = null!;
        public decimal EstimatedCost { get; set; }
        public DateTime ReportedAt { get; set; }
        public DateTime? RepairedAt { get; set; }

        //FK
        public int FleetVehicleId { get; set; }
        public FleetVehicle FleetVehicle { get; set; } = null!;

    }
}
