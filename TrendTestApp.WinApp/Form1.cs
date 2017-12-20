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

        protected BindingSource bsCompanies = new BindingSource();

        public Form1(ICompanyModelService companyModelService)
        {
        

            InitializeComponent();

            _companyModelService = companyModelService;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadCompanies();

        }

        private void LoadCompanies()
        {
            this.FoundCompany = _companyModelService.SearchByCompanyId(27);
            

           this.AllCompanies = _companyModelService.GetAllCompanies();

            bsCompanies.DataSource = AllCompanies;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bsCompanies;
            dataGridView1.ClearSelection();


        }
    }
}
