using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopCet47.Web.Data.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Order Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime OrderDate { get; set; }


        [Display(Name = "Delivery Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd hh:mm tt}", ApplyFormatInEditMode = false)]
        public DateTime? DeliveryDate { get; set; }


        [Required]
        public User User { get; set; }


        public IEnumerable<OrderDetail> Items { get; set; }


        [DisplayFormat(DataFormatString = "{0:N2)")]
        public double Quantity { get { return this.Items == null ? 0 : this.Items.Sum(i => i.Quantity); } }


        [DisplayFormat(DataFormatString = "{0:C2)")]
        public decimal Value { get { return this.Items == null ? 0 : this.Items.Sum(i => i.Value); } }
    }
}
