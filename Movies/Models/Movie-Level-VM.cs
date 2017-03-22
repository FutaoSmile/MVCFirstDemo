using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movies.Models
{
    public class Movie_Level_VM
    {
        //通过VM在View层获取数据传到后端后再将VM的值赋给每个Model
        public int Movie_ID { get; set; }
        public DateTime ReleseTime { get; set; }
        public string Title { get; set; }
        public decimal Price{ get; set; }
        public int Level_ID { get; set; }
    }
}