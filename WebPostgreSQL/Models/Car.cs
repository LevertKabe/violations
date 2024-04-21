using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Car")]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public Guid Id { get; set; }

        [Column("NumberPlate")]
        [Display(Name = "Number Plate")]
        public string NumberPlate { get; set; }

        [Column("Model")]
        public string Model { get; set; }

        [Column("VinNumber")]
        [Display(Name = "VIN Number")]
        public string VinNumber { get; set; }

        [Column("RegisteredOwner")]
        [Display(Name = "Registered Owner")]
        public string RegisteredOwner { get; set; }

        [Column("Colour")]
        public string Colour { get; set; }

        [ForeignKey("AnnualTax")]
        public Guid AnnualTaxId { get; set; }
        public AnnualTax AnnualTax { get; set; }

        [InverseProperty("IssuedCar")]
        public List<Violation> Violations { get; set; }

        [ForeignKey("ViolatorId")]
        public string ViolatorId { get; set; }
        public Violator Violator { get; set; }

    }
}
