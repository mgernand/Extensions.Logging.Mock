namespace Microsoft.Extensions.Logging.Mock
{
	using JetBrains.Annotations;
	using Moq;

	[PublicAPI]
	public static class VerifyBuilderExtensions
	{
		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Trace" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> TraceWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Trace);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Trace" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder TraceWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Trace);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Debug" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> DebugWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Debug);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Debug" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder DebugWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Debug);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Information" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> InformationWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Information);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Information" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder InformationWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Information);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Warning" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> WarningWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Warning);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Warning" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder WarningWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Warning);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Error" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> ErrorWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Error);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Error" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder ErrorWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Error);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Critical" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> CriticalWasCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasCalled(LogLevel.Critical);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the log level <see cref="LogLevel.Critical" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder CriticalWasCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasCalled(LogLevel.Critical);
			return new VerifyConstraintsBuilder(logger);
		}
	}
}
