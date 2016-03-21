using NationalCriminalDB.EmailService.Entity;
using NationalCriminalDB.EmailService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NationalCriminalDB.EmailService.Helpers
{
    public class SQLHelper
    {
        /// <summary>
        /// Gets Criminal result from database via filters
        /// </summary>
        /// <param name="name">Contains Name Filter, multiple values will be seperated with spaces (example : "Mike Halley Name1 Name2 etc...")</param>
        /// <param name="age">Age Range Filter</param>
        /// <param name="height">Height Range Filter</param>
        /// <param name="weight">Waight Range Filter</param>
        /// <param name="nationality">Contains Nationality Filter, multiple values will be seperated with spaces (example : "Mike Halley Name1 Name2 etc...")</param>
        /// <param name="sex">Sex Filter</param>
        /// <returns></returns>
        public static List<Criminal> GetFilteredResult(
            string name, DataRange<int> age,
            DataRange<decimal> height,
            DataRange<decimal> weight,
            string nationality,
            EmailSendRequest.SexType sex)
        {
            var dataContext = new CriminalsDataContext();
            var myTable = dataContext.GetTable<Criminal>();

            IQueryable<Criminal> result =
                myTable.Where(x => x.BirthDate.Year <= (DateTime.Now.Year - age.Minimum)
                                && x.BirthDate.Year >= (DateTime.Now.Year - age.Maximum)
                                && x.Height >= height.Minimum
                                && x.Height <= height.Maximum
                                && x.Weight >= weight.Minimum
                                && x.Weight <= weight.Maximum
                                );

            if (!string.IsNullOrEmpty(name))
            {
                var namePredicate = arrangeStringArrayPredicate(name, "Name");
                result = result.Where(namePredicate);
            }

            if (!string.IsNullOrEmpty(nationality))
            {
                var nationalityPredicate = arrangeStringArrayPredicate(nationality, "Nationality");
                result = result.Where(nationalityPredicate);
            }

            if (sex != EmailSendRequest.SexType.All)
                result = result.Where(x => x.Sex == (int)sex);

            return result.ToList();
        }

        private static Expression<Func<Criminal, bool>> arrangeStringArrayPredicate(string arr, string propertyName)
        {
            var elems = arr.Split(' ');
            var predicate = PredicateBuilder.False<Criminal>();
            foreach (var n in elems)
                switch (propertyName)
                {
                    case "Name":
                        predicate = predicate.Or(x => x.Name.Contains(n.ToLower()));
                        break;
                    case "Nationality":
                        predicate = predicate.Or(x => x.Nationality.Contains(n.ToLower()));
                        break;
                    default:
                        break;
                }

            return predicate;
        }
    }
}