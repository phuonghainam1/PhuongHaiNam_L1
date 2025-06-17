using System;
using PhuongHaiNam_L1.Models;

namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface IEthnicRepository
{
    List<Ethnic> GetAll();
    Ethnic? GetById(int id);
    void Add(Ethnic ethnic);
    void Update(Ethnic ethnic);
    void Delete(int id);
}
