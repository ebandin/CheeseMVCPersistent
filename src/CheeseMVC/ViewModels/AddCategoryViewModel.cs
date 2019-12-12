using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddCategoryViewModel
    {
        [Required]
        [Display(Name= "Category Name")]
        public string Name { get; set; }
        

        [Required(ErrorMessage = "You must give your cheese a category")]

        public double ID { get; set; }

        public List<SelectListItem> CheeseCategories { get; set; }

        public AddCategoryViewModel()
        {

            CheeseCategories = new List<SelectListItem>();

            // <option value="0">Hard</option>
            CheeseCategories.Add(new SelectListItem
            {
                Value = ((int)CheeseCategories.Hard).ToString(),
                Text = CheeseCategories.Hard.ToString()
            });

            CheeseCategories.Add(new SelectListItem
            {
                Value = ((int)CheeseCategories.Soft).ToString(),
                Text = CheeseCategories.Soft.ToString()
            });

            CheeseCategories.Add(new SelectListItem
            {
                Value = ((int)CheeseCategories.Fake).ToString(),
                Text = CheeseCategories.Fake.ToString()
            });

        }
    }
}
