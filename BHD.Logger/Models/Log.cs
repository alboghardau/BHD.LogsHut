using System;
namespace BHD.Logger.Models
{
	public class Log
	{
		public DateTime Time { get; set; }
		public LogLevel LogLevel { get; set; }
		public String Service { get; set; }
		public String Message { get; set; }
		public String MethodName { get; set; }
		public String IpAdress { get; set; }
		public String User { get; set; }
		public String CallStack { get; set; }
	}
}

