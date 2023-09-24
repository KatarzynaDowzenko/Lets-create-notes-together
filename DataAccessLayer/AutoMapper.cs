using AutoMapper;
using DataAccessLayer.Models.BusinessModels;
using DataAccessLayer.Models.BusinessModels.Enums;
using DataAccessLayer.Models.EntityModel;
using DataAccessLayer.Models.EntityModel.Enums;

namespace DataAccessLayer;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Dashboard, DashboardEntity>()
            .ForMember(dest => dest.CheckLists, opt => opt.MapFrom(exp => exp.CheckLists))
            .ForMember(dest => dest.DayPlanners, opt => opt.MapFrom(exp => exp.DayPlanners))
            .ForMember(dest => dest.Notes, opt => opt.MapFrom(exp => exp.Notes))
            .ForMember(dest => dest.WeekPlanners, opt => opt.MapFrom(exp => exp.WeekPlanners));

        CreateMap<WeekPlanner, WeekPlannerEntity>()
            .ForMember(dest => dest.DayPlanners, opt => opt.MapFrom(exp => exp.DayPlanners));

        CreateMap<NoteType, NoteTypeEntity>();
    }
}