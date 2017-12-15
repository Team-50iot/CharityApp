using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharityApp.Models
{
    public class NewsViewModel
    {
        internal DateTime DataOfCreate;

        public string Header { get; set; }

        public string Description { get; set; }

        public string CategoryId { get; set; }

    }
}
