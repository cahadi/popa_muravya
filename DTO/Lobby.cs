using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("lobby")]
    public class Lobby : BaseDTO
    {
        [Column("id_tour")]
        public int IdTour { get; set; }
        [Column("id_user")]
        public int IdUser { get; set; }
        [Column("day")]
        public DateTime Day{ get; set; }
        public User User { get; set; }
        public Tour Tour { get; set; }
    }
}
