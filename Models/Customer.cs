
namespace AMS1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    public partial class Customer
    {
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Sales = new HashSet<Sale>();
        }
    
        [Required(ErrorMessage = "Please enter a vlid email.")]
        public string CustomerID { get; set; }
        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a surname.")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Please enter an address")]
        public string Shipping_Address { get; set; }
        [Required(ErrorMessage = "Please enter a number")]
        public string Phone_Number { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
