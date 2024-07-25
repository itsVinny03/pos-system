using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public static class CartManager
    {
        public static List<CartItem> CartItems { get; } = new List<CartItem>();

        public static void AddToCart(string name, decimal price)
        {
            var existingItem = CartItems.FirstOrDefault(item => item.Name == name);
            if (existingItem != null)
            {
                existingItem.Quantity++;
                existingItem.TotalPrice = existingItem.Quantity * existingItem.Price;
            }
            else
            {
                CartItems.Add(new CartItem(name, price, 1));
            }
        }

        public static void RemoveFromCart(string name)
        {
            var existingItem = CartItems.FirstOrDefault(item => item.Name == name);
            if (existingItem != null)
            {
                if (existingItem.Quantity > 1)
                {
                    existingItem.Quantity--;
                    existingItem.TotalPrice = existingItem.Quantity * existingItem.Price;
                }
                else
                {
                    CartItems.Remove(existingItem);
                }
            }
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public CartItem(string name, decimal price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalPrice = price * quantity;
        }
    }
}
