
namespace AMS1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int SalesID { get; set; }
        public string CustomerID { get; set; }
        public int ItemID { get; set; }
        public decimal Total_Price { get; set; }
        public System.DateTime DateofPurchase { get; set; }
        public string PaymentMethod { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Inventory Inventory { get; set; }
    }
}
