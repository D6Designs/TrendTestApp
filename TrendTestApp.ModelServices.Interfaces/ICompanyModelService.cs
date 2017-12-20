using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.Models;
using TrendTestApp.EntityModel;

namespace TrendTestApp.ModelServices.Interfaces
{
    public interface ICompanyModelService
    {

        CompanyViewModel SearchByCompanyId(int companyID);


       List<CompanyViewModel> GetAllCompanies();

    }
}
