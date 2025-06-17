using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;
namespace PhuongHaiNam_L1.Repository.Repositories;

public class EmployeeRepository : IEmployeeRepository
{
    EmployeeManagementContext _context;
    public EmployeeRepository()
    {
        _context = new EmployeeManagementContext();
    }

    public List<Employee> GetAllEmployees()
    {
        return _context.Employees
                .Include(e => e.Ethnic)
                .Include(e => e.Job)
                .Include(e => e.City)
                .Include(e => e.District)
                .Include(e => e.Ward)
                .ToList();
    }

    public Employee GetEmployeeById(int id)
    {
        var employee = _context.Employees
                .Include(e => e.Ethnic)
                .Include(e => e.Job)
                .Include(e => e.City)
                .Include(e => e.District)
                .Include(e => e.Ward)
                .FirstOrDefault(e => e.EmployeeId == id);
        if (employee == null)
        {
            throw new KeyNotFoundException($"Employee with ID {id} not found.");
        }
        else
        {
            return employee;
        }
    }

    public void AddEmployee(Employee employee)
    {
        _context.Employees.Add(employee);
        _context.SaveChanges();
    }

    public void UpdateEmployee(Employee employee)
    {
        _context.Employees.Update(employee);
        _context.SaveChanges();
    }

    public void DeleteEmployee(int id)
    {
        var employee = _context.Employees.Find(id);
        if (employee == null)
        {
            throw new KeyNotFoundException($"Employee with ID {id} not found.");
        }
        else
        {
            _context.Employees.Remove(employee);
            _context.SaveChanges();
        }

    }

    public List<Certificate> GetCertificatesByEmployeeId(int employeeId)
    {
        return _context.Certificates
        .Where(c => c.EmployeeId == employeeId)
        .ToList();
    }

    public void AddCertificateToEmployee(Certificate certificate)
    {
        _context.Certificates.Add(certificate);
        _context.SaveChanges();
    }
}
