namespace Common
{
    /// <summary>
    /// Request for information, request are reads froma aggregates, request should not cause change of data.
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// The shard to send the request to.
        /// </summary>
        int Shard { get; }
    }
}