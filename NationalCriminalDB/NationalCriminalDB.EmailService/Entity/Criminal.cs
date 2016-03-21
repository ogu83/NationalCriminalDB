using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NationalCriminalDB.EmailService.Entity
{
    public partial class Criminal
    {
        public int Age { get { return (int)((DateTime.Now - BirthDate).TotalDays / 365); } }
    }
}