namespace ExcursionsManagementApp.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Place
    {
        public Place()
        {
            Tours = new HashSet<Tour>();
        }

        [Key]
        public int PlaceID { get; set; }

        [Required]
        [StringLength(50)]
        public string PlaceName { get; set; }

        // FKs
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
