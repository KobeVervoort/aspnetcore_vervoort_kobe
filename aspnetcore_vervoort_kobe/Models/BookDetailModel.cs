using System;
namespace aspnetcore_vervoort_kobe.Models
{
    public class BookDetailModel
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
