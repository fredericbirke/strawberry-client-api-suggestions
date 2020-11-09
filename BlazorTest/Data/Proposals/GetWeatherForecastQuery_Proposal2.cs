using System;
using System.Collections.Generic;

namespace BlazorTest.Data.Proposals
{
    public class GetWeatherForecastQuery_Proposal2
    {
        public async IAsyncEnumerable<QueryResult<WeatherForecast[]?>?> GetWeatherForecastAsync(
            DateTime startDate)
        {
            yield return new QueryResult<WeatherForecast[]?>()
            {
                IsLoading = true
            };
            var ret = await WeatherGenerator.GetWeather(startDate);
            yield return new QueryResult<WeatherForecast[]?>()
            {
                Data = ret,
                IsLoading = false
            };
        }
    }
}