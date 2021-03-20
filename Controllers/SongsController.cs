using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SongsManagerMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Controllers
{
    public class SongsController : Controller
    {
        private static IList<SongModel> songs = new List<SongModel>()
        {
            new SongModel(){ Id = 1, Album = "SATURATION III", Artist = "BROCKHAMPTON", Description = "Brockhampton album", Length = 40},
            new SongModel(){ Id = 2, Album = "Arca", Artist = "Arca", Description = "self-titled third studio album by Venezuelan electronic record producer Arca, released on 7 April 2017 through XL Recordings", Length = 45},
            new SongModel(){ Id = 3, Album = "Arca", Artist = "KICK I", Description = "is the fourth studio album by Venezuelan electronic record producer Arca", Length = 0}
        };

        // GET: SongsController
        public ActionResult Index()
        {
            return View(songs);
        }

        // GET: SongsController/Details/5
        public ActionResult Details(int id)
        {
            return View(songs.FirstOrDefault(x => x.Id == id));
        }

        // GET: SongsController/Create
        public ActionResult Create()
        {
            return View(new SongModel());
        }

        // POST: SongsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SongModel songModel)
        {
            songModel.Id = songs.Count + 1;
            songs.Add(songModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: SongsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(songs.FirstOrDefault(x => x.Id == id));
        }

        // POST: SongsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SongModel songModel)
        {
            SongModel song = songs.FirstOrDefault(x => x.Id == id);
            song.Title = songModel.Title;
            song.Album = songModel.Album;
            song.Length = songModel.Length;
            song.Artist = songModel.Artist;
            song.Description = songModel.Description;



            return RedirectToAction(nameof(Index));
        }

        // GET: SongsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SongsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
