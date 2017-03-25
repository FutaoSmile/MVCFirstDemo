using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;

namespace MovieEF
{    
    public class Movie
    {
        /// <summary>
        /// 电影ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 电影名
        /// </summary>
        [Display(Name = "电影名称")]
        [Required]
        public string Title { get; set; }
        /// <summary>
        /// 上映时间
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayName("上映时间")]
        [Required]
        // [DateTime]   
        public DateTime ReleaseTime { get; set; }
        /// <summary>
        /// 影片类型
        /// </summary>
        [Required]
        //[RegularExpression(@"\d{n}",ErrorMessage = "必须只能是数字")]
        [DisplayName("电影类别")]
        [StringLength(5, MinimumLength = 3, ErrorMessage = "字符长度3-5")]
        public string Genre { get; set; }
        /// <summary>
        /// 票价
        /// </summary>
        [Required]
        [Range(20, 100)]
        [DisplayName("电影票价")]
        public decimal Price { get; set; }
        /// <summary>
        /// 一部电影只属于一个级别
        /// </summary>
        [DisplayName("电影级别")]
        public virtual Level level { get; set; }
    }
}
