using Microsoft.AspNetCore.Mvc;
using NEWAPP.Models;
using NEWAPP.Models.OpenWeatherMapModel;
using NEWAPP.Repositories;
using System.Diagnostics;

namespace NEWAPP.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger<HomeController> _logger;
		private readonly IWfForecastRepository _WforecastRepository;

		public HomeController(IWfForecastRepository wforecastRepository)
		{
			_WforecastRepository = wforecastRepository;
		}


		//public HomeController(ILogger<HomeController> logger)
  //      {
  //          _logger = logger;
  //      }

        public IActionResult Index()
        {
            return View();
        }

		[HttpGet]

		public IActionResult SearchByCity()
		{
			var viewModel = new SearchByCity();
			return View(viewModel);
		}

		[HttpPost]

		public IActionResult SearchByCity(SearchByCity Model)
		{
			if (ModelState.IsValid)
			{

				return RedirectToAction("city", "Home", new { city = Model.CityName });

			}
			return View(Model);
		}
		[HttpGet]

		// GET: WF/Create
		public IActionResult City(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.GetForecast(city);
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}

		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
		
		public IActionResult CityNY(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.InfoCityNY(city);
		
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}

		[HttpGet]
		public IActionResult CityMI(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.InfoCityMI(city);
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}

		[HttpGet]
		public IActionResult CityTO(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.InfoCityTO(city);
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}
		[HttpGet]
		public IActionResult CityPA(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.InfoCityPA(city);
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}
		[HttpGet]

		public IActionResult CityTEH(string city)
		{
			WeatherResponse weatherResponse = _WforecastRepository.InfoCityTEH(city);
			city viewmodel = new city();
			if (weatherResponse != null)
			{
				viewmodel.Name = weatherResponse.Name;
				viewmodel.Temperature = weatherResponse.Main.Temp;
				viewmodel.Humidity = weatherResponse.Main.Humidity;
				viewmodel.Pressure = weatherResponse.Main.Pressure;
				//viewmodel.Weather = weatherResponse.Weathers[0].Main;
				viewmodel.Wind = weatherResponse.Wind.speed;

			}
			return View(viewmodel);


		}
		





	}
}