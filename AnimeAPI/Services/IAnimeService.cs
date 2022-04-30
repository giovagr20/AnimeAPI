using System;
using System.Collections.Generic;
using AnimeAPI.Model;

namespace AnimeAPI.Services
{
    public interface IAnimeService
    {
        IEnumerable<AnimeModel> GetAnimes();

        void SaveAnime(AnimeModel model);

        AnimeModel GetAnimeById(int id);
    }
}
