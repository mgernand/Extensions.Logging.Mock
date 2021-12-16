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
	public class LoggerCalledMessageTests : TestBase
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
		public void ShouldVerifyLogMessage(LogLevel logLevel)
		{
			string message = $"{logLevel:G} Message";

			switch(logLevel)
			{
				case LogLevel.Trace:
					this.Logger.LogTrace(message);
					this.MockLogger.VerifyLog().TraceWasCalled().MessageEquals(message);
					break;
				case LogLevel.Debug:
					this.Logger.LogDebug(message);
					this.MockLogger.VerifyLog().DebugWasCalled().MessageEquals(message);
					break;
				case LogLevel.Information:
					this.Logger.LogInformation(message);
					this.MockLogger.VerifyLog().InformationWasCalled().MessageEquals(message);
					break;
				case LogLevel.Warning:
					this.Logger.LogWarning(message);
					this.MockLogger.VerifyLog().WarningWasCalled().MessageEquals(message);
					break;
				case LogLevel.Error:
					this.Logger.LogError(message);
					this.MockLogger.VerifyLog().ErrorWasCalled().MessageEquals(message);
					break;
				case LogLevel.Critical:
					this.Logger.LogCritical(message);
					this.MockLogger.VerifyLog().CriticalWasCalled().MessageEquals(message);
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogMessage_Generic(LogLevel logLevel)
		{
			string message = $"{logLevel:G} Message";

			switch(logLevel)
			{
				case LogLevel.Trace:
					this.GenericLogger.LogTrace(message);
					this.MockLogger.VerifyLog().TraceWasCalled().MessageEquals(message);
					break;
				case LogLevel.Debug:
					this.GenericLogger.LogDebug(message);
					this.MockLogger.VerifyLog().DebugWasCalled().MessageEquals(message);
					break;
				case LogLevel.Information:
					this.GenericLogger.LogInformation(message);
					this.MockLogger.VerifyLog().InformationWasCalled().MessageEquals(message);
					break;
				case LogLevel.Warning:
					this.GenericLogger.LogWarning(message);
					this.MockLogger.VerifyLog().WarningWasCalled().MessageEquals(message);
					break;
				case LogLevel.Error:
					this.GenericLogger.LogError(message);
					this.MockLogger.VerifyLog().ErrorWasCalled().MessageEquals(message);
					break;
				case LogLevel.Critical:
					this.GenericLogger.LogCritical(message);
					this.MockLogger.VerifyLog().CriticalWasCalled().MessageEquals(message);
					break;
			}
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogMessageDifferent(LogLevel logLevel)
		{
			Action action = null!;
			string message = $"{logLevel:G} Message";
			string wrongAssertMessage = $"{logLevel:G} Message WRONG";

			switch(logLevel)
			{
				case LogLevel.Trace:
					this.Logger.LogTrace(message);
					action = () => this.MockLogger.VerifyLog().TraceWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Debug:
					this.Logger.LogDebug(message);
					action = () => this.MockLogger.VerifyLog().DebugWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Information:
					this.Logger.LogInformation(message);
					action = () => this.MockLogger.VerifyLog().InformationWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Warning:
					this.Logger.LogWarning(message);
					action = () => this.MockLogger.VerifyLog().WarningWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Error:
					this.Logger.LogError(message);
					action = () => this.MockLogger.VerifyLog().ErrorWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Critical:
					this.Logger.LogCritical(message);
					action = () => this.MockLogger.VerifyLog().CriticalWasCalled().MessageEquals(wrongAssertMessage);
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}

		[Test]
		[TestCaseSource(nameof(TestData))]
		public void ShouldVerifyLogMessageDifferent_Generic(LogLevel logLevel)
		{
			Action action = null!;
			string message = $"{logLevel:G} Message";
			string wrongAssertMessage = $"{logLevel:G} Message WRONG";

			switch(logLevel)
			{
				case LogLevel.Trace:
					this.GenericLogger.LogTrace(message);
					action = () => this.MockLogger.VerifyLog().TraceWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Debug:
					this.GenericLogger.LogDebug(message);
					action = () => this.MockLogger.VerifyLog().DebugWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Information:
					this.GenericLogger.LogInformation(message);
					action = () => this.MockLogger.VerifyLog().InformationWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Warning:
					this.GenericLogger.LogWarning(message);
					action = () => this.MockLogger.VerifyLog().WarningWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Error:
					this.GenericLogger.LogError(message);
					action = () => this.MockLogger.VerifyLog().ErrorWasCalled().MessageEquals(wrongAssertMessage);
					break;
				case LogLevel.Critical:
					this.GenericLogger.LogCritical(message);
					action = () => this.MockLogger.VerifyLog().CriticalWasCalled().MessageEquals(wrongAssertMessage);
					break;
			}

			action.Should().ThrowExactly<MockException>();
		}
	}
}
