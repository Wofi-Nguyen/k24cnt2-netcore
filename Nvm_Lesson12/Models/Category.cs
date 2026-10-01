using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nvm_Lesson12.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Name không hợp lệ")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string? Name { get; set; }

        [Column(TypeName = "tinyint")]
        public byte? Status { get; set; }

        [Required(ErrorMessage = "Date không hợp lệ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? CreateDate { get; set; }
        public ICollection<NvmProduct>? Products { get; set; }


    }
}
