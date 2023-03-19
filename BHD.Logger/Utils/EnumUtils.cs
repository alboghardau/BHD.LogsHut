using System;
namespace BHD.Logger.Utils
{
	public static class EnumUtils
	{
		public static T GetRandomEnumElement<T>()
		{
			var random = new Random();
			var values = Enum.GetValues(typeof(T));
			int index = random.Next(0, values.Length);
			return (T)values.GetValue(index);
		}
	}
}

