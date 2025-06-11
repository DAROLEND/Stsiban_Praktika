using System;

namespace BookStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }   // ID покупки
        public string Person { get; set; }    // Покупець
        public string Address { get; set; }   // Адреса
        public int BookId { get; set; }       // ID книги
        public DateTime Date { get; set; }    // Дата покупки
    }
}
