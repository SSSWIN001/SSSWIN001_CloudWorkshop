﻿using System.Web;
using System.Web.Mvc;

namespace SSSWIN001_CloudWorkshop
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
