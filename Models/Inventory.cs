
namespace AMS1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inventory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inventory()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Category { get; set; }
        public decimal Price { get; set; }
        public string Colour { get; set; }
        public byte[] Image { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
