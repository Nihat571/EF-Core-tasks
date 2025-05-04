using EF_CORE_new_task.Contexts;
using EF_CORE_new_task.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_new_task.Services;

public class LoginServices
{
    private readonly LoginDbContext _context;
    public LoginServices()
    {
      _context = new LoginDbContext();
    }
    public void AddUser(User user)
    {
        _context.Users.Add(user);
         _context.SaveChanges();
        
        Console.WriteLine("register success");

    }

    public User ReadUser()
    {
        if (_context.Users is not null)
        {
            foreach (var user in _context.Users)
            {
                return user;
            }
        }
        return null;
       
    }

    public void UpdateUser(int id,User updatedUser) 
    {
        User foundedUser = _context.Users.Find(id);


        if (foundedUser is not null && id == updatedUser.Id)
        {
            foundedUser.UserName = updatedUser.UserName;
            foundedUser.Password = updatedUser.Password;
        }
        else 
        {
            throw new Exception($"{id} id-e uygun user tapilmadi");
        }
    }


 
}
