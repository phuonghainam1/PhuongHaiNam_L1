using System;
using PhuongHaiNam_L1.Models;
using PhuongHaiNam_L1.Repository.IRepositories;

namespace PhuongHaiNam_L1.Repository.Repositories;

public class JobRepository : IJobRepository
{
    EmployeeManagementContext _context;
    public JobRepository()
    {
        _context = new EmployeeManagementContext();
    }

    public void Add(Job job)
    {
        _context.Jobs.Add(job);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var job = _context.Jobs.FirstOrDefault(j => j.JobId == id);
        if (job != null)
        {
            _context.Jobs.Remove(job);
            _context.SaveChanges();
        }

    }

    public List<Job> GetAll()
    {
        return _context.Jobs.ToList();
    }

    public Job? GetById(int id)
    {
        return _context.Jobs.FirstOrDefault(j => j.JobId == id);

    }

    public void Update(Job job)
    {
        _context.Jobs.Update(job);
        _context.SaveChanges();
    }
}
