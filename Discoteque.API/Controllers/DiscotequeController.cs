using Microsoft.AspNetCore.Mvc;
using Discoteque.Data;
using Discoteque.Business.IServices;

namespace Discoteque.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistsService _artistsService;
        public ArtistsController(IArtistsService artistsService)
        {
            _artistsService = artistsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            var artists = await _artistsService.GetArtistsAsync();
            return Ok(artists);
        }
            
    }
}