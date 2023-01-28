using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PopulationEnd
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Inhabitants { get; set;}
       

        [ValidateNever]
        public ICollection<City> Cities { get; set; }
    }
}