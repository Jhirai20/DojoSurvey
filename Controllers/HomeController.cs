using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
namespace DojoSurvey
{
    public class HomeController :Controller
    {
    [HttpGet("")]
    public ViewResult Index()
    {
        return View("Index");
    }
    [HttpPost("Submit")]
    public IActionResult Result(Survey survey) 
    {
        if(ModelState.IsValid)
        {
        return View(survey);
        }
        return View("Index");
    }

    }
}