using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.EntityModel;

namespace TrendTestApp.BusinessServices.Interfaces
{
    public interface ICompanyBusinessService
    {

        Company SearchByCompanyId(int companyID);

        List<Company> GetAllCompanies();

    }
}
