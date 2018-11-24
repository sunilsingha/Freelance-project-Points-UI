using System.Drawing;

namespace PointsUI.Classes
{
    public class Contractor: AuditTransaction
    {
        public string ContractorNo { get; set; }
        public string Name { get; set; }
        public string MobileNumber { get; set; }
        public string Address { get; set; }
        public string IdType { get; set; }
        public Image IdProof { get; set; }
        public int SupervisorId { get; set; }
        public string SupervisorName { get; set; }
        public string Status { get; set; }
        public byte[] ImageFileDataInBytes { get; set; }
        public string ImageFileName { get; set; }
        public string ImageFileType { get; set; }
        public string PhoneNumber { get; set; }
        public string ContractNumber { get; set; }
        public string ImageBase64 { get; set; }
    }
}
