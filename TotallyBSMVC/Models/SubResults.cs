using System;

namespace TotallyBSMVC.Models
{
    public class SubResults
    {
        public int SessionId { get; set; }
        public string SeriesName { get; set; }
        public DateTime StartTime { get; set; }
        public string SeasonShortName { get; set; }
        public string EventTypeName { get; set; }
        public string LicenseCategory { get; set; }
        public string TrackName { get; set; }
        public int StrengthOfField { get; set; }
    }
}
