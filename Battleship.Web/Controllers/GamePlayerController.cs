using Battleship.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Battleship.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamePlayerController : ControllerBase
    {
        private readonly IGamePlayService _gamePlayService;

        public GamePlayerController(IGamePlayService gamePlayService)
        {
            _gamePlayService = gamePlayService;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync()
        {
            await _gamePlayService.GameSetup();
        }
    }
}
