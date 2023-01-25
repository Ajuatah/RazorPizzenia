using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzenia.Models;

namespace RazorPizzenia.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle ="Margerita",
                PizzaName = "Ajua Meal",
                BasePrice =2,
                TomatoSauce= true,
                Cheese =true,
                FinalPrice =4
            },
			new PizzasModel()
			{
				ImageTitle ="vegetarian",
				PizzaName = "Ajua Meal",
				BasePrice =10,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =12
			},
			new PizzasModel()
			{
				ImageTitle ="Carbonara",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="Bolognese",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="MeatFeast",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="Mushroom",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="Pepperoni",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="SeaFood",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			},
			new PizzasModel()
			{
				ImageTitle ="Hawaiian",
				PizzaName = "Ajua Meal",
				BasePrice =2,
				TomatoSauce= true,
				Cheese =true,
				FinalPrice =4
			}
		};
        public void OnGet()
        {
        }
    }
}
