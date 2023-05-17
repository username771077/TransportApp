using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TransporortApp.Models;

namespace TransporortApp.Data.Services
{
    public class TransportTypesService : ITransportType
    {
        private readonly AppDbContext _context;
        public TransportTypesService(AppDbContext context)
        {
            _context = context;
        }
        public void Add(TransportType transportType)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TransportType> GetAll()
        {
            throw new NotImplementedException();
        }

        public TransportType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TransportType Update(int id, TransportType newTransporttype)
        {
            throw new NotImplementedException();
        }
    }
}
