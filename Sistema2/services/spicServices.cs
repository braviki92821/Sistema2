using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Web;
using Newtonsoft.Json;
using Sistema2.modelos;
using s2_services.models;
using System.Windows.Forms;
using RestSharp.Serializers.Json;

namespace Sistema2.services
{
    public class spicServices
    {
        public string tokenAcceso { get; set; }//temporal xd
        public string refresh_token { get; set; }
        public string username { get; set; }
        public string[] scope { get; set; }

        public spicServices(){}

        public bool Login(string user, string pass) ///boleano o string o puedes poner algo que retorne los mensajes
        {
            bool acceso;
            try
            {
                string url = "https://localhost:7167/oauth/user/login";
                RestClient client = new RestClient(url);
                RestRequest restRequest = new RestRequest("", Method.Post);
                restRequest.AddBody(new { username = user, password = pass });
                var response = client.Execute(restRequest);
                ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                if (!json.IsSuccess)
                {
                    acceso = false;
                    throw new Exception("usuario o contraseña incorrectos");
                }
                else
                {
                    var token = JsonConvert.SerializeObject(json.Content);
                    tokenBody body = JsonConvert.DeserializeObject<tokenBody>(token);
                    tokenAcceso = "Bearer " + body.access_token;
                    refresh_token = body.refresh_token;
                    username = body.username;
                    var scopes = JsonConvert.SerializeObject(body.scope);
                    scope = JsonConvert.DeserializeObject<string[]>(scopes);
                    acceso = true;
                }
            }
            catch (Exception ex)
            {
                acceso = false;
                Console.WriteLine(ex.Message);
            }
            return acceso;
        }

        public string[] getScopes()
        {
            return scope;
        }

        public void GetAllSpic() //podriamos usar esto para retornarlo en una tabla
        {
            string url = "https://localhost:7167/api/spic";
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest("", Method.Get);
            restRequest.AddHeader("Authorization", this.tokenAcceso);
            var response = client.Execute(restRequest);
            ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
            if (!json.IsSuccess)
            {
                MessageBox.Show("alv no tenemos datos");
            }
            else
            {
                var content = JsonConvert.SerializeObject(json.Content);
                Console.WriteLine(content);
                List<Spic> spicResults = JsonConvert.DeserializeObject<List<Spic>>(content);
                Console.WriteLine(spicResults.Count);
                foreach (Spic spic in spicResults)
                {
                    Console.WriteLine(spic.nombres);
                }
            }
        }

        public void nuevoServidor(Spic spic)
        {
            string url = "https://localhost:7167/api/spic/nuevoServidor";
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest("", Method.Post);
            restRequest.AddHeader("Authorization", this.tokenAcceso);
            restRequest.AddBody(spic);
            var response = client.Execute(restRequest);
            ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
            if (!json.IsSuccess)
            {
                MessageBox.Show("error cuando se guardadon los datos");
            }
            else
            {
                MessageBox.Show("datos agregador correctamente");
            }
        }

    }
}
