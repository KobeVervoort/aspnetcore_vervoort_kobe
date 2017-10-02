using System;

namespace aspnetcore_vervoort_kobe.Models
{
    public class AboutModel
    {
        public string Name { get; set; }

        public DateTime Now => DateTime.Now;
        public double DaysUntilBirthday { get; set; }
    }
}