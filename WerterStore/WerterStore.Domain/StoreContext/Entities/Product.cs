﻿namespace WerterStore.Domain.StoreContext.Entities
{
    public class Product
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        

        public Product(string title, string description, string image, decimal price, int quantityOnHand)
        {
            Title = title;
            Description = description;
            Image = image;
            Price = price;
            QuantityOnHand = quantityOnHand;
        }

        public override string ToString()
        {
            return Title;
        }

        public void RemoveFromStock(int quantity)
        {
            QuantityOnHand -= quantity;
        }

        internal void ReturnToStock(int quantity)
        {
            QuantityOnHand += quantity;
        }
    }
}
