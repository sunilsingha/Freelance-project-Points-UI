using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace PointsUI.Classes
{
    public abstract class  AuditTransaction : AuditFields
    {
        public bool IsCreatedByUser { get; set; }
        public bool IsCreatedByAdmin { get; set; }
        public bool IsApprovedByAdmin { get; set; }
        public int ApprovedByUserId { get; set; }
        public string ApprovedUserName { get; set; }
        public DateTime ApprovedOn { get; set; }
    }
}
