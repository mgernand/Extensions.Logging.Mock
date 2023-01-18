namespace Microsoft.Extensions.Logging.Mock
{
	using System;
	using JetBrains.Annotations;

    /// <summary>
    ///		Extension methods for the <see cref="IVerifyConstraintsBuilder{T}"/> type.
    /// </summary>
    [PublicAPI]
	public static class VerifyConstraintsBuilderExtensions
	{
		/// <summary>
		///     Verifies if the underlying logger was called for the given amount of times.
		/// </summary>
		/// <typeparam name="T">The type of the generic parameter of the logger.</typeparam>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="times">The amount of times the logger should have been called.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> Times<T>(this IVerifyConstraintsBuilder<T> builder, int times)
		{
			builder.LogWasCalledTimes(times);
			return builder;
		}

		/// <summary>
		///     Verifies if the underlying logger was called for the given amount of times.
		/// </summary>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="times">The amount of times the logger should have been called.</param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder Times(this IVerifyConstraintsBuilder builder, int times)
		{
			builder.LogWasCalledTimes(times);
			return builder;
		}

		/// <summary>
		///     Verifies if the underlying loggers logged message satisfies the given <see cref="Predicate{String}" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="predicate"></param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> Message<T>(this IVerifyConstraintsBuilder<T> builder, Predicate<string> predicate)
		{
			builder.LogWasCalledMessage(predicate);
			return builder;
		}

		/// <summary>
		///     Verifies if the underlying loggers logged message satisfies the given <see cref="Predicate{String}" />.
		/// </summary>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="predicate"></param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder Message(this IVerifyConstraintsBuilder builder, Predicate<string> predicate)
		{
			builder.LogWasCalledMessage(predicate);
			return builder;
		}

		/// <summary>
		///     Verifies if the underlying loggers logged message equals the given <see cref="String" />.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="message"></param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder<T> MessageEquals<T>(this IVerifyConstraintsBuilder<T> builder, string message)
		{
			builder.LogWasCalledMessage(str => str == message);
			return builder;
		}

		/// <summary>
		///     Verifies if the underlying loggers logged message equals the given <see cref="String" />.
		/// </summary>
		/// <param name="builder">The verify constraints builder.</param>
		/// <param name="message"></param>
		/// <returns>The verify constraints builder.</returns>
		public static IVerifyConstraintsBuilder MessageEquals(this IVerifyConstraintsBuilder builder, string message)
		{
			builder.LogWasCalledMessage(str => str == message);
			return builder;
		}
	}
}
