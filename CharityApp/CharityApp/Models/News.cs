using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CharityApp.Models
{
    public class News
    {
        public int Id { get; set; }

        public DateTime DataOfCreate { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public virtual Category Category { get; set; }

        ///[ForeignKey("Category")]

       /// public int CategoryId { get; set; }
    }
}