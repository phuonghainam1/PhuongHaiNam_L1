using System;
using PhuongHaiNam_L1.Repository.IRepositories; 
using PhuongHaiNam_L1.Models;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class EthnicRepository : IEthnicRepository
{
    EmployeeManagementContext _context;
    public EthnicRepository()
    {
        _context = new EmployeeManagementContext();
    }

    public void Add(Ethnic ethnic)
    {
        _context.Ethnics.Add(ethnic);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var employee = _context.Ethnics.Find(id);
        if (employee != null)
        {
            _context.Ethnics.Remove(employee);
            _context.SaveChanges();
        }
    }

    public List<Ethnic> GetAll()
    {
        return _context.Ethnics.ToList();
    }

    public Ethnic? GetById(int id)
    {
       return _context.Ethnics.Find(id);
         
    }
    public void Update(Ethnic ethnic)
    {
        _context.Ethnics.Update(ethnic);
        _context.SaveChanges();
    }
}
