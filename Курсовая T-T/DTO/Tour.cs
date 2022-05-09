using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("tour")]
    public class Tour : BaseDTO
    {
        [Column("id_tour")]
        public int IdTour { get; set; }
        [Column("type_of_tour")]
        public string TypeOfTour { get; set; }
        [Column("id_gid")]
        public int GidsId { get; set; }
    }
}
