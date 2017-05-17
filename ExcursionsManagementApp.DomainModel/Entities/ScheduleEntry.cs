namespace ExcursionsManagementApp.DomainModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Schedule")]
    public partial class ScheduleEntry
    {
        public ScheduleEntry()
        {
            Customers = new List<Customer>();
        }

        // PK
        public int ScheduleEntryID { get; set; }

        [StringLength(50)]
        public string TourName { get; set; }

        public DateTime StartTime { get; set; }

        // FKs
        public virtual ICollection<Customer> Customers { get; set; }

        [Required]
        public int TourID { get; set; }
        public virtual Tour Tour { get; set; }

    }
}
