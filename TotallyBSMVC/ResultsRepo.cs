using System.Collections.Generic;
using System.Data;
using Dapper;
using TotallyBSMVC.Models;

namespace TotallyBSMVC
{
    public class ResultsRepo : IResultsRepo
    {
        private readonly IDbConnection _connection;

        public ResultsRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<SubResults> GetQuickResults()
        {
            return _connection.Query<SubResults>("SELECT * FROM subsession;");
        }

        public IEnumerable<Results> GetFullResults(int sessionId)
        {
            return _connection.Query<Results>("SELECT * FROM results WHERE SessionId = @SessionId;",
                new { SessionId = sessionId });
        }
    }
}
