﻿using System.Web;
using System.Web.Mvc;

namespace n01593039Assignment2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
