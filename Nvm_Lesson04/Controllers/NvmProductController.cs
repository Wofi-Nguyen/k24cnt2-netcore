using Microsoft.AspNetCore.Mvc;
using Nvm_Lesson04.Models;

namespace Nvm_Lesson04.Controllers
{
    public class NvmProductController : Controller
    {
        public IActionResult NvmIndex()
        {
            ViewBag.NvmAccount = accounts;
            return View();
        }

        public readonly List<NvmAccount> accounts = new()
        {
            new NvmAccount()
            {
                Id = 1,
                Name = "Nguyễn Văn Mỹ",
                Email = "my.nv@example.com",
                Phone = "0912345678",
                Avatar = "/img/1 (1).jpg",
                Address = "Hà Nội",
                Bio = "Lập trình viên backend C#",
                Gender = 1,
                Date = new DateOnly(2003, 5, 15)
            },
            new NvmAccount()
            {
                Id = 2,
                Name = "Trần Thị Hoa",
                Email = "hoa.tt@example.com",
                Phone = "0987654321",
                Avatar = "/img/1 (1).jpg",
                Address = "Đà Nẵng",
                Bio = "Chuyên viên thiết kế UI/UX",
                Gender = 0,
                Date = new DateOnly(2004, 8, 22)
            },
            new NvmAccount()
            {
                Id = 3,
                Name = "Lê Hoàng Nam",
                Email = "nam.lh@example.com",
                Phone = "0905123456",
                Avatar = "/img/1 (1).jpg",
                Address = "TP. Hồ Chí Minh",
                Bio = "Kỹ sư kiểm thử phần mềm (QA)",
                Gender = 1,
                Date = new DateOnly(2002, 11, 10)
            },
            new NvmAccount()
            {
                Id = 4,
                Name = "Phạm Thị Lan",
                Email = "lan.pt@example.com",
                Phone = "0934567890",
                Avatar = "/img/1 (1).jpg",
                Address = "Hải Phòng",
                Bio = "Chuyên viên quản lý dự án",
                Gender = 0,
                Date = new DateOnly(2001, 3, 5)
            },
            new NvmAccount()
            {
                Id = 5,
                Name = "Hoàng Minh Tuấn",
                Email = "tuan.hm@example.com",
                Phone = "0978112233",
                Avatar = "/img/1 (1).jpg",
                Address = "Cần Thơ",
                Bio = "Kỹ sư DevOps & Cloud",
                Gender = 1,
                Date = new DateOnly(2000, 12, 18)
            },
            new NvmAccount()
            {
                Id = 6,
                Name = "Vũ Thuỳ Linh",
                Email = "linh.vt@example.com",
                Phone = "0918223344",
                Avatar = "/img/1 (1).jpg",
                Address = "Bắc Ninh",
                Bio = "Chuyên viên phân tích dữ liệu",
                Gender = 0,
                Date = new DateOnly(2003, 7, 30)
            },
            new NvmAccount()
            {
                Id = 7,
                Name = "Đặng Quốc Bảo",
                Email = "bao.dq@example.com",
                Phone = "0966445566",
                Avatar = "/img/1 (1).jpg",
                Address = "Quảng Ninh",
                Bio = "Lập trình viên Frontend React",
                Gender = 1,
                Date = new DateOnly(2002, 1, 25)
            },
            new NvmAccount()
            {
                Id = 8,
                Name = "Bùi Mai Anh",
                Email = "anh.bm@example.com",
                Phone = "0944778899",
                Avatar = "/img/1 (1).jpg",
                Address = "Huế",
                Bio = "Chuyên viên Marketing số",
                Gender = 0,
                Date = new DateOnly(2004, 9, 12)
            },
            new NvmAccount()
            {
                Id = 9,
                Name = "Đỗ Hữu Thắng",
                Email = "thang.dh@example.com",
                Phone = "0922336677",
                Avatar = "/img/1 (1).jpg",
                Address = "Nghệ An",
                Bio = "Chuyên viên an toàn thông tin",
                Gender = 1,
                Date = new DateOnly(1999, 6, 20)
            },
            new NvmAccount()
            {
                Id = 10,
                Name = "Ngô Thị Thu",
                Email = "thu.nt@example.com",
                Phone = "0955889900",
                Avatar = "/img/1 (1).jpg",
                Address = "Lâm Đồng",
                Bio = "Kế toán viên doanh nghiệp",
                Gender = 0,
                Date = new DateOnly(2001, 10, 8)
            }
        };
        [Route("profile/{id?}", Name = "NvmProfile")]
        public IActionResult NvmProfile(int? id)
        {
            NvmAccount nvmProfile = new NvmAccount()
            {
                Id = 10,
                Name = "Ngô Thị Thu",
                Email = "thu.nt@example.com",
                Phone = "0955889900",
                Avatar = "/img/1 (1).jpg",
                Address = "Lâm Đồng",
                Bio = "Kế toán viên doanh nghiệp",
                Gender = 0,
                Date = new DateOnly(2001, 10, 8)
            };
            if (id != null)
                nvmProfile = accounts.FirstOrDefault(x => x.Id == id);
            ViewBag.NvmProfile = nvmProfile;
            return View();
        }
    }
}
