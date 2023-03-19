using System;
using System.Collections.Concurrent;
using BHD.Logger.Models;

namespace BHD.Logger.Services
{
	public class LoggerService
    {
        private ConcurrentQueue<Log> Logs;

        public LoggerService()
		{
			this.Logs = new ConcurrentQueue<Log>();
		}

		public void AddLog(Log singleLog)
		{
			this.Logs.Enqueue(singleLog);
		}

		public void ClearLogs()
		{
			this.Logs.Clear();
		}

		public List<Log> GetAllLogs()
		{
			return this.Logs.ToList<Log>();
		}

		public long GetLogsNumber()
		{
			return this.Logs.Count();
		}
	}
}

