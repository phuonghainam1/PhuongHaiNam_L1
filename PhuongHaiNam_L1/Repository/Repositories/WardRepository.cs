using System;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class WardRepository : IWardRepository
{
    EmployeeManagementContext _context;
    public WardRepository()
    {
        _context = new EmployeeManagementContext();
    }

    public void Add(Ward ward)
    {
        _context.Wards.Add(ward);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var ward = _context.Wards.Find(id);
        if (ward != null)
        {
            _context.Wards.Remove(ward);
            _context.SaveChanges();
        }
    }

    public List<Ward> GetAll()
    {
        return _context.Wards.ToList();
    }

    public Ward? GetById(int id)
    {
        return _context.Wards.Find(id);
    }

    public void Update(Ward ward)
    {
        _context.Wards.Update(ward);
        _context.SaveChanges();
    }
}
