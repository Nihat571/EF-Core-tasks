using EF_CORE_Practice.Contexts;
using EF_CORE_Practice.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Practice.Services;

public class MealService
{
    private readonly RestoranIdareEtmeDbContext _context;
    private readonly DbSet<Meal> _meals;
    private readonly DbSet<Waiters> _waiters;
    public MealService()
    {
        _context = new RestoranIdareEtmeDbContext();
        _meals = _context.Meals;
        
    }

    #region CREATE
    public void AddMeal(Meal meal)
    {
    
        _meals.Add(meal);
        _context.SaveChanges();
    }

    public void AddMeals(List<Meal> meals)
    {
        _meals.AddRange(meals);
        _context.SaveChanges();
    }
    #endregion

    #region Read
    public Meal GetMeal(int id) 
    {
        Meal? foundedMeal = _context.Meals.Find(id);
        if (foundedMeal is not null)
        {
            return foundedMeal;
        }
        else
        {
            throw new Exception("Meal tapilmadi");
        }
          
    }

    #endregion

    public List<Meal> GetAllMeals()
    {
        List<Meal> meals  = _context.Meals.ToList();
        return meals;
    }
}
