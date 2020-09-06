using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisionController : ControllerBase
    {
        [HttpGet]
        public async Task<Int32> Operation(int Op1, int Op2)
        {
            var Resultado =0;
            if (Op2 !=0) {
                Resultado = Op1 / Op2;
            }
              return Resultado;
        }
    }
}
