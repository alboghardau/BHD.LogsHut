using System;
using BHD.Logger.Interfaces;
using BHD.Logger.Mock;
using BHD.Logger.Services;
using BHD.Logger.Utils.Writers;

namespace BHD.Logger.Utils
{
	public class ServiceUtils
	{
		public static void RegisterServices(WebApplicationBuilder builder)
		{
			//Singletons
			builder.Services.AddSingleton<LoggerService>();
			builder.Services.AddSingleton<WriterService>();

            //Transient
            builder.Services.AddTransient<ILogGenerator, LogGenerator>();
            builder.Services.AddTransient<IMockService, MockService>();

			builder.Services.AddTransient<ILogWriter, ConsoleWriter>();
        }
	}
}

