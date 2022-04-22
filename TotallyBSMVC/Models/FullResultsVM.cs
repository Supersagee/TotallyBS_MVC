using System.Collections.Generic;
using TotallyBSMVC.Models;

namespace TotallyBSMVC.ViewModels
{
    public class FullResultsVM
    {
        public IEnumerable<Results> Results { get; set; }

        public SubResults SubResults { get; set;}

    }
}
