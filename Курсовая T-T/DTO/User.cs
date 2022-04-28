using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("user")]
    public class User : BaseDTO
    {
        [Column("id_user")]
        public int UserID { get; set; }
        [Column("name")]
        public string Name{get;set;}
        [Column("lastnane")]
        public string LastName { get; set; }

    }
}
