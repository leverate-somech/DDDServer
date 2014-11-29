namespace Common
{
    public class SuccessCommandResult : ICommandResult
    {
        public bool Success
        {
            get { return true; }
        }
    }
}