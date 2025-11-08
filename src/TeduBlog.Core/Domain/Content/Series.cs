using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduBlog.Core.Domain.Content
{
    public class Series
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(250)]
        [Required]
        public required string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public required string Slug { get; set; }

        [MaxLength(250)]
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public int SortOrder {  get; set; }
        [MaxLength(250)]
        public string? SeoDescription { get; set; }
        [MaxLength(250)]
        public string? Thumbnail { get; set; }
        public string? Content { get; set; }
        public Guid OwnerUserId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
