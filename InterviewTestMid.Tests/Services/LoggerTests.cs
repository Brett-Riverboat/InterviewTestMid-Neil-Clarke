using InterviewTestMid.Services;
using Moq;

namespace InterviewTestMid.Tests.Services
{
    public class LoggerTests
    {
        private readonly Mock<ILogger> _mockLogger;
        private readonly Logger _logger;

        public LoggerTests()
        {
            _mockLogger = new Mock<ILogger>();
            _logger = new Logger();
        }

        [Fact]
        public void WriteLogMessage_ValidMessage_WritesToDebug()
        {
            string logMessage = "This is a test message";

            _logger.WriteLogMessage(logMessage);
        }

        [Fact]
        public void WriteLogMessage_NullOrEmptyMessage_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _logger.WriteLogMessage(null));
            Assert.Throws<ArgumentException>(() => _logger.WriteLogMessage(""));
        }

        [Fact]
        public void WriteErrorMessage_ValidException_WritesToDebug()
        {
            var ex = new Exception("This is a test exception");

            _logger.WriteErrorMessage(ex);
        }

        [Fact]
        public void WriteErrorMessage_NullException_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _logger.WriteErrorMessage(null));
        }

        [Fact]
        public void WriteStringsasCsv_ValidStrings_WritesToDebug()
        {
            var strings = new List<string?> { "Test1", "Test2", "Test3" };

            _logger.WriteStringsasCsv(strings);
        }

        [Fact]
        public void WriteStringsasCsv_StringsContainingNull_WritesEmptyStringToDebug()
        {
            var strings = new List<string?> { "Test1", null, "Test3" };

            _logger.WriteStringsasCsv(strings);
        }

        [Fact]
        public void WriteStringsasCsv_NullStrings_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => _logger.WriteStringsasCsv(null));
        }

        [Fact]
        public void WriteStringsasCsv_EmptyList_WritesEmptyCsv()
        {
            var strings = new List<string?>();

            _logger.WriteStringsasCsv(strings);
        }
    }
}