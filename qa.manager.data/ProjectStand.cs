namespace qa.manager.models
{
    public class ProjectStand
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int StandId { get; set; }
        public Project Project { get; set; }
        public Stand Stand { get; set; }
    }
}
