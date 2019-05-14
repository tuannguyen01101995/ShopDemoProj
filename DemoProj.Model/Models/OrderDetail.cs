﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DemoProj.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { set; get; }

        [Key]
        public int ProductID { set; get; }

        public int Quantity { set; get; }

       

        [ForeignKey("OrderID")]
        public virtual Order Order { set; get; }


        [ForeignKey("ProductID")]
        public virtual ProductCategory ProductCategory { set; get; }
    }
}
