namespace Common
{
    /// <summary>
    /// General Success command
    /// </summary>
    public class SuccessCommandResult : ICommandResult
    {
        public bool Success
        {
            get { return true; }
        }
    }
}