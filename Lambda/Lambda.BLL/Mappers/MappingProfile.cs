using AutoMapper;
using Lambda.BLL.ViewModels;
using Lambda.DAL.Entities;

namespace Lambda.BLL.Mappers
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Report, ReportViewModel>();
			CreateMap<ReportViewModel, Report>();
		}
	}
}
