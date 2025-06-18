using System;
using PhuongHaiNam_L1.Models;

namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface ICityRepository
{
    List<City> GetAll();
    City? GetById(int id);
    void Add(City city);
    void Update(City city);
    void Delete(int id);
    List<District> GetDistrictsByCityId(int cityId);
}
