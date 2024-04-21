using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Officer")]
    public class Officer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("PhoneNumber")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Column("EmailAddress")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Column("UserName")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Column("Password")]
        public string Password { get; set; }

        [Column("BadgeNumber")]
        [Display(Name = "Badge Number")]
        public string BadgeNumber { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [InverseProperty("IssueOfficer")]
        public List<Violation> Violations { get; set; }
    }
}
