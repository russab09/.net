using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Week
    {
        WeekDay[] data;
        public Week()
        {
            data = new WeekDay[7];
        }
        public WeekDay this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }
}