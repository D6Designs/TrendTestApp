using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrendTestApp.Models;
using TrendTestApp.ModelServices.Interfaces;

namespace TrendTestApp.WinApp
{
    public partial class Form1 : Form
    {
        protected List<CompanyViewModel> AllCompanies;

        protected CompanyViewModel FoundCompany;

        private readonly ICompanyModelService _companyModelService;


        public Form1(ICompanyModelService companyModelService)
        {
            this.FoundCompany = _companyModelService.SearchByCompanyId(27);

            InitializeComponent();

            _companyModelService = companyModelService;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCompanies();

        }

        private void LoadCompanies()
        {

            label1.Text = FoundCompany.CompanyName;
        }
    }
}
