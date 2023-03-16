using Microsoft.AspNetCore.Mvc.Diagnostics;
using NEWAPP.Models;
using NEWAPP.Models.OpenWeatherMapModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Data;

namespace NEWAPP.Repositories
{
    public class WForecastRepository : IWfForecastRepository
    {
        public WeatherResponse GetForecast(string city)
        {
            string App_Id = Configuration.values.Open_Weather_App_Id;

            var client = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}");
            var request = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}", Method.Get);
            
			RestResponse response =client.Execute(request);
			

			if (response.IsSuccessful)
            {
                var content = JsonConvert.DeserializeObject<JToken>(response.Content);
                return content.ToObject<WeatherResponse>();
            }
            else
                return null;

		}
		
		
		
		//request.AddHeader("accept", "application/json");
  //      request.AddHeader("Authorization", "hello");
  //          IRestResponse response = client.Execute(request);
		public WeatherResponse InfoCityNY(string city)

		{
			city = "new york";
			//DataTable InfoCitiesTB = new DataTable();
			//DataRow dr = InfoCitiesTB.NewRow();

			string App_Id = Configuration.values.Open_Weather_App_Id;
			var clientNewYork = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}");
			var requestNewYork = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}", Method.Get);

			RestResponse responseNY = clientNewYork.Execute(requestNewYork);
			if (responseNY.IsSuccessful)
			{
				var content = JsonConvert.DeserializeObject<JToken>(responseNY.Content);
				return content.ToObject<WeatherResponse>();
			}
			else
				return null;
		}


		public WeatherResponse InfoCityMI(string city)

		{
			city = "milan";
			string App_Id = Configuration.values.Open_Weather_App_Id;
			var clientMilan = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}");
			var requestMilan = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={App_Id}", Method.Get);
			RestResponse responseMI = clientMilan.Execute(requestMilan);
			if (responseMI.IsSuccessful)
			{
				var content = JsonConvert.DeserializeObject<JToken>(responseMI.Content);
				return content.ToObject<WeatherResponse>();

			}
			else
				return null;
		}
			public WeatherResponse InfoCityPA(string city)

			{
				city = "paris";
				string App_Id = Configuration.values.Open_Weather_App_Id;
				var clientParis = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q=paris&appid={App_Id}");
				var requestParis = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q=paris&appid={App_Id}", Method.Get);
				RestResponse responseP = clientParis.Execute(requestParis);
				if (responseP.IsSuccessful)
				{
					var content = JsonConvert.DeserializeObject<JToken>(responseP.Content);
					return content.ToObject<WeatherResponse>();
				}
				else
					return null;
			}


		public WeatherResponse InfoCityTO(string city)

		{
			city = "turin";
			string App_Id = Configuration.values.Open_Weather_App_Id;
			var clientTurin = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q=turin&appid={App_Id}");
			var requestTurin = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q=turin&appid={App_Id}", Method.Get);
			RestResponse responseTO = clientTurin.Execute(requestTurin);
			if (responseTO.IsSuccessful)
			{
				var content = JsonConvert.DeserializeObject<JToken>(responseTO.Content);
				return content.ToObject<WeatherResponse>();
			}
			else
				return null;
		}
		public WeatherResponse InfoCityTEH(string city)

		{
			city = "tehran";
			string App_Id = Configuration.values.Open_Weather_App_Id;
			var clientTehran = new RestClient($"https://api.openweathermap.org/data/2.5/weather?q=tehran&appid={App_Id}");
			var requestTehran = new RestRequest($"https://api.openweathermap.org/data/2.5/weather?q=tehran&appid={App_Id}", Method.Get);
			RestResponse responseTEH = clientTehran.Execute(requestTehran);
			if (responseTEH.IsSuccessful)
			{
				var content = JsonConvert.DeserializeObject<JToken>(responseTEH.Content);
				return content.ToObject<WeatherResponse>();
			}
			else
				return null;
		}
		
		

	}

}

