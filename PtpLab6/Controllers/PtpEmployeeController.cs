using Microsoft.AspNetCore.Mvc;
using PtpLab06.Models;

namespace PtpLab06.Controllers
{
    public class PtpEmployeeController : Controller
    {
        // Danh sách nhân viên mẫu (cố định, chưa có database)
        public static List<PtpEmployee> ptpListEmployee = new List<PtpEmployee>
        {
            new PtpEmployee { PtpId = 1, PtpName = "Nguyễn Văn A", PtpBirthDay = new DateTime(2002, 1, 1), PtpEmail = "a@example.com", PtpPhone = "0123456789", PtpSalary = 5000, PtpStatus = true },
            new PtpEmployee { PtpId = 2, PtpName = "Trần Thị B", PtpBirthDay = new DateTime(1998, 5, 5), PtpEmail = "b@example.com", PtpPhone = "0987654321", PtpSalary = 6000, PtpStatus = true },
            new PtpEmployee { PtpId = 3, PtpName = "Lê Văn C", PtpBirthDay = new DateTime(1995, 3, 3), PtpEmail = "c@example.com", PtpPhone = "0123987654", PtpSalary = 4000, PtpStatus = false },
            new PtpEmployee { PtpId = 4, PtpName = "Phạm Thị D", PtpBirthDay = new DateTime(1992, 7, 7), PtpEmail = "d@example.com", PtpPhone = "0911222333", PtpSalary = 4500, PtpStatus = true },
            new PtpEmployee { PtpId = 5, PtpName = "Tên Sinh Viên", PtpBirthDay = new DateTime(2001, 10, 10), PtpEmail = "sinhvien@example.com", PtpPhone = "0999888777", PtpSalary = 7000, PtpStatus = true }
        };

        public IActionResult PtpIndex()
        {
            return View(ptpListEmployee);
        }

        [HttpGet]
        public IActionResult PtpCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PtpCreateSubmit(PtpEmployee emp)
        {
            emp.PtpId = ptpListEmployee.Max(e => e.PtpId) + 1;
            ptpListEmployee.Add(emp);
            return RedirectToAction("PtpIndex");
        }
    }
}

