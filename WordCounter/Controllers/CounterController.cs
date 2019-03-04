using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class CounterController : Controller 
    {
        [HttpGet("/counter")]
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost("/counter/result")]
        public ActionResult Result(string userWord, string userWriting)
        {
            Counter.SetWord(userWord);
            Counter.SetWriting(userWriting);
            return View("Result", Counter.GetCount());
        }

    }
}