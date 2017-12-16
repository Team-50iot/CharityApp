using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityApp.Models
{
    public class NewsViewModel
    {

        public DateTime DataOfCreate { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }

    }
}
