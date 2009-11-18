﻿namespace NCommon.Data.EntityFramework.Tests
{
    public class OrderOrderItemsStrategy : IFetchingStrategy<Order, EFRepositoryTests>
    {
        #region Implementation of IFetchingStrategy<Order,NHUnitOfWorkTests>
        ///<summary>
        /// Instructs the instance to define the fetching strategy on the repository instance.
        ///</summary>
        ///<param name="repository"></param>
        public void Define(IRepository<Order> repository)
        {
            repository.With(x => x.OrderItems);
        }
        #endregion
    }
}