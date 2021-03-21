using SongsManagerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Repository
{
    public interface ISongRepository
    {
        SongModel Get(int songId);
        IQueryable<SongModel> GetAll();
        void Add(SongModel song);
        void Update(int id, SongModel song);
        void Delete(int id);
    }
}
