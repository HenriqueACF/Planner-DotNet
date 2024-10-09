using Journey.Communication.Responses;
using Journey.Infrastructure;

namespace Journey.Application.UseCases.Trips.GetById;

public class GetTripByIdUseCase
{
    public ResponseTripJson Execute(Guid id)
    {
        var dbContext = new JourneyDbContext();
        var trip= dbContext.Trips.FirstOrDefault(trip => trip.Id == id);
    }
}