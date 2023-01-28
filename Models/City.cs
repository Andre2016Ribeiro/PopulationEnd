using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PopulationEnd
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Inhabitants { get; set; }
        
        public int CountryId { get; set; }

        [ValidateNever]
        public Country Country { get; set; }
    }
}
