using Microsoft.AspNetCore.Mvc;

namespace PtpLab6.Controllers
{
    public class PtpHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StudentInfo()
        {
            ViewBag.Name = "Phạm Tuấn Phong";     // Thay bằng họ tên của bạn
            ViewBag.MSSV = "2310900081";        // Thay bằng MSSV của bạn
            ViewBag.Class = "K23CNTT1";          // Thay bằng lớp học

            return View();
        }
    }
}
