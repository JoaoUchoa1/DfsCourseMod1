﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Resource
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public String Name { get; set; }
    }
}
