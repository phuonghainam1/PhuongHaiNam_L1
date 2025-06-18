using System;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class DistrictRepository : IDistrictRepository
{
    EmployeeManagementContext _context;
    public DistrictRepository()
    {
        _context = new EmployeeManagementContext();
    }

    public void Add(District district)
    {
        _context.Districts.Add(district);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var district = _context.Districts.Find(id);
        if (district != null)
        {
            _context.Districts.Remove(district);
            _context.SaveChanges();
        }
    }

    public List<District> GetAll()
    {
        return _context.Districts.ToList();
    }

    public District? GetById(int id)
    {
        return _context.Districts.Find(id);
    }

    public List<Ward> GetWardsByDistrictId(int districtId)
    {
        var ward = _context.Wards.Where(w => w.DistrictId == districtId).ToList();
        return ward;
    }

    public void Update(District district)
    {
        _context.Districts.Update(district);
        _context.SaveChanges();
    }
}
