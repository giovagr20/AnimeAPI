using System;
namespace AnimeAPI.Model
{
    public class AnimeModel
    {
        public string Id { get; set; }

        public string AnimeName { get; set; }

        public string Description { get; set; }

        public bool HasSeasons { get; set; }

        public int TotalSeasons { get; set; }

        public string PictureUrl { get; set; }

    }
}
