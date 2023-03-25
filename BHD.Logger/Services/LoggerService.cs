using System;
using System.Collections.Concurrent;
using BHD.Logger.Models;

namespace BHD.Logger.Services
{
	public class LoggerService
    {
        private ConcurrentQueue<Log> logs;

		private WriterService writerService;

        public LoggerService(WriterService writerService)
		{
			this.logs = new ConcurrentQueue<Log>();
			this.writerService = writerService;
		}

		public void AddLog(Log singleLog)
		{
			this.logs.Enqueue(singleLog);
			this.writerService.Write(singleLog);
		}

		public void ClearLogs()
		{
			this.logs.Clear();
		}

		public List<Log> GetAllLogs()
		{
			return this.logs.ToList<Log>();
		}

		public long GetLogsNumber()
		{
			return this.logs.Count();
		}
	}
}

