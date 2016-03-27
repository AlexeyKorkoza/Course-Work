using System.Collections.Generic;
using System.Linq;
using Raven.Abstractions.Data;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Linq;
using Raven.Json.Linq;

namespace CourseWork.Data
{
    public class Storage : IStorage
    {
        private IDocumentStore _storeClient;
        private IDocumentStore _storeCenter;
        public void ConnectDbClient()
        {
            _storeClient = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Client"
            };
            _storeClient.Initialize();
        }
        public List<Models.Client> GetAllClients()
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                return session.Query<Models.Client>().ToList();
            }
        }
        public List<Models.Client> GetClientByDate(string date)
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                return session.Query<Models.Client>().Where(x => x.Date == date).ToList();
            }
        }
        public void DeleteClient(string id)
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                _storeClient.DatabaseCommands.Delete("clients/" + id, null);
                session.SaveChanges();
            }
        }
        public Models.Client GetClientId(string id)
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                return session.Load<Models.Client>(id);
            }
        }
        public void UpdateClientId(Models.Client clients)
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                session.Store(clients);
                session.SaveChanges();
            }
        }

        public void AddClient(Models.Client client)
        {
            ConnectDbClient();
            using (var session = _storeClient.OpenSession())
            {
                session.Store(client);
                session.SaveChanges();
            }
        }
        public void ConnectDbDirection()
        {
            _storeCenter = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Center"
            };
            _storeCenter.Initialize();
        }
        public List<Models.Direction> GetDirections()
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                return session.Query<Models.Direction>().ToList();
            }
        }
        public Models.Direction GetDirectionsDirectionName(string directionName)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                return session.Query<Models.Direction>().First(x => x.NameOfDirection == directionName);
            }
        }
        public void DeleteDirection(string id)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                _storeCenter.DatabaseCommands.Delete("directions/" + id, null);
                session.SaveChanges();
            }
        }
        public void UpdateDirection(Models.Direction direction)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                session.Store(direction);
                session.SaveChanges();
            }
        }
        public void AddDirection(Models.Direction direction)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                session.Store(direction);
                session.SaveChanges();
            }
        }
        public void DeleteService(int id)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                _storeCenter.DatabaseCommands.Delete("directions/" + id, null);
                session.SaveChanges();
            }
        }
        public void AddService(Models.Service service, int id)
        {
            ConnectDbDirection();
            using (var session = _storeCenter.OpenSession())
            {
                _storeCenter.DatabaseCommands.Patch("directions/" + id,
                        new[]
                        {  
                     new PatchRequest
                     {
                          Type = PatchCommandType.Add,
                         Name = "Services",
                        Value = RavenJObject.FromObject(service),
                        }
                        }
                       );
                session.SaveChanges();
            }
        }
     }
}