using Microsoft.AspNetCore.Mvc;
using Niu.Nutri.Addresses.Application.DTO.Aggregates.AddressesAgg.Requests;
using Niu.Nutri.Core.Application.DTO.Http.Models.CommonAgg.Commands.Responses;

namespace Niu.Nutri.Addresses.Controllers
{
    public partial class AddressController
    {
        [HttpGet]
        [Route("search/neighbours")]
        public async Task<GetHttpResponseDTO<List<string>>> GetNeighbours(
            [FromQuery] string city,
            [FromQuery] string? neighbour = null,
            int? page = null, int? size = null)
        {
            return await base.SearchAsync<AddressDTO, string>(uri: "search/neighbours", new { city, neighbour }, page, size);
        }

        [HttpGet]
        [Route("search/cities")]
        public async Task<GetHttpResponseDTO<List<string>>> GetCities([FromQuery] string? city = null)
        {
            return await base.SearchAsync<AddressDTO, string>(uri: "search/cities", new { city });
        }
    }
}
