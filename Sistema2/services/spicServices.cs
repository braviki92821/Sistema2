using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Security;
using Newtonsoft.Json;
using Sistema2.modelos;
using s2_services.models;
using System.Windows.Forms;
using RestSharp.Serializers.Json;
using System.Web.Security;
using Sistema2.modelos.bodyClass;

namespace Sistema2.services
{
    public class spicServices
    {
        public static string tokenAcceso { get; set; }//temporal xd
        public static string refresh_tokenAcceso { get; set; }
        public static string userN { get; set; }
        public static string[] scopes { get; set; }

        public spicServices() { }

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
                    refresh_tokenAcceso = body.refresh_token;
                    userN = body.username;
                    var scope = JsonConvert.SerializeObject(body.scope);
                    scopes = JsonConvert.DeserializeObject<string[]>(scope);
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

        public void nuevoUsuario(newUser newUser)
        {
            try
            {
                string url = "https://localhost:7167/oauth/user/registrar";
                RestClient rest = new RestClient(url);
                RestRequest restRequest = new RestRequest("", Method.Post);
                restRequest.AddHeader("Authorization", tokenAcceso);
                restRequest.AddBody(newUser);
                var response = rest.Execute(restRequest);
                ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                Console.WriteLine(json);
                if (!json.IsSuccess)
                {
                    MessageBox.Show("Error al registar usuario");
                }
                else
                {
                    MessageBox.Show("Usuario registrado correctamente");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string GetUsername()
        {
            return userN;
        }

        public string[] getScopes()
        {
            return scopes;
        }

        public string getToken()
        {
            return tokenAcceso;
        }

        public string GetRefreshToken()
        {
            return refresh_tokenAcceso;
        }

        public List<Spic> GetAllSpic(searchSP query) //podriamos usar esto para retornarlo en una tabla
        {
            string url = "https://localhost:7167/api/spic/ObtenerServidor";
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest("", Method.Post);
            restRequest.AddHeader("Authorization", tokenAcceso);
            //restRequest.AddParameter("application/json",query,ParameterType.RequestBody);
            restRequest.AddBody(query);
            var response = client.Execute(restRequest);

            ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
            if (!json.IsSuccess)
            {
                MessageBox.Show("alv no tenemos datos");
                return null;
            }
            var content = JsonConvert.SerializeObject(json.Content);
            Console.WriteLine(content);
            List<Spic> spicResult = JsonConvert.DeserializeObject<List<Spic>>(content);

            return spicResult;
        }

        public void nuevoServidor(Spic spic)
        {
            string url = "https://localhost:7167/api/spic/nuevoServidor";
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest("", Method.Post);
            restRequest.AddHeader("Authorization", tokenAcceso);
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

        public string ramdonPassword()
        {
            string newPass = Membership.GeneratePassword(8, 2);
            return newPass;
        }

        public void actualizarSesion()
        {
            try
            {
                string url = "https://localhost:7167/oauth/user/refreshToken";
                RestClient client = new RestClient(url);
                RestRequest restRequest = new RestRequest("", Method.Post);
                restRequest.AddBody(new { token = tokenAcceso, refresh_token = refresh_tokenAcceso, username = userN, scope = scopes });
                var response = client.Execute(restRequest);
                ApiResponse json = JsonConvert.DeserializeObject<ApiResponse>(response.Content);
                Console.WriteLine(json.IsSuccess);
                Console.WriteLine(response.Content);
                if (!json.IsSuccess)
                {
                    Console.WriteLine("token activo");
                }
                else
                {
                    Console.WriteLine("Sesion Actualizada");
                    var token = JsonConvert.SerializeObject(json.Content);
                    tokenBody body = JsonConvert.DeserializeObject<tokenBody>(token);
                    tokenAcceso = "Bearer " + body.access_token;
                    refresh_tokenAcceso = body.refresh_token;
                    userN = body.username;
                    var scope = JsonConvert.SerializeObject(body.scope);
                    scopes = JsonConvert.DeserializeObject<string[]>(scope);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
