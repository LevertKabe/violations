using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("AnnualTax")]
    public class AnnualTax
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("DateIssued")]
        [Display(Name = "Date Issued")]
        public DateTime DateIssued { get; set; }

        [Column("IsPayed")]
        [Display(Name = "Is Payed")]
        public bool IsPayed { get; set; }

        [ForeignKey("CarId")]
        public Guid CarId { get; set; }
        public Car Car { get; set; }


   
    }
}
