namespace ShopCet47.Web.Models
{
    using Microsoft.AspNetCore.Http;
    using ShopCet47.Web.Data.Entities;
    using System.ComponentModel.DataAnnotations;
    public class ProductViewModel : Product
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }
    }
}
