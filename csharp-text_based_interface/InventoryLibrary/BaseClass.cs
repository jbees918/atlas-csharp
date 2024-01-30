using System;

namespace InventoryLibrary
{
    /// <summary> 
    /// BaseClass class 
    /// </summary>
    public class BaseClass
    {
        /// <summary> 
        /// unique id for BaseClass 
        /// </summary>
        public string Id { get; }

        /// <summary> 
        /// Timestamp for when the BaseClass was created 
        /// </summary>
        public DateTime CreatedAt { get; }

        /// <summary> 
        /// Timestamp for when BaseClass was last updated 
        /// </summary>
        public DateTime UpdatedAt { get; }

        /// <summary> 
        /// Constructor for BaseClass 
        /// </summary>
        public BaseClass()
        {
            this.Id = Guid.NewGuid().ToString();
            DateTime now = DateTime.Now;
            this.CreatedAt = now;
            this.UpdatedAt = now;
        }
    }
}
