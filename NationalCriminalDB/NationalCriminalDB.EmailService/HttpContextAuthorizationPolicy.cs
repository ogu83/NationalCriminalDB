﻿using System.Collections.Generic;
using System.IdentityModel.Claims;
using System.IdentityModel.Policy;
using System.Security.Principal;
using System.Web;

namespace NationalCriminalDB.EmailService
{
    public class HttpContextAuthorizationPolicy: IAuthorizationPolicy
    {
        public bool Evaluate(EvaluationContext evaluationContext, ref object state)
        {
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                evaluationContext.Properties["Principal"] = context.User;
                evaluationContext.Properties["Identities"] = new List<IIdentity>() { context.User.Identity };
            }
            return true;
        }

        public System.IdentityModel.Claims.ClaimSet Issuer
        {
            get { return ClaimSet.System; }
        }

        public string Id
        {
            get { return "HttpContextAuthorizationPolicy"; }
        }
    }
}