using CoreLogic.Data;
using CoreLogic.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLogic.Services;

public class UserService
{
    MyContext ctx;
    public UserService()
    {
        ctx = new MyContext();
    }
    public void AddUser(User user)
    {
        ctx.Users.Add(user);
        ctx.SaveChanges();
    }
    public List<User> GetAll()
    {
       /* var users = new List<User>()
         {
            new User() { Id = 1,Name = "Sam" , City = "India" , Email = "sam@123" , Password="12345" , Phone= "6266784183"},
            new User() { Id = 2,Name = "Ted" , City = "USA" , Email = "ted@123" , Password= "3456" , Phone="4679898668" }
            
         }; */
        var users = ctx.Users.ToList();
        return users;
    }
}
