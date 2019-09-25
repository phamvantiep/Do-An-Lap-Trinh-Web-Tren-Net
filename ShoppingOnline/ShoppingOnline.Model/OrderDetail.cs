namespace ShoppingOnline.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderDetail")]
    public partial class OrderDetail
    {
        [StringLength(10)]
        public string OrderDetailId { get; set; }

        [StringLength(10)]
        public string OrderId { get; set; }

        [StringLength(10)]
        public string ProductId { get; set; }

        public int? Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
