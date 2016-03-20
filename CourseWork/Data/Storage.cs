using System.Collections.Generic;
using System.Linq;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Linq;

namespace CourseWork.Data
{
    public class Storage : IStorage
    {
        private IDocumentStore _store;
        private IDocumentStore store;
        public void ConnectDbClient()
        {
            _store = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Client"
            };
            _store.Initialize();
        }
        public List<Models.Client> GetAllClients()
        {
            ConnectDbClient();
            using (var session = _store.OpenSession())
            {
                return session.Query<Models.Client>().ToList();
            }
        }
        public List<Models.Client> GetClientByDate(string date)
        {
            ConnectDbClient();
            using (var session = _store.OpenSession())
            {
                return session.Query<Models.Client>().Where(x => x.Date == date).ToList();
            }
        }
        public void DeleteClient(int id)
        {
            ConnectDbClient();
            using (var session = _store.OpenSession())
            {
                _store.DatabaseCommands.Delete("clients/" + id, null);
                session.SaveChanges();
            }
        }
        public Models.Client GetClientId(string id)
        {
            ConnectDbClient();
            using (var session = _store.OpenSession())
            {
                return session.Load<Models.Client>(id);
            }
        }
        public void UpdateClientId(Models.Client clients)
        {
            ConnectDbClient();
            using (var session = _store.OpenSession())
            {
                session.Store(clients);
                session.SaveChanges();
            }
        }
        public void ConnectDbDirection()
        {
            store = new DocumentStore
            {
                Url = "http://localhost:8080/",
                DefaultDatabase = "Center"
            };
            store.Initialize();
        }
        public List<Models.Direction> GetDirections()
        {
            ConnectDbDirection();
            using (var session = store.OpenSession())
            {
                return session.Query<Data.Models.Direction>().ToList();
            }
        }
        public List<Models.Direction> GetDirectionsDirectionName(string directionName)
        {
            ConnectDbDirection();
            using (var session = store.OpenSession())
            {
                return session.Query<Models.Direction>().Where(x => x.NameOfDirection == directionName).ToList();
            }
        }
        public void DeleteDirection(int id)
        {
            ConnectDbDirection();
            using (var session = store.OpenSession())
            {
                store.DatabaseCommands.Delete("directions/" + id, null);
                session.SaveChanges();
            }
        }
        public void UpdateDirection(List<Models.Direction> direction)
        {
          ConnectDbDirection();
          using (var session = store.OpenSession())
          {
              session.Store(direction);
              session.SaveChanges();
          }
        }
        public List<Models.Direction> GetDirectionsDescription(string description)
        {
            ConnectDbDirection();
            using (var session = store.OpenSession())
            {
                return session.Query<Models.Direction>().Where(x => x.NameOfDirection == description).ToList();
            }
        }
    }
}