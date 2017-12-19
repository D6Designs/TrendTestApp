using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.Models;

namespace TrendTestApp.ModelServices.Interfaces
{
    public interface ICompanyModelService
    {

        CompanyViewModel SearchByCompanyId(int companyID);

    }
}
