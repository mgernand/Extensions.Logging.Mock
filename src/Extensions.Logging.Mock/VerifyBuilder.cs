namespace Microsoft.Extensions.Logging.Mock
{
	using System;
	using Moq;

	internal sealed class VerifyBuilder : IVerifyBuilder
	{
		public VerifyBuilder(Mock<ILogger> logger)
		{
			this.Logger = logger;
		}

		/// <inheritdoc />
		public Mock<ILogger> Logger { get; }

		/// <inheritdoc />
		Mock<ILogger> IVerifyBuilder.LogWasCalled(LogLevel logLevel)
		{
			this.Logger.Verify(
				x => x.Log(
					It.Is<LogLevel>(l => l == logLevel),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => true),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!));

			return this.Logger;
		}
	}

	internal sealed class VerifyBuilder<T> : IVerifyBuilder<T>
	{
		public VerifyBuilder(Mock<ILogger<T>> logger)
		{
			this.Logger = logger;
		}

		/// <inheritdoc />
		public Mock<ILogger<T>> Logger { get; }

		/// <inheritdoc />
		Mock<ILogger<T>> IVerifyBuilder<T>.LogWasCalled(LogLevel logLevel)
		{
			this.Logger.Verify(
				x => x.Log(
					It.Is<LogLevel>(l => l == logLevel),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => true),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!));

			return this.Logger;
		}
	}
}
