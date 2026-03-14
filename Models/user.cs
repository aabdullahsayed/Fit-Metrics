namespace Fitness_Tracker.Models;

public class user
{
    public string name { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public int height { get; set; }
    public string MedicalIssue { get; set;}
    public DateOnly ProgramStart { get; set; }
    public DateOnly ProgramEnd { get; set; }
    public string DietType { get; set; }
    public int BMR { get; set; }
    public int TotalCals { get; set; }
    
}