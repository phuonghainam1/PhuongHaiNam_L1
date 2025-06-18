using System;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class CertificateRepository : ICertificateRepository
{   
    EmployeeManagementContext _context;
    public CertificateRepository()
    {
        _context = new EmployeeManagementContext();
    }
    public void Add(Certificate certificate)
    {
        _context.Certificates.Add(certificate);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var certificate = _context.Certificates.Find(id);
        if (certificate != null)
        {
            _context.Certificates.Remove(certificate);
            _context.SaveChanges();
        }
    }

    public List<Certificate> GetAll()
    {
        return _context.Certificates.ToList();  
    }

    public List<Certificate> GetByEmployeeId(int employeeId)
    {
       return _context.Certificates
            .Where(c => c.EmployeeId == employeeId)
            .ToList();
    }

    public Certificate? GetById(int id)
    {
        return _context.Certificates.Find(id);
    }

    public void Update(Certificate certificate)
    {
       _context.Certificates.Update(certificate);
        _context.SaveChanges();
    }
}
