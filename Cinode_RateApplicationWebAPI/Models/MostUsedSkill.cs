namespace Cinode_RateApplicationWebAPI.Models
{
    public class MostUsedSkill
    {
        public int Id { get; set; }
        public double AverageRating { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
    }
}
