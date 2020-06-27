using AutoMapper;
using Lambda.BLL.ViewModels;
using Lambda.DAL.Entities;
using Lambda.DAL.Interfaces;

namespace Lambda.BLL.Services
{
	public class ReportService : BaseService<Report, ReportViewModel>
	{
		public ReportService(IReportRepository reportRepository, IMapper mapper)
			: base(reportRepository, mapper)
		{
		}
	}
}
