using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Violator")]
    public class Violator
    {
        [Key]
        [Column("IDNumber")]
        [Display(Name = "ID Number")]
        public string IDNumber { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("PhoneNumber")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Column("EmailAddress")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [InverseProperty("Violator")]
        public List<Car> Cars { get; set; }
    }
}
