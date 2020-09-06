using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic.CompilerServices;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        //Controlador encargado de realizar la suma
        [HttpGet]
        public async Task<Int32> Get(int Op1, int Op2) {
            var Resultado = Op1 + Op2;
            return Resultado;
        }
        //[HttpGet]
        //public async Task<Int32> Get()
        //{
        //    var Resultado = 239 + 234;
        //    return Resultado;
        //}
    }
}
