using consultaCitas.Models;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http;


namespace consultaCitas.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Mvc.Route("cliente")]
    public class FulfillmentController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("listar")]
        public dynamic listarCliente()
        {
            //https://www.youtube.com/watch?v=uVe9AX7I-sU&ab_channel=SoftwareLion



            //return Ok(new string[] { "Holaaaa"});
            Clases.CConnection objetoConexion = new Clases.CConnection();
            //objetoConexion.conex();
            objetoConexion.GetDatata("Select tercero,fecha_hora from agenda where fecha_hora >= '2023/03/13';");


            //string speech = $"respuesta desde API Saludtic";
            string speech = objetoConexion.GetDatata("Select tercero,fecha_hora from agenda where fecha_hora >= '2023/03/13';");
            ApiAiResponse response = new ApiAiResponse
            {
                //speech = speech,
                fulfillmentText = speech
            };
            return Ok(response);

        }
    }
}
