namespace FlowerStore.Models
{
    public class Flower
    {
        // ID квітки
        public int Id { get; set; }

        // Назва квітки
        public string Name { get; set; }

        // Тип (наприклад: троянда, тюльпан)
        public string Type { get; set; }

        // Ціна за одиницю
        public decimal Price { get; set; }
    }
}
