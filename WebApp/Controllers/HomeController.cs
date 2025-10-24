using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;

namespace WebApp.Controllers
{
 public class HomeController : Controller
 {
 public IActionResult Index()
 {
 // Set a sample cookie
 Response.Cookies.Append("SampleCookie", "HelloCookie", new CookieOptions { HttpOnly = true });
 return View();
 }

 public IActionResult Info()
 {
 var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Unknown";
 return Json(new {
 Name = "WebApp",
 Version = "1.0.0",
 Environment = env
 });
 }

 public IActionResult ReadCookie()
 {
 var cookieValue = Request.Cookies["SampleCookie"] ?? "Not set";
 return Content($"SampleCookie value: {cookieValue}");
 }
 }
}
