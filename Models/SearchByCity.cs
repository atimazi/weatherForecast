using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NEWAPP.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "City name is empty!")]
        [Display(Name = "City Name")]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "Invalid Input!")]
        public string? CityName { get; set; }
    }
}
