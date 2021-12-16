# Extensions.Logging.Mock
A unit-testing extension for verifing a logger mock.

## Configuration

To configure the intrastructure you just have to call **```AddMock()```** on the **```ILoggingBuilder```**
instance. when using **```AddLogging()```**. This will add a custom **```ILoggerProvider```** which will
return the underlying instance of the configured **```Mock<ILogger>```** instance.

```C#
[TestFixture]
public class LoggerTests
{
	public Mock<ILogger> MockLogger { get; set; }
	public ILogger Logger { get; set; }
	public ILogger<TestClass> GenericLogger { get; set; }

	[SetUp]
	public void SetUp()
	{
		this.MockLogger = new Mock<ILogger>();

		IServiceCollection services = new ServiceCollection();

		services.AddLogging(builder =>
		{
			builder.SetMinimumLevel(LogLevel.Trace);
			builder.AddConsole();
			builder.AddMock(this.mockLogger);
		});

		IServiceProvider serviceProvider = services.BuildServiceProvider();

		ILoggerFactory loggerFactory = serviceProvider.GetRequiredService<ILoggerFactory>();
		this.Logger = loggerFactory.CreateLogger("TestLogger");
		this.GenericLogger = loggerFactory.CreateLogger<TestClass>();
	}
}
```

## Usage

To verify that the desired log methods was called just verify the mock instance using 
**```VerifyLog().DebugWasCalled()```**.

```C#
[Test]
public void ShouldVerifyDebugCalled()
{
	this.Logger.LogDebug("Log Message");
	this.MockLogger.VerifyLog().DebugWasCalled();
}
```

To verify that the desired log methods message output equals a desired values just verify
the mock instance using **```VerifyLog().DebugWasCalled().MessageEquals("Log Message")```**.

```C#
[Test]
public void ShouldVerifyDebugMessage()
{
	this.Logger.LogDebug("Log Message");
	this.MockLogger.VerifyLog().DebugWasCalled().MessageEquals("Log Message");
}
```

To verify that the desired log method was called a certain amount of times just verify the mock instance
using **```VerifyLog().DebugWasCalled().Times(2)```**.

```C#
[Test]
public void ShouldVerifyDebugCalledTimes()
{
	this.Logger.LogDebug("Log Message");
	this.Logger.LogDebug("Log Message");
	this.MockLogger.VerifyLog().DebugWasCalled().Times(2);
}
```
