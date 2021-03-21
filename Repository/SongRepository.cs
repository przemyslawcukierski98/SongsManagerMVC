using SongsManagerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Repository
{
    public class SongRepository : ISongRepository
    {
        private readonly SongsManagerContext _context;

        public SongRepository(SongsManagerContext context)
        {
            _context = context;
        }

        public void Add(SongModel song)
        {
            _context.Songs.Add(song);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var result = _context.Songs.SingleOrDefault(x => x.Id == id);
            if(result != null)
            {
                _context.Songs.Remove(result);
                _context.SaveChanges();
            }

        }

        public SongModel Get(int id)
            => _context.Songs.SingleOrDefault(x => x.Id == id);

        public IQueryable<SongModel> GetAll()
            => _context.Songs.Where(x => true);

        public void Update(int id, SongModel song)
        {
            var result = _context.Songs.SingleOrDefault(x => x.Id == id);
            if(result != null)
            {
                result.Title = song.Title;
                result.Album = song.Album;
                result.Artist = song.Artist;
                result.Length = song.Length;
                result.Description = song.Description;

                _context.SaveChanges();
            }
        }
    }
}
