using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("PayMethod")]
        [Display(Name = "Payment Method")]
        public string PayMethod { get; set; }

        [Column("Amount")]
        public double Amount { get; set; }

        [ForeignKey("ViolationId")]
        public Guid ViolationId { get; set; }
        public Violation Violation { get; set; }


        [Column("ProcessDate")]
        [Display(Name = "Process Date")]
        public DateTime ProcessDate { get; set; }
    }
}
