using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nvm_Lesson12.Models
{
    public class NvmProduct
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name không hợp lệ")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string Image {  get; set; }

        [Required(ErrorMessage = "Price không hợp lệ")]
        public float Price { get; set; }
        public float Saleprice { get; set; }
        public byte Status { get; set; }

        [StringLength(1000,ErrorMessage = "Giới hạn 1000 ký tự")]
        [Column(TypeName = "ntext")]
        public string Descriptions { get; set; }

        [Required(ErrorMessage = "Danh mục sản phẩm không hợp lệ")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Date không hợp lệ")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime CategoryDate { get; set; }
        public Category Category { get; set; }
    }
}
