namespace ExcursionsManagementApp.DomainModel
{
    using System.ComponentModel.DataAnnotations;

    public partial class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(30)]
        public string LastName { get; set; }

        // FKs
        [Required]
        public int ScheduleEntryID { get; set; }
        public virtual ScheduleEntry ScheduleEntry { get; set; }
    }
}
