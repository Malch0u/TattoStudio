﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TattoStudioModerna.Data
{
    public class Tatto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Discription { get; set; }

        [Column(TypeName = "decimal(10,2")]
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
      
       
       public ICollection<Order> Orders { get; set; }
        public ICollection<TattoImage> TattoImages { get; set; }
       
    }
}
