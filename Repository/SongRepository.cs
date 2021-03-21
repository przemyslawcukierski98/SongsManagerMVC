using SongsManagerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Repository
{
    public class SongRepository : ISongRepository
    {
        public void Add(SongModel song)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SongModel Get(int songId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SongModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, SongModel song)
        {
            throw new NotImplementedException();
        }
    }
}
