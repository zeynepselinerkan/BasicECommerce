﻿using ECommerceApp.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.Domain.Entities
{
    public class Employee : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime BirtDate { get; set; }
        public Status Status { get; set; }
        public Roles Roles { get; set; }

        // Navigation prop
        public Guid? MallId { get; set; }
        public Mall? Mall { get; set; }

        // Navigation prop for managers
        public Guid ManagerId { get; set; }
        public Employee? Manager { get; set; }
        public List<Employee> Employees { get; set; }
        public Employee()
        {
            Employees= new List<Employee>();
        }
    }
}
