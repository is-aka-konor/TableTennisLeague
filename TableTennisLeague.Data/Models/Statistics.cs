namespace TableTennisLeague.Data.Model
{
    public class Statistics
    {
        public int Id { get; set; }
        
        public int Won { get; set; }
        public int WonOverTime { get; set; }
        public int Lost { get; set; }
        public int LostOverTime { get; set; }
    }
}