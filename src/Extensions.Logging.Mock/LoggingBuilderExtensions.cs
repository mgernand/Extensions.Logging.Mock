namespace Microsoft.Extensions.Logging.Mock
{
	using System;
	using JetBrains.Annotations;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.DependencyInjection.Extensions;
	using Microsoft.Extensions.Logging.Configuration;
	using Moq;

    /// <summary>
    ///		Extension methods for the <see cref="ILoggingBuilder"/> type.
    /// </summary>
    [PublicAPI]
	public static class LoggingBuilderExtensions
	{
		/// <summary>
		///     Adds a <see cref="MockLoggerProvider" /> for the given logger mock instance.
		/// </summary>
		/// <param name="builder">The logging builder.</param>
		/// <param name="loggerMock">The logger mock.</param>
		/// <returns>The logging builder.</returns>
		/// <exception cref="ArgumentNullException">
		///     Thrown if one of the input parameters <paramref name="builder" /> or
		///     <paramref name="loggerMock" /> was <c>null</c>.
		/// </exception>
		public static ILoggingBuilder AddMock(this ILoggingBuilder builder, Mock<ILogger> loggerMock)
		{
			if(builder is null)
			{
				throw new ArgumentNullException(nameof(builder));
			}

			if(loggerMock is null)
			{
				throw new ArgumentNullException(nameof(loggerMock));
			}

			builder.AddConfiguration();

			ILoggerProvider provider = new MockLoggerProvider(loggerMock);
			builder.Services.TryAddEnumerable(ServiceDescriptor.Singleton(provider));

			return builder;
		}
	}
}
