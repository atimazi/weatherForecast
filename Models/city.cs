using System.ComponentModel.DataAnnotations;

namespace NEWAPP.Models
{
    public class city


    {
        //city name
        [Display(Name = "city Name:")]
        public string Name { get; set; }
        // temprature

        [Display(Name = "Temp:")]
        public float Temperature { get; set; }
        //
        [Display(Name = "Humidity:")]
        public int Humidity { get; set; }
        //
        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }
        //
        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }
        //
        [Display(Name = "Weather Condition:")]
        public string Weather { get; set; }


    }
}
