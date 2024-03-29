﻿namespace Microsoft.Extensions.Logging.Mock
{
	using System;
	using JetBrains.Annotations;
	using Moq;

	/// <summary>
	///     A <see cref="ILoggerProvider" /> implementation that provides an instance of
	///     a mocked <see cref="T:Microsoft.Extensions.Logging.ILogger" />.
	/// </summary>
	[PublicAPI]
	public class MockLoggerProvider : ILoggerProvider
	{
		private readonly Mock<ILogger> loggerMock;

        /// <summary>
        ///		Initializes a new instance of the <see cref="MockLoggerProvider"/> type.
        /// </summary>
        /// <param name="loggerMock"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MockLoggerProvider(Mock<ILogger> loggerMock)
		{
			this.loggerMock = loggerMock ?? throw new ArgumentNullException(nameof(loggerMock));
		}

		/// <inheritdoc />
		public ILogger CreateLogger(string categoryName)
		{
			return this.loggerMock.Object;
		}

		/// <inheritdoc />
		public void Dispose()
		{
		}
	}
}
