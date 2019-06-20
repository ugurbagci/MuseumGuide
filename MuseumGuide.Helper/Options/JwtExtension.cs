using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuseumGuide.Helper.Options
{
    public static class JwtExtension
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Applicaiton-Error", message);
            response.Headers.Add("Access-Control-Allow-Origin", "*");
            response.Headers.Add("Access-Control-Expose-Header", "Application-Error");
        }
    }
}
