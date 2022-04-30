using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimeAPI.Model;
using AnimeAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimeAPI.Controllers
{
    [Route("api/[controller]")]
    public class AnimeController : Controller
    {
        private readonly IAnimeService _animeService;
        private readonly ILogger _logger;

        public AnimeController(IAnimeService animeService, ILogger logger)
        {
            _animeService = animeService;
            _logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<AnimeModel> Get()
        {
            try
            {
                IEnumerable<AnimeModel> animes = _animeService.GetAnimes();

                if (animes == null)
                {
                    return Enumerable.Empty<AnimeModel>();
                }

                return animes;
            } catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Enumerable.Empty<AnimeModel>();
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public AnimeModel Get(int id)
        {
            try {
                if (id == 0)
                {
                    return null;
                }

                return _animeService.GetAnimeById(id);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] AnimeModel value)
        {
            try
            {
                if (value is null)
                {
                    throw new Exception("Se envio incorrectamente la informacion, por favor verificar");
                }

                _animeService.SaveAnime(value);
            } catch (Exception e)
            {
                _logger.LogError(e.Message);
            }

        }
    }
}
