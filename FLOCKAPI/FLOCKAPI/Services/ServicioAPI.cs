using FLOCKAPI.Classes;
using FLOCKAPI.Interfaces;
using Newtonsoft.Json;
using System.Net;

namespace FLOCKAPI.Services
{
    public class ServicioAPI : IServicioAPI
    {
        Task<string> respuesta = GetHttp("https://apis.datos.gob.ar/georef/api/provincias");
        public static async Task<string> GetHttp(string url)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        public RootObject GetProvincias()
        {
            RootObject provincias = JsonConvert.DeserializeObject<RootObject>(respuesta.Result);
            return provincias;
        }
    }
}
