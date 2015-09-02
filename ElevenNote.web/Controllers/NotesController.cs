using ElevenNote.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.web.Controllers
{
    public class NotesController : Controller
    {
        // GET: Notes
        public ActionResult Index()
        {
            var Notes = new List<NoteListViewModel>();
            Notes.Add(new NoteListViewModel()
            {
                Id = 0,
                DateCreated = DateTime.UtcNow.AddMonths(-3),
                DateModified = DateTime.UtcNow,
                IsFavorite = true,
                Title = "An Excellent Note"

            });
            Notes.Add(new NoteListViewModel()
            {
                Id = 1,
                DateCreated = DateTime.UtcNow.AddMonths(-2),
                DateModified = DateTime.UtcNow,
                IsFavorite = true,
                Title = "Even Better Note"

            });
            Notes.Add(new NoteListViewModel()
            {
                Id = 2,
                DateCreated = DateTime.UtcNow.AddMonths(-1),
                DateModified = DateTime.UtcNow,
                IsFavorite = false,
                Title = "This Note is Kinda Wack"

            });
            Notes.Add(new NoteListViewModel()
            {
                Id = 3,
                DateCreated = DateTime.UtcNow,
                DateModified = null,
                IsFavorite = true,
                Title = "A Return to Form"

            });
            return View(Notes);
        }
    }
}