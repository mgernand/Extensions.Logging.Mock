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
	public class LoggerNotCalledTests : TestBase
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
			Action action = null;

			switch(logLevel)
			{
				case LogLevel.Trace:
					this.Logger.LogTrace($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().TraceWasNotCalled();
					break;
				case LogLevel.Debug:
					this.Logger.LogDebug($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().DebugWasNotCalled();
					break;
				case LogLevel.Information:
					this.Logger.LogInformation($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().InformationWasNotCalled();
					break;
				case LogLevel.Warning:
					this.Logger.LogWarning($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().WarningWasNotCalled();
					break;
				case LogLevel.Error:
					this.Logger.LogError($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().ErrorWasNotCalled();
					break;
				case LogLevel.Critical:
					this.Logger.LogCritical($"{logLevel:G} Message");
					action = () => this.MockLogger.VerifyLog().CriticalWasNotCalled();
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasNotCalled(LogLevel logLevel)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					this.MockLogger.VerifyLog().TraceWasNotCalled();
					break;
				//case LogLevel.Debug:
				//	this.MockLogger.VerifyLog().DebugWasNotCalled();
				//	break;
				//case LogLevel.Information:
				//	this.MockLogger.VerifyLog().InformationWasNotCalled();
				//	break;
				//case LogLevel.Warning:
				//	this.MockLogger.VerifyLog().WarningWasNotCalled();
				//	break;
				//case LogLevel.Error:
				//	this.MockLogger.VerifyLog().ErrorWasNotCalled();
				//	break;
				//case LogLevel.Critical:
				//	this.MockLogger.VerifyLog().CriticalWasNotCalled();
				//	break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogWasNotCalled_Generic(LogLevel logLevel)
		{
			switch(logLevel)
			{
				case LogLevel.Trace:
					this.MockLogger.VerifyLog().TraceWasNotCalled();
					break;
				//case LogLevel.Debug:
				//	this.MockLogger.VerifyLog().DebugWasNotCalled();
				//	break;
				//case LogLevel.Information:
				//	this.MockLogger.VerifyLog().InformationWasNotCalled();
				//	break;
				//case LogLevel.Warning:
				//	this.MockLogger.VerifyLog().WarningWasNotCalled();
				//	break;
				//case LogLevel.Error:
				//	this.MockLogger.VerifyLog().ErrorWasNotCalled();
				//	break;
				//case LogLevel.Critical:
				//	this.MockLogger.VerifyLog().CriticalWasNotCalled();
				//	break;
			}
		}
	}
}
