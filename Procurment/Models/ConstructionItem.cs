﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Procurment.Models
{
    public class ConstructionItem
    {
        [Key]
        public string ItemId { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public float Price { get; set; }
        public bool IsRestricted { get; set; }
    }
}