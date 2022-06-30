using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RpgMvc.Models;

namespace RpgMvc.Controllers
{
    public class UsuariosController : Controller
    {
        public string uriBase = "http://lzsouza.somee.com/RpgApi/Usuarios/";
        //xyz tem que ser substituído pelo nome do seu site na API.

        [HttpGet]
        public ActionResult Index()
        {
            return View("CadastrarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> RegistrarAsync(UsuarioViewModel u)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Registrar";

                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    TempData["Mensagem"] =
                        string.Format("Usuário {0} Registrado com sucesso! Faça o login para acessar.", u.Username);
                    return View("AutenticarUsuario");
                }
                else
                {
                    throw new System.Exception(serialized);
                }
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult IndexLogin()
        {
            return View("AutenticarUsuario");
        }

        [HttpPost]
        public async Task<ActionResult> AutenticarAsync(UsuarioViewModel u)
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                string uriComplementar = "Autenticar";

                var content = new StringContent(JsonConvert.SerializeObject(u));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                HttpResponseMessage response = await httpClient.PostAsync(uriBase + uriComplementar, content);

                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    string token = serialized;
                    HttpContext.Session.SetString("SessionTokenUsuario", serialized);
                    TempData["Mensagem"] = string.Format("Bem-vindo {0}!!!", u.Username);

                    uriComplementar = "GetAll";
                    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    response = await httpClient.GetAsync(uriBase + uriComplementar);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        serialized = await response.Content.ReadAsStringAsync();

                        List<UsuarioViewModel> listaPersonagens = await Task.Run(() =>
                            JsonConvert.DeserializeObject<List<UsuarioViewModel>>(serialized));
                        
                        UsuarioViewModel userLogado = listaPersonagens.Find(x => x.Username.ToLower() == u.Username.ToLower());
                        HttpContext.Session.SetString("SessionPerfilUsuario", userLogado.Perfil);
                    }

                    return RedirectToAction("Index", "Personagens");
                }
                else
                {
                    throw new System.Exception(serialized);
                }
            }
            catch (System.Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return IndexLogin();
            }
        }





    }
}