﻿using DemoProj.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using System.Collections.Generic;

namespace DemoProj.Model.Models
{
    [Table("Products")]
    public class Product: Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(250)]
        public string Alias { set; get; }

        public int CategoryID { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        public XElement MoreImages { set; get; }
        public decimal Price { set; get; }

        public decimal? PromotionPrice { set; get; }

        public int? Warranty { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength()]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        [ForeignKey("CategoryID")]
        public virtual ProductCategory ProductCategory { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
