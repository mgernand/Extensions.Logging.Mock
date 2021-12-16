namespace Microsoft.Extensions.Logging.Mock
{
	using JetBrains.Annotations;
	using Moq;

	[PublicAPI]
	public static class MockLoggerExtensions
	{
		/// <summary>
		///     The entry point for any logger mock verification.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="logger">The logger mock instance.</param>
		/// <returns>The verify builder.</returns>
		public static IVerifyBuilder<T> VerifyLog<T>(this Mock<ILogger<T>> logger)
		{
			return new VerifyBuilder<T>(logger);
		}

		/// <summary>
		///     The entry point for any logger mock verification.
		/// </summary>
		/// <param name="logger">The logger mock instance.</param>
		/// <returns>The verify builder.</returns>
		public static IVerifyBuilder VerifyLog(this Mock<ILogger> logger)
		{
			return new VerifyBuilder(logger);
		}
	}
}
