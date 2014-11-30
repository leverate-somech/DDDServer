namespace Common
{
    /// <summary>
    /// The result of execute a command.
    /// </summary>
    public interface ICommandResult
    {
        bool Success { get; }
    }
}