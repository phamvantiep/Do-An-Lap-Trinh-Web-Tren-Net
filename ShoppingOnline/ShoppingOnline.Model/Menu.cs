namespace ShoppingOnline.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Menu")]
    public partial class Menu
    {
        [StringLength(10)]
        public string MenuId { get; set; }

        [Required]
        [StringLength(30)]
        public string MenuName { get; set; }

        [StringLength(100)]
        public string Link { get; set; }

        [StringLength(100)]
        public string Icon { get; set; }

        public int? Order { get; set; }

        [StringLength(10)]
        public string ParentId { get; set; }
    }
}
