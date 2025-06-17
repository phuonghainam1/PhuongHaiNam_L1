using System;
using System.Collections.Generic;
using PhuongHaiNam_L1.Models;
namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface IEmployeeRepository
{
    List<Employee> GetAllEmployees();
    Employee GetEmployeeById(int id);
    void AddEmployee(Employee employee);            
    void UpdateEmployee(Employee employee);
    void DeleteEmployee(int id);
    List<Certificate> GetCertificatesByEmployeeId(int employeeId);
    void AddCertificateToEmployee(Certificate certificate);
}
