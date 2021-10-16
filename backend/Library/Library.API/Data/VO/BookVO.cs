using System;

namespace Library.API.Data.VO
{
    public class BookVO
    {
        public Int32 Id { get; set; }
        public string Author { get; set; }
        public DateTime Launch_Date { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}
