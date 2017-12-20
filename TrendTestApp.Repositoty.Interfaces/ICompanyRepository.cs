using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.EntityModel;
using TrendTestApp.Repository.Interfaces;

namespace TrendTestApp.Repository.Interfaces
{
    public interface ICompanyRepository : IGenericRepository<Company>
    {
        Company SearchByCompanyId(int CompanyID);

        List<Company> GetAllCompanies();
    }
}
