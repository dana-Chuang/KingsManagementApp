namespace DataLayer.Models
{
    public class AdminStatusRequest
    {
        public int Id { get; set; }
        public bool OriginalStatus { get; set; }
        public string UpdatedBy { get; set; }
    }
}
