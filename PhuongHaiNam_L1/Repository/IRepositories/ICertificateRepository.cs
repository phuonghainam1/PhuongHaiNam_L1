using System;
using PhuongHaiNam_L1.Models;
namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface ICertificateRepository
{
    List<Certificate> GetAll();
    Certificate? GetById(int id);
    void Add(Certificate certificate);
    void Update(Certificate certificate);
    void Delete(int id);
    List<Certificate> GetByEmployeeId(int employeeId);
}
