namespace Extensions.Logging.Mock.UnitTests
{
	using System;
	using System.Collections.Generic;
	using FluentAssertions;
	using Microsoft.Extensions.Logging;
	using Moq;
	using NUnit.Framework;

	[TestFixture]
	public class LoggerCalledTests : TestBase
	{
		private static IEnumerable<object[]> TestData = new List<object[]>
		{
			new object[] { LogLevel.Trace },
			new object[] { LogLevel.Debug },
			new object[] { LogLevel.Information },
			new object[] { LogLevel.Warning },
			new object[] { LogLevel.Error },
			new object[] { LogLevel.Critical },
		};

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasCalled(LogLevel logLevel)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					this.Logger.LogTrace($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().TraceWasCalled();
					break;
				case LogLevel.Debug:
					this.Logger.LogDebug($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().DebugWasCalled();
					break;
				case LogLevel.Information:
					this.Logger.LogInformation($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().InformationWasCalled();
					break;
				case LogLevel.Warning:
					this.Logger.LogWarning($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().WarningWasCalled();
					break;
				case LogLevel.Error:
					this.Logger.LogError($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().ErrorWasCalled();
					break;
				case LogLevel.Critical:
					this.Logger.LogCritical($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().CriticalWasCalled();
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasCalled_Generic(LogLevel logLevel)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					this.GenericLogger.LogTrace($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().TraceWasCalled();
					break;
				case LogLevel.Debug:
					this.GenericLogger.LogDebug($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().DebugWasCalled();
					break;
				case LogLevel.Information:
					this.GenericLogger.LogInformation($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().InformationWasCalled();
					break;
				case LogLevel.Warning:
					this.GenericLogger.LogWarning($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().WarningWasCalled();
					break;
				case LogLevel.Error:
					this.GenericLogger.LogError($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().ErrorWasCalled();
					break;
				case LogLevel.Critical:
					this.GenericLogger.LogCritical($"{logLevel:G} Message");
					this.MockLogger.VerifyLog().CriticalWasCalled();
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasNotCalled(LogLevel logLevel)
		{
			Action action = null;

			switch(logLevel)
			{
				case LogLevel.Trace:
					action = () => this.MockLogger.VerifyLog().TraceWasCalled();
					break;
				case LogLevel.Debug:
					action = () => this.MockLogger.VerifyLog().DebugWasCalled();
					break;
				case LogLevel.Information:
					action = () => this.MockLogger.VerifyLog().InformationWasCalled();
					break;
				case LogLevel.Warning:
					action = () => this.MockLogger.VerifyLog().WarningWasCalled();
					break;
				case LogLevel.Error:
					action = () => this.MockLogger.VerifyLog().ErrorWasCalled();
					break;
				case LogLevel.Critical:
					action = () => this.MockLogger.VerifyLog().CriticalWasCalled();
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}
	}
}
