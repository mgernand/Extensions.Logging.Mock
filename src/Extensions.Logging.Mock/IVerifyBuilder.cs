namespace Extensions.Logging.Mock
{
	using JetBrains.Annotations;
	using Microsoft.Extensions.Logging;
	using Moq;

	/// <summary>
	///     An endpoint for implementing logger verification extension methods on.
	/// </summary>
	/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
	[PublicAPI]
	public interface IVerifyBuilder<T>
	{
		/// <summary>
		///     The underlying logger mock.
		/// </summary>
		Mock<ILogger<T>> Logger { get; }

		/// <summary>
		///     Verifies if the underlying logger was called for the given <see cref="LogLevel" />.
		/// </summary>
		/// <param name="logLevel">The log level.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger<T>> LogWasCalled(LogLevel logLevel);
	}

	/// <summary>
	///     An endpoint for implementing logger verification extension methods on.
	/// </summary>
	[PublicAPI]
	public interface IVerifyBuilder
	{
		/// <summary>
		///     The underlying logger mock.
		/// </summary>
		Mock<ILogger> Logger { get; }

		/// <summary>
		///     Verifies if the underlying logger was called for the given <see cref="LogLevel" />.
		/// </summary>
		/// <param name="logLevel">The log level.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger> LogWasCalled(LogLevel logLevel);
	}
}
