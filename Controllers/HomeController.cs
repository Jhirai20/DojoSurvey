using Microsoft.AspNetCore.Mvc;
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
    public IActionResult Result(string NameField,string LocationField, string LanguageField, string CommentField)
    {
        ViewBag.name=NameField;
        ViewBag.location=LocationField;
        ViewBag.Language=LanguageField;
        ViewBag.Comment=CommentField;
        return View("Result");
    }

    }
}