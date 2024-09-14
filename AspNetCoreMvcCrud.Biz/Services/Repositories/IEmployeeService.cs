﻿using AspNetCoreMvcCrud.Data.Models;

namespace AspNetCoreMvcCrud.Biz.Service;

public interface IEmployeeService
{
    IEnumerable<Employee> GetAllEmployees();

    Employee GetEmployeeById(int id);

    void AddEmployee(Employee employee);

    void UpdateEmployee(Employee employee);

    void DeleteEmployee(int id);
}