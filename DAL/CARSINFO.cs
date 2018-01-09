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
        [Column(Order = 0)]
        public int CARId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Category { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CarName { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Age { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Price { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string Color { get; set; }

        [StringLength(100)]
        public string CarImage { get; set; }
    }
}
