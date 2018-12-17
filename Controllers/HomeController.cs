using System;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using crudelicious.Models;

namespace crudelicious.Controllers
{
    public class HomeController : Controller
    {
        private CrudContext dbContext;

        public HomeController(CrudContext context)
        {
            dbContext = context;
        }
        

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.OrderByDescending(dish => dish.id).ToList();
            ViewBag.AllDishes = AllDishes;
            return View();
        }

        [HttpGet("New")]
        public IActionResult New()
        {
            return View();
        }

        [HttpGet("{DishId}")]
        public IActionResult Info(int DishId)
        {
            Dish DishInfo = dbContext.Dishes.FirstOrDefault(dish => dish.id == DishId);
            ViewBag.Dish = DishInfo;
            return View();
        }

        [HttpGet("Edit/{DishId}")]
        public IActionResult Edit(int DishId)
        {
            Dish DishInfo = dbContext.Dishes.FirstOrDefault(dish => dish.id == DishId);
            ViewBag.Dish = DishInfo;
            return View();
        }

        [HttpPost("New")]
        public IActionResult New(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("New");
            }
        }

        [HttpPost("Edit/{DishId}")]
        public IActionResult Edit(int DishId, Dish dish)
        {
            Dish DishUpdate = dbContext.Dishes.SingleOrDefault(d => d.id == DishId);
            if(ModelState.IsValid)
            {
                DishUpdate.Name = dish.Name;
                DishUpdate.Chef = dish.Chef;
                DishUpdate.Calories = dish.Calories;
                DishUpdate.Tastiness = dish.Tastiness;
                DishUpdate.Description = dish.Description;
                DishUpdate.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();
                return RedirectToAction("Info", DishId);
            }
            else
            {
                ViewBag.Dish = dish;
                return View("Edit");
            }
        }

        [HttpGet("Delete/{DishId}")]
        public IActionResult Delete(int DishId)
        {
            Dish DishDelete = dbContext.Dishes.SingleOrDefault(d => d.id == DishId);
            dbContext.Dishes.Remove(DishDelete);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}