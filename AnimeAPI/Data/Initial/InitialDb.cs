using System;
using System.Threading.Tasks;
using AnimeAPI.Model;

namespace AnimeAPI.Data.Initial
{
    public class InitialDb
    {
        private readonly DataContext _dataContext;

        public InitialDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task SeedAsync()
        {
            await _dataContext.Database.EnsureCreatedAsync();

            _dataContext.Anime.Add(new AnimeModel
            {
                AnimeName = "Shaman King",
                Description = "About Shaman",
                HasSeasons = true,
                TotalSeasons = 2,
                PictureUrl = "url:imagen"
            });
        }
    }
}
