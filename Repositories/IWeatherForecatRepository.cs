using NEWAPP.Models.OpenWeatherMapModel;

namespace NEWAPP.Repositories
{
    public interface IWfForecastRepository
    {
        WeatherResponse GetForecast(string city);
        WeatherResponse InfoCityNY(string city);
		WeatherResponse InfoCityMI(string city);
		WeatherResponse InfoCityTO(string city);
		WeatherResponse InfoCityPA(string city);
		WeatherResponse InfoCityTEH(string city);


	}
}
