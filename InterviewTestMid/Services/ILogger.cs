
namespace InterviewTestMid.Services
{
    public interface ILogger
    {
        void WriteErrorMessage(Exception Ex);
        void WriteLogMessage(string LogMessage);
        void WriteStringsasCsv(List<string?> Strings);
    }
}