using System;
using System.Collections.Generic;
using System.ComponentModel;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MVCPubs.Models
{
    public partial class Store
    {
        public Store()
        {
            Sales = new HashSet<Sale>();
        }
        [DisplayName("ID")]
        public string StorId { get; set; }

        [DisplayName("Name")]
        public string StorName { get; set; }
        [DisplayName("Address")]
        public string StorAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }
    }
}
