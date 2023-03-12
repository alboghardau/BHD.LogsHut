using System;
using BHD.Logger.Models;

namespace BHD.Logger.Services
{
	public class LoggerService
    {
        private List<Log> Logs;

        public LoggerService()
		{
			this.Logs = new List<Log>();
		}

		public void AddLog(Log singleLog)
		{
			this.Logs.Add(singleLog);
		}

		public void ClearLogs()
		{
			this.Logs.Clear();
		}

		public List<Log> GetAllLogs()
		{
			return this.Logs;
		}

		public long GetLogsNumber()
		{
			return this.Logs.Count();
		}
	}
}

