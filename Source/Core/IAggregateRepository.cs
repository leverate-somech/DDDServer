using System;

namespace Core
{
    /// <summary>
    /// Aggregate repository to retrieve aggregates from store. Aggregate repository is attached to shard, therefore you can only retrieve aggregates from same shard.
    /// </summary>
    public interface IAggregateRepository
    {
        /// <summary>
        /// Get an aggregate from store
        /// </summary>
        /// <param name="aggregateId">Id of the aggregate to get</param>
        T GetAggregate<T>(Guid aggregateId) where T : BaseAggregate;

        /// <summary>
        /// Try to get an aggregate from the store
        /// </summary>
        /// <typeparam name="T">Type of aggregate</typeparam>
        /// <param name="aggregateId">Id of the aggregate to get</param>
        /// <param name="aggregate">variable to hold the aggregate</param>
        /// <returns>True if was able to get the aggregate, otherwise false</returns>
        bool TryGetAggregate<T>(Guid aggregateId, out T aggregate) where T: BaseAggregate;

        /// <summary>
        /// Save an aggregate to the store.
        /// </summary>
        /// <typeparam name="T">Type of the aggregate</typeparam>
        /// <param name="aggregate">Aggregate to save</param>
        void SaveAggregate<T>(T aggregate) where T : BaseAggregate;
    }
}