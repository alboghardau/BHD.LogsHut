using BHD.Logger.DeepCore.Models;
using System;
namespace BHD.LogsHut.DTOs
{
	public class LiveLogsRequestDto
	{
		public Filter[]? Filters { get; set; }
        public DateTime RequestTime { get; set; }  
        public bool IsFirstCall { get; set; }
	}
}

