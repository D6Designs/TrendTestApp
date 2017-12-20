using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.EntityModel;

namespace TrendTestApp.Repository.Interfaces
{
    public interface IDataContext
    {
        TrendEntities _dataContext { get; set; }
    }
}
