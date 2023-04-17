using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizza.Models;

namespace RazorPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){ImageTitle="Margerita",PizzaName="Margerita",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=5},
            new PizzasModel(){ImageTitle="Hawaiian",PizzaName="Hawaiian",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=15},
            new PizzasModel(){ImageTitle="Carbonara",PizzaName="Carbonara",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=6 },
            new PizzasModel(){ImageTitle="MeatFeast",PizzaName="MeatFeast",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=6},
            new PizzasModel(){ImageTitle="Pepperoni",PizzaName="Pepperoni",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=5 },
            new PizzasModel(){ImageTitle="seaFood",PizzaName="seaFood",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=5 },
            new PizzasModel(){ImageTitle="vegetarian",PizzaName="vegetarian",BasePrice=2,TomatoSauce=true,Cheese=true,FinalPrice=12 }

        };
        public void OnGet()
        {
        }
    }
}
