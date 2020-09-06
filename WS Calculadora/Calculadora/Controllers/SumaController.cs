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
        [HttpPost]
        public async Task<Int32> Post(int OperandoUno, int OperandoDos) {
            var Resultado = OperandoUno + OperandoDos;
            return Resultado;
        }
    }
}
