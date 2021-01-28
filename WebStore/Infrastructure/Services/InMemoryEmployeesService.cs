using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrastructure.Services
{
    public class InMemoryEmployeesService : IEmployeesService
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

        public void AddNew(EmployeeView employeeView)
        {
            employeeView.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employeeView);
        }

        public void Commit()
        {
            //TODO
        }

        public void Delete(int id)
        {
            var employee = GetById(id);
            if(employee is null)
                return;
            _employees.Remove(employee);
        }

        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }

        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
