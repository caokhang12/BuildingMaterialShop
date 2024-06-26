﻿namespace Model.EF
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Order")]
    public partial class Order
    {
        public long ID { get; set; }
        public DateTime? CreatedDate { get; set; }

        public long? CustomerID { get; set; }

        [StringLength(50)]
        public string ShipName { get; set; }
        [StringLength(50)]
        public string ShipMobile { get; set; }
        [StringLength(50)]
        public string ShipAddress { get; set; }
        [StringLength(50)]
        public string ShipEmail { get; set; }
        public bool? Status { get; set; }
    }
}
