﻿#region License
// 
// Author: Nate Kohari <nate@enkari.com>
// Copyright (c) 2009, Enkari, Ltd.
// 
// Dual-licensed under the Apache License, Version 2.0, and the Microsoft Public License (Ms-PL).
// See the file LICENSE.txt for details.
// 
#endregion
#region Using Directives
using System;
using System.Web.Mvc;
using Ninject.Website.Framework;
#endregion

namespace Ninject.Website.Controllers
{
	public class ErrorController : NinjectControllerBase
	{
		public ViewResult ShowNotFound()
		{
			return View("error404");
		}

		public ViewResult Show(string code)
		{
			return View("error" + code);
		}
	}
}