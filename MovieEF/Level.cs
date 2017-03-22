using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieEF
{
    public class Level
    {
        /// <summary>
        /// 级别ID
        /// </summary>
        public int LevelID { get; set; }
        /// <summary>
        /// 级别名称
        /// </summary>
        [Required]
        [StringLength(10,MinimumLength = 1,ErrorMessage = "请控制长度在1-10之间")]
        public string LevelName { get; set; }
        /// <summary>
        /// 一个级别有多部电影
        /// </summary>
        public virtual List<Movie> movies { get; set; }
    }
}
