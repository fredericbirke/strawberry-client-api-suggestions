using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorTest.Data
{
    public static class WeatherGenerator
    {
        public static Task<WeatherForecast[]> GetWeather(DateTime startDate)
        {
            Thread.Sleep(5000);
            var rng = new Random();
            return Task.FromResult(
                Enumerable.Range(
                    1,
                    5
                ).Select(
                    index => new WeatherForecast
                    {
                        Date = startDate.AddDays(index),
                        TemperatureC = rng.Next(
                            -20,
                            55
                        ),
                        Summary = Summaries[rng.Next(Summaries.Length)]
                    }
                ).ToArray()
            );
        }
        
        
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering",
            "Scorching"
        };
    }
}