using DemoProj.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoProj.Model.Models
{
    [Table("Posts")]
    public class Post : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(256)]
        public string Name { set; get; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        public int PostCategoryID { set; get; }

        [MaxLength(500)]
        public string Image { set; get; }

        [MaxLength(500)]
        public string Description { set; get; }

        [MaxLength()]
        public string Content { set; get; }

        public bool? HomeFlag { set; get; }

        public bool? HotFlag { set; get; }

        public int? ViewCount { set; get; }

        public virtual IEnumerable<PostTag> PostTags { set; get; }

        [ForeignKey("PostCategoryID")]
        public virtual PostCategory PostCategories { set; get; }
    }
}
