﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TattoStudioModerna.Models
{
    public class TattoVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Image { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
  
        public List<SelectListItem> Categories { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата на вписване:")]
        public DateTime Date { get; set; }
    
    }
}
