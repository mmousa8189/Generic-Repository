using System;

namespace Generic_Repository
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifyingDate { get; set; }
    }
}