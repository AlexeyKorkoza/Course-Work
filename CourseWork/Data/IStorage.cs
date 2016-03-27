using System.Collections.Generic;

namespace CourseWork.Data
{
    public interface IStorage
    {
        List<Models.Client> GetAllClients();
        List<Models.Client> GetClientByDate(string date);
        void DeleteClient(string id);
        void UpdateClientId(Models.Client clients);
        void AddClient(Models.Client client);
        Models.Client GetClientId(string id);
        List<Models.Direction> GetDirections();
        Models.Direction GetDirectionsDirectionName(string directionName);
        void DeleteDirection(string id);
        void UpdateDirection(Models.Direction direction);
        void AddDirection(Models.Direction direction);
        void DeleteService(int id);
        void AddService(Models.Service service, int id);
       }
}
