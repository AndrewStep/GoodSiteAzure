namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CARSINFO")]
    public partial class CARSINFO
    {
        [Key]
        public int CARId { get; set; }

        [Required]
        [StringLength(20)]
        public string CarImage { get; set; }

        [Required]
        [StringLength(60)]
        public string Category { get; set; }

        [Required]
        [StringLength(60)]
        public string CarName { get; set; }

        [Required]
        [StringLength(60)]
        public string Color { get; set; }

        public int Age { get; set; }

        public decimal Price { get; set; }
    }
}
