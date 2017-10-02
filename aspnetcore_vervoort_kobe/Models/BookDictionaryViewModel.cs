using System;
using System.Collections.Generic;

namespace aspnetcore_vervoort_kobe.Models
{
    public class BookDictionaryViewModel
    {
        public Dictionary<int, BookDetailModel> Books { get; set; }
        public DateTime GeneratedAt => DateTime.Now;
    }
}
