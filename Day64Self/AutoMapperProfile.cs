using AutoMapper;
using Day64Self.Data.Models;
using Day64Self.Data.ViewModels;

namespace Day64Self
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Department, DepartmentViewModel>().ReverseMap();

            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(evw => evw.DepartmentName, opt => opt.MapFrom(em => em.DepartmentRef.Name))
                .ForMember(evw => evw.NationalityText, opt => opt.MapFrom(em => em.NationalityRef.Text))
                .ReverseMap()
                .ForPath(em => em.DepartmentRef.Name, opt => opt.Ignore())
                .ForPath(em => em.NationalityRef.Text, opt => opt.Ignore());
        }
    }
}
