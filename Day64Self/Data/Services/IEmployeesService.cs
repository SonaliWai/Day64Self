using Day63Demo.Data.ViewModels;
using Day64Self.Data.ViewModels;

namespace Day64Self.Data.Services
{
    public interface IEmployeesService
    {
        Task<List<EmployeeViewModel>> GetAllAsync();
        Task<EmployeeViewModel?> GetByIdAsync(int id);
        Task CreateAsync(EmployeeViewModel employee);

        Task<List<DropDownViewModel>> GetDepartmentForDropDownAsync();

        Task<List<DropDownViewModel>> GetNationalityForDropDownAsync();
    }
}
