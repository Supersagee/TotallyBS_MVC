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
        public int ClassPosition { get; set; }
        public int StartingPosition { get; set; }
        public string FinishInterval { get; set; }
        public int LapsLed  { get; set; }
        public int LapsComplete { get; set; }
        public string BestLapNum { get; set; }
        public string BestLapTime { get; set; }
        public string AverageLap { get; set; }
        public int Incidents { get; set; }
        public int Division { get; set; }
        public string ClubShortName { get; set; }
        public string OldLicenseLevel { get; set; }
        public string NewLicenseLevel { get; set; }
        public decimal OldSafetyRating { get; set; }
        public decimal NewSafetyRating { get; set; }
        public int OldiRating { get; set; }
        public int NewiRating { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }

    }
}
