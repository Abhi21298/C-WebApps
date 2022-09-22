using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace AmazonWeb.Core.Entities
{
    public class Cart : Entity
    {
        public string UserName { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        //public void AddItem(int productid, int quantity =1,string color = "Black", decimal productprice =0)
        //{
        //    var existingItem = Items.FirstOrDefault(i => i.ProductId == productid);
        //    if(existingItem!=null)
        //    {
        //        existingItem.Quantity++;
        //        existingItem.TotalPrice = existingItem.Quantity + existingItem.UnitPrice;
        //    }
        //    else
        //    {
        //        Items.Add(new CartItem()
        //        { 
        //            ProductId = productid,
        //            Quantity = quantity,
        //            UnitPrice = productprice,
        //            Color = color,
        //            TotalPrice = quantity * productprice
        //        });
        //    }
            
        //}
        //public void RemoveItem(int cartitemid)
        //{
        //    var removedItem = Items.FirstOrDefault(p => p.Id == cartitemid);
        //    if(removedItem!=null)
        //    {
        //        Items.Remove(removedItem);
        //    }
        //}

        //public void RemoveItemWithProduct(int productid)
        //{
        //    var removedItem = Items.FirstOrDefault(p => p.ProductId == productid);
        //    if (removedItem != null)
        //    {
        //        Items.Remove(removedItem);
        //    }
        //}
        //public void ClearItems()
        //{
        //    Items.Clear();
        //}
    }
}
