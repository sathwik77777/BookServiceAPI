using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookServiceAPI.Entities
{
    [Table("Books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        [Column("BookName",TypeName ="varchar")]
        public string? BookName { get; set; }
        [Required]
        public double BookPrice { get; set; }
        [Required]
        [StringLength(50)]
        [Column("Authorname",TypeName ="varchar")]
        public string? Author { get; set; }
        [Required]
        [StringLength(50)]
        [Column("Language",TypeName = "varchar")]
        public string? Lang { get; set; }
        [Column("ReleasedYear",TypeName ="int")]
        public int Year { get; set; }

    }
}
