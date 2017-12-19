using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendTestApp.Repository.Interfaces;
using TrendTestApp.EntityModel;

namespace TrendTestApp.Repository
{
    public class DataContext: IDataContext
    {

        public TrendTestAppContext _dataContext { get; set; }

        public DataContext()
        {
            _dataContext = new TrendTestAppContext();
        }

    }
}
