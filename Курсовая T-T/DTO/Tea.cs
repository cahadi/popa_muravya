using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("tea")]
    public class Tea : BaseDTO
    {
        [Column("id_tea")]
        public int IdTea { get; set; }
        [Column("types_of_tea")]
        public string Types_Of_Tea { get; set; }
        [Column("kinds_of_tea")]
        public string Kinds_Of_Tea { get; set; }
        [Column("sorts_of_tea")]
        public string Sorts_Of_Tea { get; set; }
    }
}
