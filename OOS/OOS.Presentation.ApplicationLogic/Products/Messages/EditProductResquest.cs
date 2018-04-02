﻿using OOS.Domain.Products.Models;
using OOS.Presentation.ApplicationLogic.Common;
using OOS.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Products.Messages
{
   public class EditProductResquest : RequestBase
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string IdCategory { get; set; }

        public ProductStatus? Status { get; set; }

        public string Description { get; set; }

        public string Details { get; set; }

        public int Discount { get; set; }
        [Required]
        public List<ProductTail> ProductTails { get; set; }
    }
}
