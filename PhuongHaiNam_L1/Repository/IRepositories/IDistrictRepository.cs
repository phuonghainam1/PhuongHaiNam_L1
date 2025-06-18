using System;
using PhuongHaiNam_L1.Models;
namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface IDistrictRepository
{
    List<District> GetAll();
    District? GetById(int id);
    void Add(District district);
    void Update(District district);
    void Delete(int id);
    List<Ward> GetWardsByDistrictId(int districtId);
}
