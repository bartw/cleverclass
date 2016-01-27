namespace CleverClass.Domain.Business.Report.Entity
{
    public class TestScore
    {
        public int Id { get; set; }
        public decimal Score { get; set ; }
        
        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
    }
}
