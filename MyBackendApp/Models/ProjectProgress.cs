namespace YourAppNamespace.Models
{
    public class ProjectProgress
    {
        public int ProjectProgressId { get; set; }
        public int ProjectId { get; set; }
        public DateTime UpdateDate { get; set; }
        public float PercentageComplete { get; set; }
    }
}