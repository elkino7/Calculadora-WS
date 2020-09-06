﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Calculadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SumaController : ControllerBase
    {
        //Controlador encargado de realizar la suma
        [HttpGet]
        public async Task<Int32> Operation(int Op1, int Op2) {
            var Resultado = Op1 + Op2;
            return Resultado;
        }
     }
}
