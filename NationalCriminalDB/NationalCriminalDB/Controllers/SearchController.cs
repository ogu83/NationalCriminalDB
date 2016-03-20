using NationalCriminalDB.EmailServiceReference;
using NationalCriminalDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DoSearch(SearchModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var c = new EmailServiceClient();
                    var request = new EmailSendRequest
                    {
                        Name = model.Name,
                        Nationality = model.Nationality,
                        Sex = (EmailSendRequest.SexType)(int)model.Sex,
                        Age = new DataRangeOfint { Maximum = model.MaxAge, Minimum = model.MinAge },
                        Height = new DataRangeOfdecimal { Maximum = model.MaxHeight, Minimum = model.MinHeight },
                        Weight = new DataRangeOfdecimal { Maximum = model.MaxWeight, Minimum = model.MinWeight }
                    };
                    var response = c.SendCriminalRecords(request);
                    if (!response.Result)
                        throw new Exception("Service Response Error");
                    model.ResultMessage = "An E-mail with results has been sent to your account email";
                }
                catch (Exception ex)
                {
                    //TODO: Log the exception
                    model.ResultMessage = "An error has been occured while sending your result";
                    model.OnError = true;
                }
            }
            else
            {
                model.ResultMessage = "Please correct your query";
                model.OnError = true;
            }
            return View(new SearchModel());
        }
    }
}