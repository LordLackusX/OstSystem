namespace OstSysWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resident")]
    public partial class Resident
    {
        [Key]
        [StringLength(30)]
        public string Resident_ID { get; set; }

        public int Apartment_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public int Phone_Number { get; set; }

        public int Age { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "date")]
        public DateTime Moved_In { get; set; }

        [Column(TypeName = "date")]
        public DateTime Moved_Out { get; set; }

        public bool Board_Member { get; set; }
    }
}
