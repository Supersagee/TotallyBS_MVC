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

        public SubResults GetQuickResult(int sessionId)
        {
            return _connection.QuerySingle<SubResults>("SELECT * FROM subsession WHERE SessionId = @sessionId;",
                new {sessionId});
        }

        public IEnumerable<Results> GetFullResults(int sessionId)
        {
            return _connection.Query<Results>("SELECT idresults, SessionId, CustId, DisplayName, CarNumber, FinishPosition, ClassPosition, StartingPosition," +
                " FinishInterval, LapsLed, LapsComplete, BestLapNum, BestLapTime, AverageLap, Incidents, Division, ClubShortname, OldLicenseLevel, NewLicenseLevel," +
                " OldSafetyRating, NewSafetyRating, OldIRating, NewIRating, results.CarId, cars.CarName FROM results " +
                " JOIN cars on results.CarId = cars.CarId WHERE SessionId = @sessionId;",
                new {sessionId});
        }

        public IEnumerable<Cars> GetCarNames()
        {
            return _connection.Query<Cars>("SELECT * FROM cars;");
        }

        public Ratings GetRatings()
        {
            return _connection.QuerySingle<Ratings>("SELECT * FROM myratings WHERE idMyRatings = 1;");
        }
    }
}
