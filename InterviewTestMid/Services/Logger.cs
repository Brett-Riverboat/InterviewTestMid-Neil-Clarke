using System.Diagnostics;
using System.Globalization;

namespace InterviewTestMid.Services
{
    public class Logger : ILogger
    {

        public void WriteLogMessage(string LogMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(LogMessage))
                    throw new ArgumentException("Log message not provided", nameof(LogMessage));

                Debug.WriteLine(LogMessage);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WriteErrorMessage(Exception Ex)
        {
            try
            {
                if (Ex == null)
                    throw new ArgumentException("Exception not provided", nameof(Ex));

                Debug.WriteLine($"Error recieved: {Ex.Message}");
                Debug.WriteLine($"{Ex.StackTrace}");
            }
            catch (Exception)
            {
                //There could be an issue with throwing here.
                throw;
            }
        }

        public void WriteStringsasCsv(List<string?> Strings)
        {
            try
            {
                if (Strings == null)
                    throw new ArgumentException("Strings not provided", nameof(Strings));

                var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmssfff", CultureInfo.InvariantCulture);

                Debug.WriteLine($"CSVs recieved at : {timestamp}");

                for (int i = 0; i < Strings.Count; i++)
                {
                    var str = Strings[i] ?? "";
                    Debug.Write(string.Concat(str, ", "));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
