using Day64Self.Data.ViewModels;

namespace Day64Self.Data.Services
{
    public interface IDepartmentsService
    {
        Task<List<DepartmentViewModel>> GetAllAsync();
        Task<DepartmentViewModel?> GetByIdAsync(int id);
        Task CreateAsync(DepartmentViewModel department);
    }
}

