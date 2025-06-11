using System;

namespace FlowerStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        // Ім’я та прізвище покупця
        public string CustomerName { get; set; }

        // Адреса доставки
        public string Address { get; set; }

        // ID квітки
        public int FlowerId { get; set; }

        // Дата замовлення
        public DateTime OrderDate { get; set; }
    }
}
