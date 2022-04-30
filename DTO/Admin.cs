using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("admin")]
    public class Admin : BaseDTO
    {
        [Column("login")]
        public string Login { get; set; }
        [Column("password")]
        public string Password { get; set; }
    }
}
