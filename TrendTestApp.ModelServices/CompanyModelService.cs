using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.BusinessServices.Interfaces;
using TrendTestApp.EntityModel;
using TrendTestApp.Models;
using TrendTestApp.ModelServices.Interfaces;

namespace TrendTestApp.ModelServices
{
    public class CompanyModelService : ICompanyModelService
    {

        private readonly ICompanyBusinessService _companyBusinessService;
        private IMapper _mapper;

        public CompanyModelService(ICompanyBusinessService companyBusinessService)
        {

            _companyBusinessService = companyBusinessService;
            CreateMappings();

        }

        private void CreateMappings()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Company, CompanyViewModel>();
            });
            _mapper = config.CreateMapper();
        }

        public CompanyViewModel SearchByCompanyId(int companyID)
        {
            var result = _companyBusinessService.SearchByCompanyId(companyID);

            CompanyViewModel model;

            if (result == null || result.CompanyId == 0)
            {
                model = new CompanyViewModel();
            }
            else
            {
                model = _mapper.Map<Company, CompanyViewModel>(result);
            }

            return model;
        }
    }
}
