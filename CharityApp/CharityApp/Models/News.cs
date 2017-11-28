﻿using System;
using System.Collections.Generic;

namespace CharityApp.Models
{
    public class News
    {
        public int Id { get; set; }

        public DateTime DataOfCreate { get; set; }

        public string Header { get; set; }

        public string Description { get; set; }

        public Category Category { get; set; }
    }
}