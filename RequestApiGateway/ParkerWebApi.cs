using Domain.Entities;
using Domain.Interfaces.RequestApiGateway;
using System.Text.Json;

namespace RequestApiGateway
{
    public class ParkerWebApi : IParkerWebApi
    {
        private readonly HttpClient _httpClient;

        public ParkerWebApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Tariff> GetTariff(string typeBay, string token)
        {
            _httpClient.DefaultRequestHeaders.Add("Authorization", token);

            // HTTP GET
            try
            {
                var users = await JsonSerializer.DeserializeAsync<List<User>>(
                  await _httpClient.GetStreamAsync("api/user"),
                  new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
            }
            catch (Exception e)
            {
                throw;
            }


            return new Tariff() { CostHour = 2000, IdTariff = 1 };
        }

        public Task<double> OccupyBay(int tariffId, string token)
        {
            throw new NotImplementedException();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? SecondName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
    }
}
