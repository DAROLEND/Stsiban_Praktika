using System;

namespace FlowerStore.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int FlowerId { get; set; }
        public DateTime Date { get; set; }
    }
}
