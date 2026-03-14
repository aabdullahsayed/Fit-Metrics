namespace FitnessTracker.Models;

public class Report
{
   public float Weight { get; set; }
   public float Waist { get; set; }
   public float Wrist { get; set;}
   public float Hip { get; set;}
   public float Chest { get; set; }
   public float Forearm { get; set; }
   public string StressIssue { get; set; }
   public DateOnly date { get; set; }
}