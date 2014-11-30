namespace Common
{
    /// <summary>
    /// General error command result
    /// </summary>
    public class ErrorCommandResult : ICommandResult
    {        
        public ErrorCommandResult(string reason = "")
        {
            Reason = reason;
        }

        public bool Success { get { return false; } }

        public string Reason { get; private set; }
    }
}