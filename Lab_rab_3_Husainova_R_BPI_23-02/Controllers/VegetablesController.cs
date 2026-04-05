using Lab_rab_3_Husainova_R_BPI_23_02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_rab_3_Husainova_R_BPI_23_02.Controllers
{
    public class VegetablesController : Controller
    {
        public ActionResult FirstViewMethod()
        {
            // Создаем список овощей
            List<Vegetable> veggies = new List<Vegetable>
             {
                 new Vegetable { Id = 1, Name = "Картофель" },
                 new Vegetable { Id = 2, Name = "Морковь" },
                 new Vegetable { Id = 3, Name = "Лук" },
                 new Vegetable { Id = 4, Name = "Капуста" },
                 new Vegetable { Id = 5, Name = "Свекла" }
             };
            // Передаем список в представление в качестве модели
            return View(veggies);
        }
    }
}