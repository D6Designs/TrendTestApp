using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendTestApp.Models
{
    public class CompanyViewModel
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }

        public string VATNumber { get; set; }

    }
}
