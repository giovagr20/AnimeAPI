using System;
using System.Collections.Generic;
using System.Linq;
using AnimeAPI.Data;
using AnimeAPI.Model;

namespace AnimeAPI.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly DataContext _datacontext;

        public AnimeService(DataContext dataContext)
        {
            _datacontext = dataContext;
        }

        public AnimeModel GetAnimeById(int id)
        {
            if (id == 0)
            {
                return new AnimeModel();
            }

            return _datacontext.Anime.Find(id);
        }

        public IEnumerable<AnimeModel> GetAnimes()
        {
            return _datacontext.Set<AnimeModel>().AsEnumerable<AnimeModel>();
        }

        public void SaveAnime(AnimeModel model)
        {
            if (model == null)
            {
                throw new Exception("Debe enviar el formato correcto");
            }

            _datacontext.Anime.Add(model);
        }
    }
}
