using System;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class CityRepository : ICityRepository
{
    EmployeeManagementContext _context;
    public CityRepository()
    {   
        _context = new EmployeeManagementContext();
    }

    public void Add(City city)
    {
        _context.Cities.Add(city);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var city = _context.Cities.Find(id);
        if (city != null)
        {
            _context.Cities.Remove(city);
            _context.SaveChanges();
        }
    }

    public List<City> GetAll()
    {
        return _context.Cities.ToList();
    }

    public City? GetById(int id)
    {
        return _context.Cities.Find(id);
    }

    public List<District> GetDistrictsByCityId(int cityId)
    {
        return _context.Districts.Where(d => d.CityId == cityId).ToList();
    }

    public void Update(City city)
    {
        _context.Cities.Update(city);
        _context.SaveChanges();
    }
}
