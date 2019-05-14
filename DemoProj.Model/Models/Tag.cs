using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace DemoProj.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { set; get; }

        [MaxLength(50)]
        public string Name { set; get; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Type { set; get; }


        public IEnumerable<ProductTag> ProductTags { set; get; }


        public IEnumerable<PostTag> PostTags { set; get; }

    }
}
