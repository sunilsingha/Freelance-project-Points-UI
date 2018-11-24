using System;

namespace PointsUI.Classes
{
    public abstract class AuditFields
    {
        public int ID { get; set; }
        public int CreatedById { get; set; }
        public int UpdatedById { get; set; }
        public int DeletedById { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public DateTime DeletedOn { get; set; }

        public string CreatedByUserName { get; set; }
        public string UpdatedByUserName { get; set; }
        public string DeletedByUserName { get; set; }
    }
}
