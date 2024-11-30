using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.WebApp.Client.Pages;
using System.Diagnostics.Metrics;

namespace Niu.Nutri.WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SelectInputController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult Get(string? query)
        {
            var search = Enumerable.Range(1, 12).Select(m => DateTime.Now.AddMonths(m + 3).ToString("MMMM"));

            var listMonths = new List<string>();

            foreach (var mes in search)
            {
                listMonths.Add(mes);
            }

            if (!string.IsNullOrEmpty(query))
            {
                search = search.Where(x => x?.Contains(query, StringComparison.InvariantCultureIgnoreCase) == true).ToList();
            }


            return Ok(search);
        }

        List<string?> Options => new List<string?>()
        {

        };

        [HttpGet("/months")]
        public IActionResult Months()
        {
            var meses = Enumerable.Range(1, 12).Select(m => DateTime.Now.AddMonths(m - 1).ToString("MMMM"));

            var listMonths = new List<string>();

            foreach (var mes in meses)
            {
                listMonths.Add(mes);
            }

            return Ok(listMonths);
        }
    }
}
