using System;
using BHD.Logger.Interfaces;
using BHD.Logger.Mock;
using BHD.Logger.Services;

namespace BHD.Logger.Utils
{
	public class ServiceUtils
	{
		public static void RegisterServices(WebApplicationBuilder builder)
		{
			//Singletons
            builder.Services.AddSingleton<LoggerService>();

			//Transient
            builder.Services.AddTransient<IMockService, MockService>();
            builder.Services.AddTransient<ILogGenerator, LogGenerator>();
        }
	}
}

