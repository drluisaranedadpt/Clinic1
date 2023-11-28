using Clinic.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Clinic.Controllers
{
    public class HomeController : Controller
    {
       private readonly ILogger<HomeController> _logger;
       public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Portal()
        {
            return View();
        }

        public IActionResult Agreement()
        {
            return View();
        }
        public IActionResult Assignment()
        {
            return View();
        }
        public IActionResult Cancellation()
        {
            return View();
        }
        public IActionResult DirectAccess()
        {
            return View();
        }
        public IActionResult DirectAccess_Chinese()
        {
            return View();
        }
        public IActionResult Lien()
        {
            return View();
        }
        public IActionResult MedicalConsent()
        {
            return View();
        }
        public IActionResult Release()
        {
            return View();
        }
        public IActionResult Intake()
        {
            //{
            //    return View();
            //}
            List<Patient> patients = new List<Patient>();
            //Connecto to MySQL. 
            using (MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=clinic; port=3306; password=C@180094015pt"))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from patient", con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Extract your data. 
                    Patient patient = new Patient();
                    patient.Id = Convert.ToInt32(reader["id"]);
                    patient.FirstName = reader["first_Name"].ToString();
                    patient.LastName = reader["last_Name"].ToString();
                    patient.Age = Convert.ToInt32(reader["age"]);

                    patients.Add(patient);
                }

                reader.Close();
            }
            return View(patients);
        }
        public IActionResult PainDrawing()
        {
            return View();
        }
        public IActionResult History()
        {
            return View();
        }
        public IActionResult PastHistory()
        {
            return View();
        }

        public IActionResult SpecialTest()
        {
            return View();
        }

        public IActionResult Goals()
        {
            return View();
        }

        public IActionResult GoalsUE()
        {
            return View();
        }

        public IActionResult GoalsLE()
        {
            return View();
        }

        public IActionResult GoalsGait()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            return View();
        }
        public IActionResult Billing()
        {
            return View();
        }
        public IActionResult Covid19()
        {
            return View();
        }

        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult ClinicApplication()
        {
            return View();
        }

        public IActionResult CanvasSignaturePad() 
        {
            return View();
        }

        [HttpGet("denied")]
        public IActionResult Denied()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Secured()
        {
            var idToken = await HttpContext.GetTokenAsync("id_token");
            return View();
        }
        [HttpPost("login")]
        public async Task<IActionResult> Validate(string username, string password, string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (username == "Luis Araneda" && password == "Luis")
            {
                var claims = new List<Claim>();
                claims.Add(new Claim("username", username));
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, "Luis Eduardo Araneda"));
                // claims.Add(new Claim(ClaimTypes.Role, "Admin"));
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                await HttpContext.SignInAsync(claimsPrincipal);
                return Redirect(returnUrl);
            }
            TempData["Error"] = "Error.Username or Password is invalid";
            return View("login");
        }

        [HttpGet("login")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("https://www.google.com/accounts/Logout?continue=https://appengine.google.com/_ah/logout?continue=https://localhost:5001");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
