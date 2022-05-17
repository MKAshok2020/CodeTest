using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Plano.Models;
using PlanoTestAPI.Exception;
using PlanoTestAPI.Queries.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
   // [ApiController]
    [Route("api/CurrencyConverter")]
    [Produces("application/json")]
    public class CurrencyConverterController : Microsoft.AspNetCore.Mvc.Controller 
    {
        readonly PlanoDbContext planoDBContext;
        readonly string pattern = @"[\r|\n|\t]";
        public CurrencyConverterController(PlanoDbContext dbContext)        
        {
            planoDBContext = dbContext;
        }

        //private readonly ILogger<CurrencyConverter> _logger;

         

        [HttpGet("convert")]
        public  string  Convert([FromBody] InputModel input )
        {
            if (!ModelState.IsValid) throw new InvalidModelException(ModelState);

            CurrencyProp p = planoDBContext.CurrencyProps.Where(c => c.CurrencyCode==input.TargetCode).FirstOrDefault();
            ExchangeRate r = planoDBContext.ExchangeRates.Where(c => c.CurrencyCode==input.TargetCode).FirstOrDefault();
             
            return $"{Regex.Replace(p.Symbol, pattern, "")} {decimal.Round(((r.ExchangeRates ?? 1) * input.Amount), p.DecimalPlace ?? 0, MidpointRounding.AwayFromZero)}";
        }
    }
}
