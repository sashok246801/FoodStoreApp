using FoodStoreApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FoodStore.Models.ViewModels
{
    public class ProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
