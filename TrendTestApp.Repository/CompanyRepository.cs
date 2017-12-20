using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.EntityModel;
using TrendTestApp.Repository.Interfaces;

namespace TrendTestApp.Repository
{
    public class CompanyRepository : GenericRepository<Company>, ICompanyRepository
    {

        public CompanyRepository(IDataContext context) : base(context)
        {
        }
        public Company SearchByCompanyId(int CompanyID)
        {
            return SelectBy(x => x.CompanyId == CompanyID).FirstOrDefault();
        }
        public List<Company> GetAllCompanies()
        {
            return SelectAll.ToList();
        }


    }
}
