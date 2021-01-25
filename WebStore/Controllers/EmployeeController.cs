using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
             new EmployeeView
            {
                Id = 1,
                FirstName = "Василий" ,
                SurName = "Путин" ,
                Patronymic = "Владимирович" ,
                Age = 73,
                Position = "Президент"
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Дмитрий" ,
                SurName = "Песков" ,
                Patronymic = "Федорович" ,
                Age = 30,
                Position = "Заместитель президента"
            }
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Employees()
        {
            return View(_employees);
        }
        public IActionResult EmployeeDetails(int id)
        {
            //Получаем сотродника по Id
            var employee = _employees.FirstOrDefault(t => t.Id == id);
            //Проверка на существует ли данный сотрудник
            if (employee == null)
                return NotFound();
            //Возвращаем сотрудника
            return View(employee);
        }
    }
}