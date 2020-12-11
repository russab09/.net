using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Lesson : IComparable
    {
        public int hour;
        public int minute;
        public string lesson;
        public int CompareTo(object two)
        {
            Lesson p = two as Lesson;
            if (p != null)
                if (this.hour != p.hour)
                    return this.hour.CompareTo(p.hour);
                else
                    return this.minute.CompareTo(p.minute);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    };
}