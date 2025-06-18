using System;
using PhuongHaiNam_L1.Models;

namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface IWardRepository
{
    List<Ward> GetAll();
    Ward? GetById(int id);
    void Add(Ward ward);
    void Update(Ward ward);
    void Delete(int id);
}
