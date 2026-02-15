using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace H.DataAccess.Extension
{
    public class ErrorResult : ActionResult
    {
        private Exception _exepcion;
        private string _mensaje;
        private const string urlBase = "https://localhost:7191/";
        private HttpStatusCode? _statusCode;

        public ClaimsPrincipal _user { get; }

        public ErrorResult(Exception exepcion, ClaimsPrincipal user)
        {
            _exepcion = exepcion;
            _user = user;
        }
        public ErrorResult(Exception exepcion, ClaimsPrincipal user, HttpStatusCode statusCode)
        {
            _exepcion = exepcion;
            _user = user;
            _statusCode = statusCode;
        }

        public ErrorResult(string mensaje, ClaimsPrincipal user)
        {
            _mensaje = mensaje;
            _user = user;
        }
        public ErrorResult(string mensaje, ClaimsPrincipal user, HttpStatusCode statusCode)
        {
            _mensaje = mensaje;
            _user = user;
            _statusCode = statusCode;
        }

        public override async Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = _statusCode != null ? (int)_statusCode : (int)HttpStatusCode.BadRequest;
            context.HttpContext.Response.ContentType = "application/json";

            if (_exepcion != null)
            {
                string usuario = _user.FindFirstValue("usuario");
                RegistrarLog(_exepcion, context, usuario);

                string contenido = "";
                using (StreamReader reader = new StreamReader(context.HttpContext.Request.Body, Encoding.UTF8))
                {
                    contenido = await reader.ReadToEndAsync();
                }

                //var a = await context.HttpContext.Request.Body.ReadToEndAsync();
                //var b = context.HttpContext.Request.Form.ToArray();
                //var b1 = context.HttpContext.Request.Form.ToJson();
                //var c = context.HttpContext.Request.QueryString.Value;

                //var json = JsonSerializer.Serialize(new { mensaje = _exepcion.Message, interno = _exepcion.InnerException != null ? _exepcion.InnerException.Message : "" });
                var json = System.Text.Json.JsonSerializer.Serialize(_exepcion.Message + (_exepcion.InnerException != null ? $" - {_exepcion.InnerException.Message}" : ""));

                var respuestaBytes = Encoding.UTF8.GetBytes(json);
                await context.HttpContext.Response.Body.WriteAsync(respuestaBytes, 0, respuestaBytes.Length);
                await context.HttpContext.Response.Body.FlushAsync();
            }
            else
            {
                if (!string.IsNullOrEmpty(_mensaje))
                {
                    var json = System.Text.Json.JsonSerializer.Serialize(_mensaje);

                    var respuestaBytes = Encoding.UTF8.GetBytes(json);
                    await context.HttpContext.Response.Body.WriteAsync(respuestaBytes, 0, respuestaBytes.Length);
                    await context.HttpContext.Response.Body.FlushAsync();
                }
            }

            await base.ExecuteResultAsync(context);
        }

        private void RegistrarLog(Exception excepcion, ActionContext context, string usuario)
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => { return true; };

                using (WebClient _webclient = new WebClient())
                {
                    _webclient.Headers.Add("Content-Type", "application/json");
                    string url = urlBase + "api/Logger/RegistroLogInternoControlado";
                    //JsonSerializerSettings settings = new JsonSerializerSettings
                    //{
                    //    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    //};;
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error en logger cliente - " + ex.Message + " - {log}", new object[1] { log });
            }
        }
    }
}
