using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFirstDemo.Models
{
    public class Order
    {
        public Order()
        {
            CreateTime = DateTime.Now;
            UpDateTime=DateTime.Now;
            
        }

        public int Id  { get; set; }
        public string OrderName { get; set; }   
        public DateTime CreateTime { get; set; }
        public DateTime UpDateTime { get; set; }
    }
}