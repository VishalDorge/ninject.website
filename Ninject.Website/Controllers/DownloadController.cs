﻿#region License
//
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2007-2010, Enkari, Ltd.
//
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
//
#endregion
#region Using Directives
using System.Web.Mvc;
#endregion

namespace Ninject.Website.Controllers
{
    public class DownloadController : Controller
    {
        public ViewResult Show()
        {
            return View();
        }
    }
}