﻿using System.Web;
using System.Web.Mvc;

namespace ElevenNote.Mvc.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}