using NationalCriminalDB.EmailServiceReference;
using NationalCriminalDB.Models;
using System;
using System.Web.Mvc;

namespace NationalCriminalDB.Controllers
{
    [Authorize]
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {
            return View(new SearchModel());
        }

        //POST: Search
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SearchModel model)
        {
            model.OnError = true;
            if (ModelState.IsValid)
            {
                try
                {
                    var response = SendQuery(model);
                    if (!response.Result)
                        throw new Exception("Service Response Error");
                    model.ResultMessage = "An E-mail with results has been sent to your account email";
                }
                catch (Exception ex)
                {
                    //TODO: Log the exception
                    model.ResultMessage = "An error has been occured while sending your result";
                }
            }
            else
            {
                model.ResultMessage = "Please correct your query";
            }
            return View(model);
        }

        private EmailSendResponse SendQuery(SearchModel model)
        {
            var c = new EmailServiceClient();
            var request = new EmailSendRequest
            {
                Email = User.Identity.Name,
                Name = model.Name,
                Nationality = model.Nationality,
                Sex = (EmailSendRequest.SexType)(int)model.Sex,
                Age = new DataRangeOfint { Maximum = model.MaxAge, Minimum = model.MinAge },
                Height = new DataRangeOfdecimal { Maximum = model.MaxHeight, Minimum = model.MinHeight },
                Weight = new DataRangeOfdecimal { Maximum = model.MaxWeight, Minimum = model.MinWeight }
            };
            var response = c.SendCriminalRecords(request);
            return response;
        }
    }
}