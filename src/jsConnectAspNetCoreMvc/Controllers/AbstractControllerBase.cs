﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace jsConnectNetCore.Controllers
{
	/// <summary>
	/// Base controller containing default shared functionality.
	/// </summary>
	public abstract class AbstractControllerBase<T> : Controller
	{
		protected IConfiguration Configuration { get; set; }
		protected ILogger<T> Logger { get; set; }

		protected AbstractControllerBase(IConfiguration configuration, ILogger<T> logger)
		{
			Configuration = configuration;
			Logger = logger;
		}
	}
}
