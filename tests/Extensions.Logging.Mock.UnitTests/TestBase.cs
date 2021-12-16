namespace Extensions.Logging.Mock.UnitTests
{
	using System;
	using JetBrains.Annotations;
	using Microsoft.Extensions.DependencyInjection;
	using Microsoft.Extensions.Logging;
	using Moq;
	using NUnit.Framework;

	[PublicAPI]
	public abstract class TestBase
	{
		protected Mock<ILogger> MockLogger { get; private set; }

		protected ILogger Logger { get; private set; }

		protected ILogger<TestClass> GenericLogger { get; private set; }

		[SetUp]
		public void SetUp()
		{
			this.MockLogger = new Mock<ILogger>();

			IServiceProvider serviceProvider = BuildServiceProvider(services =>
			{
				services.AddLogging(builder =>
				{
					builder.AddMock(this.MockLogger);
				});
			});

			ILoggerFactory loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
			this.Logger = loggerFactory.CreateLogger("TestLogger");
			this.GenericLogger = loggerFactory.CreateLogger<TestClass>();
		}

		protected static IServiceProvider BuildServiceProvider(Action<IServiceCollection> configure)
		{
			IServiceCollection services = new ServiceCollection();

			services.AddLogging(builder =>
			{
				builder.SetMinimumLevel(LogLevel.Trace);
				builder.AddConsole();
			});

			configure(services);

			return services.BuildServiceProvider();
		}
	}
}
