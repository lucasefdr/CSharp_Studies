using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;

var httpClient = new HttpClient();
var cep = "13590000";
var response = await httpClient.GetFromJsonAsync<Address>($"https://viacep.com.br/ws/{cep}/json/");

Console.WriteLine(response.Localidade);


