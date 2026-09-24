using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Nvm_Lesson09.Models.DataViewModels;

    public class NvmMemberRegister
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = "Error Username")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Dai qua ky tu cho phep 3-20")]
        public string MemName { get; set;}

        [DisplayName("Id")]
        [Required(ErrorMessage = "Error Id")]
        [DataType(DataType.Password)]
        public string MemId { get; set;}
        public string MemClass { get; set;}
    }
