using AspDotNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCore.ViewModels
{
    public class HomeDetailsViewModel
    {
        public IEnumerable<Student> Student { get; set; }
        public string PageTitle { get; set; }
    }
}
