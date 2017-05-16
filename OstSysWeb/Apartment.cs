namespace OstSysWeb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Apartment")]
    public partial class Apartment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Apartment_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        public int Size { get; set; }

        public int Number_Of_Rooms { get; set; }

        public double BBR { get; set; }

        public double Fordelingstal { get; set; }

        public int Floor { get; set; }

        [Required]
        [StringLength(30)]
        public string Side { get; set; }

        public bool Reserved { get; set; }

        public override string ToString()
        {
            return $"{nameof(Apartment_ID)}: {Apartment_ID}, {nameof(Address)}: {Address}, {nameof(Size)}: {Size}, {nameof(Number_Of_Rooms)}: {Number_Of_Rooms}, {nameof(BBR)}: {BBR}, {nameof(Fordelingstal)}: {Fordelingstal}, {nameof(Floor)}: {Floor}, {nameof(Side)}: {Side}, {nameof(Reserved)}: {Reserved}";
        }
    }
}
