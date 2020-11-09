using System;
using System.Threading.Tasks;

namespace BlazorTest.Data.Proposals
{
    /// <summary>
    /// Please check
    /// https://www.syncfusion.com/blogs/post/mvvm-pattern-in-blazor-for-state-management.aspx
    /// https://docs.microsoft.com/en-us/aspnet/core/blazor/state-management?view=aspnetcore-3.1&pivots=webassembly#in-memory-state-container-service
    /// for further information
    /// </summary>
    public class GetWeatherForecastQuery_Proposal1
    {
        private QueryResult<WeatherForecast[]?>? result;
        public QueryResult<WeatherForecast[]?>? Result
        {
            get => result;
            set
            {
                result = value; OnPropertyChanged();
            }
        }
            
        public event Action? PropertyChanged;
        
        
        private void OnPropertyChanged()
        {
            PropertyChanged?.Invoke();
        }

        public async Task GetWeatherForecastAsync(DateTime startDate)
        {
            Result = new QueryResult<WeatherForecast[]?> {IsLoading = true};
            var ret = await WeatherGenerator.GetWeather(startDate);
            Result = new QueryResult<WeatherForecast[]?> {IsLoading = false, Data = ret};
        }
    }
}