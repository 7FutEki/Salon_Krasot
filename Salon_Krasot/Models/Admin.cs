using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salon_Krasot.Models
{
    public class Admin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
        public string? Passport { get; set; }
        public int? DivCode { get; set; }
        public string? Sex { get; set; }
        public DateOnly? DateBirthday { get; set; }
        public string? Category { get; set; }
        public double? CoefZp { get; set; }
    }
}
