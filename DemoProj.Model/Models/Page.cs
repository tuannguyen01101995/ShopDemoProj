using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DemoProj.Model.Models
{
    [Table("Pages")]
   public class Page
   {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [MaxLength(256)]
        public string Name { set; get; }

        [MaxLength()]
        public string Content { set; get; }

        [MaxLength(256)]
        public string MetaDescription { set; get; }

        [MaxLength(256)]
        public string MetaKeyword { set; get; }

        public bool? Status { set; get; }
    }
}
