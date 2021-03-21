using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SongsManagerMVC.Models;
using SongsManagerMVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SongsManagerMVC.Controllers
{
    public class SongsController : Controller
    {
        private readonly ISongRepository _songRepository;

        public SongsController(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        // GET: SongsController
        public ActionResult Index()
        {
            return View(_songRepository.GetAll());
        }

        // GET: SongsController/Details/5
        public ActionResult Details(int id)
        {
            return View(_songRepository.Get(id));
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
            _songRepository.Add(songModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: SongsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_songRepository.Get(id));
        }

        // POST: SongsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SongModel songModel)
        {
            _songRepository.Update(id, songModel);

            return RedirectToAction(nameof(Index));
        }

        // GET: SongsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_songRepository.Get(id));
        }

        // POST: SongsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, SongModel songModel)
        {
            _songRepository.Delete(id);

            return RedirectToAction(nameof(Index));
        }
    }
}
