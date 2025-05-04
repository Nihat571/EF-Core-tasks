// See https://aka.ms/new-console-template for more information
using EF_CORE_Practice.Models;
using EF_CORE_Practice.Services;

public class Program
{
    public static void Main(string[] args)
    {
        MealService mealService = new MealService();
        Meal meal = new Meal()
        {
            Name = "meal1",
            Description = "desc1",
            Price = 12
        };
        Meal meal2 = new Meal()
        {
            Name = "meal2",
            Description = "desc2",
            Price = 15
        };


        mealService.AddMeal(meal2);
    }
}
