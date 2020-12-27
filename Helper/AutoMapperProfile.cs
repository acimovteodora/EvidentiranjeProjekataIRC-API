using AutoMapper;
using DataTransferObjects;
using DataTransferObjects.ApplicationDTO;
using DataTransferObjects.CompanyDTO;
using DataTransferObjects.ProjectDTO;
using DataTransferObjects.ProjectPlanDTO;
using DataTransferObjects.ProjectProposalDTO;
using Model;
using System;

namespace Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Student, StudentsForList>();
            CreateMap<Company, CompanyNameDTO>();
            CreateMap<ProjectProposal, ProjectProposallForListDTO>()
                .ForMember(dest => dest.Company,
                opt => opt.MapFrom(p => p.Company))
                .ForMember(dest => dest.Name,
                opt => opt.MapFrom(p => p.Name));
            CreateMap<Project, ProjectForList>()
                .ForMember(dest => dest.ProjectProposal,
                opt => opt.MapFrom(p => p.ProjectProposal));
            CreateMap<Application, ApplicationForList>()
                .ForMember(dest => dest.Student,
                opt => opt.MapFrom(p => p.Student));
            CreateMap<ProjectPlanInsert, ProjectPlan>()
                .ForMember(dest => dest.ComposedBy,
                opt => opt.MapFrom(p => new Employee { EmployeeID = p.EmployeeId}));
            CreateMap<ProjectPlanForUpdate, ProjectPlan>()
                .ForMember(dest => dest.ComposedBy,
                opt => opt.MapFrom(p => new Employee { EmployeeID = p.EmployeeID }));
        }
    }
}
