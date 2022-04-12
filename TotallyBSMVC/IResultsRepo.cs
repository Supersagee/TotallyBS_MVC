using System.Collections.Generic;
using TotallyBSMVC.Models;

namespace TotallyBSMVC
{
    public interface IResultsRepo
    {
        public IEnumerable<SubResults> GetQuickResults();
        public IEnumerable<Results> GetFullResults(int sessionId);
    }
}
