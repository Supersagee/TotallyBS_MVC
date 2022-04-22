using System.Collections.Generic;
using TotallyBSMVC.Models;

namespace TotallyBSMVC
{
    public interface IResultsRepo
    {
        public IEnumerable<SubResults> GetQuickResults();
        public SubResults GetQuickResult(int sessionId);
        public IEnumerable<Results> GetFullResults(int sessionId);
        public IEnumerable<Cars> GetCarNames();
        public Ratings GetRatings();
    }
}
