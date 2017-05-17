namespace ExcursionsManagementApp.DomainModel
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Guide
    {
        public Guide()
        {
            Tours = new List<Tour>();
        }

        [Key]
        public int GuideID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        // FKs
        public virtual ICollection<Tour> Tours { get; set; }
    }
}
