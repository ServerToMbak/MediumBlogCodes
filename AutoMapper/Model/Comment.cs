using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapper_DTO.Model
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentMessage { get; set; }
        [ForeignKey("Comments")]
        public int PostId { get; set; }
        public Post Post { get; set; }
    }
}
