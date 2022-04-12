using System.Collections.Generic;
namespace TotallyBSMVC.Models
{
    public class Results
    {
        public int DbId { get; set; }
        public int SessionId { get; set; }
        public int CustId { get; set; }
        public string DisplayName { get; set; }
        public int CarNumber { get; set; }
        public int FinishPosition { get; set; }
        public int StartingPosition { get; set; }
        public int FinishInterval { get; set; }
        public int LapsLed  { get; set; }
        public int BestLapNum { get; set; }
        public int BestLapTime { get; set; }
        public int AverageLap { get; set; }
        public int Incidents { get; set; }
        public int Division { get; set; }
        public string ClubShortName { get; set; }
        public int OldLicenseLevel { get; set; }
        public int NewLicenseLevel { get; set; }
        public decimal OldSafetyRating { get; set; }
        public decimal NewSafetyRating { get; set; }
        public int OldiRating { get; set; }
        public int NewiRating { get; set; }
        public int Car { get; set; }

    }
}
