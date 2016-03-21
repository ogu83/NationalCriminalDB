using NationalCriminalDB.EmailService.Helpers;
using NationalCriminalDB.EmailService.Models;
using System;
using System.Threading.Tasks;

namespace NationalCriminalDB.EmailService
{
    public class EmailService : IEmailService
    {
        public EmailSendResponse SendCriminalRecords(EmailSendRequest request)
        {
            var response = new EmailSendResponse();
            try
            {
                if (request.Age.Minimum < 0 || request.Age.Maximum < 0 || request.Age.Maximum < request.Age.Minimum)
                    throw new ArgumentOutOfRangeException("Age Range Validation Error");
                if (request.Weight.Minimum < 0 || request.Weight.Maximum < 0 || request.Weight.Maximum < request.Weight.Minimum)
                    throw new ArgumentOutOfRangeException("Weight Range Validation Error");
                if (request.Height.Minimum < 0 || request.Height.Maximum < 0 || request.Height.Maximum < request.Height.Minimum)
                    throw new ArgumentOutOfRangeException("Height Range Validation Error");

                var searchResult = SQLHelper.GetFilteredResult(request.Name, request.Age, request.Height, request.Weight, request.Nationality, request.Sex);
                if (searchResult.Count == 0)
                    throw new ArgumentNullException("No Result");

                //TODO: Generate Pdf's


                else
                {
                    response.Result = true;
                    Task emailTask = new Task(new Action(() =>
                    {
                        //TODO: Email here
                    }));
                    emailTask.Start();
                }
            }
            catch (Exception ex)
            {
                //TODO: Log Exception
            }
            return response;
        }
    }
}