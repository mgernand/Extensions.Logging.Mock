namespace Extensions.Logging.Mock.UnitTests
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Microsoft.Extensions.Logging;
	using Microsoft.Extensions.Logging.Mock;
	using Moq;
	using NUnit.Framework;

	[TestFixture]
	public class LoggerCalledTimesTests : TestBase
	{
		private static IEnumerable<object[]> TestData = new List<object[]>
		{
			new object[] { LogLevel.Trace, 2 },
			new object[] { LogLevel.Debug, 2 },
			new object[] { LogLevel.Information, 2 },
			new object[] { LogLevel.Warning, 2 },
			new object[] { LogLevel.Error, 2 },
			new object[] { LogLevel.Critical, 2 },
		};

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasCalledTimes(LogLevel logLevel, int times)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					times.Times(i => this.Logger.LogTrace($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().TraceWasCalled().Times(times);
					break;
				case LogLevel.Debug:
					times.Times(i => this.Logger.LogDebug($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().DebugWasCalled().Times(times);
					break;
				case LogLevel.Information:
					times.Times(i => this.Logger.LogInformation($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().InformationWasCalled().Times(times);
					break;
				case LogLevel.Warning:
					times.Times(i => this.Logger.LogWarning($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().WarningWasCalled().Times(times);
					break;
				case LogLevel.Error:
					times.Times(i => this.Logger.LogError($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().ErrorWasCalled().Times(times);
					break;
				case LogLevel.Critical:
					times.Times(i => this.Logger.LogCritical($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().CriticalWasCalled().Times(times);
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasCalledTimes_Generic(LogLevel logLevel, int times)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					times.Times(i => this.GenericLogger.LogTrace($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().TraceWasCalled().Times(times);
					break;
				case LogLevel.Debug:
					times.Times(i => this.GenericLogger.LogDebug($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().DebugWasCalled().Times(times);
					break;
				case LogLevel.Information:
					times.Times(i => this.GenericLogger.LogInformation($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().InformationWasCalled().Times(times);
					break;
				case LogLevel.Warning:
					times.Times(i => this.GenericLogger.LogWarning($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().WarningWasCalled().Times(times);
					break;
				case LogLevel.Error:
					times.Times(i => this.GenericLogger.LogError($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().ErrorWasCalled().Times(times);
					break;
				case LogLevel.Critical:
					times.Times(i => this.GenericLogger.LogCritical($"{logLevel:G} Message {i}"));
					this.MockLogger.VerifyLog().CriticalWasCalled().Times(times);
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasNotCalledTimes(LogLevel logLevel, int times)
		{
			Action action = null!;
			int expected = times + 1;

			switch(logLevel)
			{
				case LogLevel.Trace:
					times.Times(i => this.Logger.LogTrace($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().TraceWasCalled().Times(expected);
					break;
				case LogLevel.Debug:
					times.Times(i => this.Logger.LogDebug($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().DebugWasCalled().Times(expected);
					break;
				case LogLevel.Information:
					times.Times(i => this.Logger.LogInformation($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().InformationWasCalled().Times(expected);
					break;
				case LogLevel.Warning:
					times.Times(i => this.Logger.LogWarning($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().WarningWasCalled().Times(expected);
					break;
				case LogLevel.Error:
					times.Times(i => this.Logger.LogError($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().ErrorWasCalled().Times(expected);
					break;
				case LogLevel.Critical:
					times.Times(i => this.Logger.LogCritical($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().CriticalWasCalled().Times(expected);
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasNotCalledTimes_Generic(LogLevel logLevel, int times)
		{
			Action action = null!;
			int expected = times + 1;

			switch(logLevel)
			{
				case LogLevel.Trace:
					times.Times(i => this.GenericLogger.LogTrace($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().TraceWasCalled().Times(expected);
					break;
				case LogLevel.Debug:
					times.Times(i => this.GenericLogger.LogDebug($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().DebugWasCalled().Times(expected);
					break;
				case LogLevel.Information:
					times.Times(i => this.GenericLogger.LogInformation($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().InformationWasCalled().Times(expected);
					break;
				case LogLevel.Warning:
					times.Times(i => this.GenericLogger.LogWarning($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().WarningWasCalled().Times(expected);
					break;
				case LogLevel.Error:
					times.Times(i => this.GenericLogger.LogError($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().ErrorWasCalled().Times(expected);
					break;
				case LogLevel.Critical:
					times.Times(i => this.GenericLogger.LogCritical($"{logLevel:G} Message {i}"));
					action = () => this.MockLogger.VerifyLog().CriticalWasCalled().Times(expected);
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}
	}
}
