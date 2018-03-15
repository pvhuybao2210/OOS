﻿using OOS.Presentation.ApplicationLogic.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OOS.Presentation.ApplicationLogic.Categories.Messages
{
    public class EditCategoryRequest : RequestBase
    {           
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
