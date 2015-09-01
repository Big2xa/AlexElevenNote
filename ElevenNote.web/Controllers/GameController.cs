using ElevenNote.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElevenNote.web.Controllers
{
    public class GameController : Controller
    { 
        #region GET 
        // GET: Game
        [HttpGet]
        [ActionNameAttribute("Index")]
        public ActionResult IndexGet()
        {
            var correctAnswer = new Random().Next(1, 100);
            Session["Answer"] = correctAnswer;
            var foo = Session["Answer"];
            return View();
        }

        #endregion

        #region POST

        [HttpPost]
        [ActionName("Index")]
        public ActionResult IndexPost(GuessingGameViewModel model)
        {
            if (ModelState.IsValid)
            {
                var answer = (int)Session["Answer"];
                if (model.Guess == answer)
                {
                    ViewBag.Win = true;
                }
                else if(model.Guess < answer)
                {
                    ViewBag.HighGuess = false;
                    ViewBag.Win = false;
                }
                else if (model.Guess > answer)
                {
                    ViewBag.HighGuess = true;
                    ViewBag.Win = false;
                }
            }
            return View(model);
        }
        #endregion
    }
}