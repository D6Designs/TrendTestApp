using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.BusinessServices.Interfaces;
using TrendTestApp.EntityModel;
using TrendTestApp.Repository.Interfaces;

namespace TrendTestApp.BusinessServices
{
    public class CompanyBusinessService : ICompanyBusinessService
    {


        private readonly ICompanyRepository _companyRepository;

        public CompanyBusinessService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }


        public Company SearchByCompanyId(int companyID)
        {
            return _companyRepository.SearchByCompanyId(companyID);
        }
        public List<Company> GetAllCompanies()
        {
            return _companyRepository.GetAllCompanies();
        }

    }
}
