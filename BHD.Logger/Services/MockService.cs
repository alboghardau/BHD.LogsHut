using System;
using BHD.Logger.Interfaces;
using BHD.Logger.Mock;

namespace BHD.Logger.Services
{
	public class MockService : IMockService
	{
		ILogGenerator logGenerator;
        LoggerService loggerService;
        Thread mockThread;

		public MockService(LogGenerator logGenerator, LoggerService loggerService)
		{
			this.logGenerator = logGenerator;
            this.loggerService = loggerService;
		}

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        private void GenerateLog()
        {
            var log = this.logGenerator.GetRandomLog();
            this.loggerService.AddLog(log);
        }
    }
}

