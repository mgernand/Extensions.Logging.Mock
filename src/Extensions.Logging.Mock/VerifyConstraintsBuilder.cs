namespace Microsoft.Extensions.Logging.Mock
{
	using System;
	using Moq;

	internal sealed class VerifyConstraintsBuilder<T> : IVerifyConstraintsBuilder<T>
	{
		public VerifyConstraintsBuilder(Mock<ILogger<T>> logger)
		{
			this.Logger = logger;
		}

		/// <inheritdoc />
		public Mock<ILogger<T>> Logger { get; }

		/// <inheritdoc />
		Mock<ILogger<T>> IVerifyConstraintsBuilder<T>.LogWasCalledTimes(int times)
		{
			this.Logger.Verify(
				x => x.Log(
					It.IsAny<LogLevel>(),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => true),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!),
				Times.Exactly(times));

			return this.Logger;
		}

		/// <inheritdoc />
		Mock<ILogger<T>> IVerifyConstraintsBuilder<T>.LogWasCalledMessage(Predicate<string> predicate)
		{
			this.Logger.Verify(
				x => x.Log(
					It.IsAny<LogLevel>(),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => predicate.Invoke(v.ToString())),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!));

			return this.Logger;
		}
	}

	internal sealed class VerifyConstraintsBuilder : IVerifyConstraintsBuilder
	{
		public VerifyConstraintsBuilder(Mock<ILogger> logger)
		{
			this.Logger = logger;
		}

		/// <inheritdoc />
		public Mock<ILogger> Logger { get; }

		/// <inheritdoc />
		Mock<ILogger> IVerifyConstraintsBuilder.LogWasCalledTimes(int times)
		{
			this.Logger.Verify(
				x => x.Log(
					It.IsAny<LogLevel>(),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => true),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!),
				Moq.Times.Exactly(times));

			return this.Logger;
		}

		/// <inheritdoc />
		Mock<ILogger> IVerifyConstraintsBuilder.LogWasCalledMessage(Predicate<string> predicate)
		{
			this.Logger.Verify(
				x => x.Log(
					It.IsAny<LogLevel>(),
					It.IsAny<EventId>(),
					It.Is<It.IsAnyType>((v, t) => predicate.Invoke(v.ToString())),
					It.IsAny<Exception>(),
					It.Is<Func<It.IsAnyType, Exception, string>>((v, t) => true)!));

			return this.Logger;
		}
	}
}
