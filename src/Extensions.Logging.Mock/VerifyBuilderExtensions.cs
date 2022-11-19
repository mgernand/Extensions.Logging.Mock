namespace Microsoft.Extensions.Logging.Mock
{
	using JetBrains.Annotations;
	using Moq;

    /// <summary>
    ///		Extension methods for the <see cref="IVerifyBuilder{T}"/> type.
    /// </summary>
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
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Trace" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder TraceWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Trace);
			return new VerifyConstraintsBuilder(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Trace" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> TraceWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Trace);
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
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Debug" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> DebugWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Debug);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Debug" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder DebugWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Debug);
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
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Information" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> InformationWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Information);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Information" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder InformationWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Information);
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
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Warning" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> WarningWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Warning);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Warning" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder WarningWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Warning);
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
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Error" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> ErrorWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Error);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Error" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder ErrorWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Error);
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

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Critical" />.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> CriticalWasNotCalled<T>(this IVerifyBuilder<T> builder)
		{
			Mock<ILogger<T>> logger = builder.LogWasNotCalled(LogLevel.Critical);
			return new VerifyConstraintsBuilder<T>(logger);
		}

		/// <summary>
		///     Verifies if the underlying logger was NOT called for the log level <see cref="LogLevel.Critical" />.
		/// </summary>
		/// <param name="builder">The verify builder.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder CriticalWasNotCalled(this IVerifyBuilder builder)
		{
			Mock<ILogger> logger = builder.LogWasNotCalled(LogLevel.Critical);
			return new VerifyConstraintsBuilder(logger);
		}
	}
}
