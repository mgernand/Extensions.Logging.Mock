namespace Extensions.Logging.Mock.UnitTests
{
	using System;
	using JetBrains.Annotations;

	[PublicAPI]
	public static class TestUtil
	{
		public static void Times(this int times, Action<int> action)
		{
			for(int i = 0; i < times; i++)
			{
				action.Invoke(i);
			}
		}
	}
}
