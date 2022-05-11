using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Курсовая_T_T.Tools;

namespace Курсовая_T_T.DTO
{
    [Table("comment")]
    public class Comment : BaseDTO
    {
        [Column("id_comment")]
        public int IdComment { get; set; }
        [Column("content")]
        public string Content { get; set; }
    }
}
