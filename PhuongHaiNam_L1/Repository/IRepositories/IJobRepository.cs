using System;
using PhuongHaiNam_L1.Models;

namespace PhuongHaiNam_L1.Repository.IRepositories;

public interface IJobRepository
{
    List<Job> GetAll();
    Job? GetById(int id);
    void Add(Job job);
    void Update(Job job);
    void Delete(int id);
}
