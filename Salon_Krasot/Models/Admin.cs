using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Krasot.Models
{
    public class Admin
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Passport { get; set; }
        public int DivCode { get; set; }
        public string Sex { get; set; }
        public DateOnly DateBirthday { get; set; }
        public string Category { get; set; }
        public int CoefZp { get; set; }
    }
}
