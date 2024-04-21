using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Violation")]
    public class Violation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("Amount")]
        public double Amount { get; set; }

        [Column("DateIssued")]
        [Display(Name = "Date Issued")]
        public DateTime DateIssued { get; set; }

        [Column("ViolationType")]
        [Display(Name = "Violation Type")]
        public string ViolationType { get; set; }

        [Column("IsPayed")]
        [Display(Name = "Is Payed")]
        public bool IsPayed { get; set; }

       [ForeignKey("AnnualTax")]
        public Guid AnnualTaxId { get; set; }
        public AnnualTax AnnualTax { get; set; }


       [ForeignKey("IssueOfficerId")]
        public Guid IssueOfficerId { get; set; }
        public Officer IssueOfficer { get; set; }


        [ForeignKey("IssuedCarId")]
        public Guid IssuedCarId { get; set; }
        public Car IssuedCar { get; set; }


       [ForeignKey("PaymentId")]
        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }

    }
}
