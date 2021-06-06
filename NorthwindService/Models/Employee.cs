using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindService.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        public string AdSoyad { get; set; }
        public string TcNo { get; set; }
        public DateTime GirisSaati { get; set; }
        public string Aciklama { get; set; }
    }
}
