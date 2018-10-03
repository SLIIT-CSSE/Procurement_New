﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Procurment.Models;

namespace Procurment.ViewModels
{
    public class NewItemViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        public ConstructionItem ConstructionItem { get; set; }
    }
}