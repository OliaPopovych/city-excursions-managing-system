namespace ExcursionsManagementApp.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Tour
    {
        public Tour()
        {
            Places = new HashSet<Place>();
            ScheduleEntries = new List<ScheduleEntry>();
        }
        [Key]
        public int TourID { get; set; }

        [Required]
        [StringLength(50)]
        public string TourName { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        // FKs
        public virtual ICollection<Place> Places { get; set; }
        public virtual ICollection<ScheduleEntry> ScheduleEntries { get; set; }

        public int GuideID { get; set; }
        public virtual Guide Guide { get; set; }


    }
}
