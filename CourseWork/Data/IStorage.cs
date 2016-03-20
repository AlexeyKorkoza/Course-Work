using System.Collections.Generic;

namespace CourseWork.Data
{
    public interface IStorage
    {
        List<Models.Client> GetAllClients();
        List<Models.Client> GetClientByDate(string date);
        void DeleteClient(int id);
        void UpdateClientId(Models.Client clients);
        Models.Client GetClientId(string id);
        List<Models.Direction> GetDirections();
        List<Models.Direction> GetDirectionsDirectionName(string directionName);
        void DeleteDirection(int id);
        void UpdateDirection(List<Models.Direction> direction);
        List<Models.Direction> GetDirectionsDescription(string description);
    }
}
