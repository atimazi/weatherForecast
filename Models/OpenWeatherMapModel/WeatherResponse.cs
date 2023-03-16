namespace NEWAPP.Models.OpenWeatherMapModel
{
    public class WeatherResponse
    {
        public coord Coord { get; set; }
        public List<weather> Weathers { get; set; }
        public string Base { get; set; }
        public main Main { get; set; }
        public int Visibility { get; set; }
        public Wind Wind { get; set; }
        public clouds Clouds { get; set; }
        public int Dt { get; set; }
        public sys Sys { get; set; }
        public int TimeZone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }


    }

	public class Wind
	{
		internal float speed;
	}
}
