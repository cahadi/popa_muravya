using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("group")]
    public class Group : BaseDTO
    {
        [Column("id_group")]
        public int IdGroup { get; set; }
        [Column("login_gid")]
        public string LoginGid { get; set; }
        [Column("login_user")]
        public string LoginUser { get; set; }
        [Column("id_tour")]
        public int IdTour { get; set; }
    }
}
