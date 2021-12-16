namespace Extensions.Logging.Mock
{
	using System;
	using JetBrains.Annotations;
	using Microsoft.Extensions.Logging;
	using Moq;

	/// <summary>
	///     An endpoint for implementing logger verification extension methods on.
	/// </summary>
	/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
	[PublicAPI]
	public interface IVerifyConstraintsBuilder<T>
	{
		/// <summary>
		///     The underlying logger mock.
		/// </summary>
		Mock<ILogger<T>> Logger { get; }

		/// <summary>
		///     Verifies if the underlying logger was called for the given amount of times.
		/// </summary>
		/// <param name="times">The expected amount.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger<T>> LogWasCalledTimes(int times);

		/// <summary>
		///     Verifies if the underlying loggers logged message satisfies the given <see cref="Predicate{String}" />.
		/// </summary>
		/// <param name="predicate">The predicate to satisfy by the logged message.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger<T>> LogWasCalledMessage(Predicate<string> predicate);
	}

	/// <summary>
	///     An endpoint for implementing logger verification extension methods on.
	/// </summary>
	[PublicAPI]
	public interface IVerifyConstraintsBuilder
	{
		/// <summary>
		///     The underlying logger mock.
		/// </summary>
		Mock<ILogger> Logger { get; }

		/// <summary>
		///     Verifies if the underlying logger was called for the given amount of times.
		/// </summary>
		/// <param name="times">The expected amount.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger> LogWasCalledTimes(int times);

		/// <summary>
		///     Verifies if the underlying loggers logged message satisfies the given <see cref="Predicate{String}" />.
		/// </summary>
		/// <param name="predicate">The predicate to satisfy by the logged message.</param>
		/// <returns>The underlying logger mock.</returns>
		Mock<ILogger> LogWasCalledMessage(Predicate<string> predicate);
	}
}
