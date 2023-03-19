using System;
using BHD.Logger.Models;

namespace BHD.Logger.Interfaces
{
	public interface ILogGenerator
	{
		public void Start();
		public void Stop();
		public Log GetRandomLog();
    }
}

