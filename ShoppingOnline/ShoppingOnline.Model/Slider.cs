namespace ShoppingOnline.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Slider")]
    public partial class Slider
    {
        [StringLength(10)]
        public string SliderId { get; set; }

        [Required]
        [StringLength(100)]
        public string Image { get; set; }

        [StringLength(50)]
        public string Link { get; set; }
    }
}
