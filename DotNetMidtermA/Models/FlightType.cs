namespace DotNetMidtermA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FlightType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FlightType()
        {
            Flights = new HashSet<Flight>();
        }

        [Display(Name ="Type")]

        public int FlightTypeId { get; set; }

        [Column("FlightType")]
        [Required]
        [StringLength(50)]
        [Display(Name = "Type")]
        public string FlightType1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flight> Flights { get; set; }
    }
}
