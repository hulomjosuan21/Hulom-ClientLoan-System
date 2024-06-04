using Hulom_ClientLoan_System.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Hulom_ClientLoan_System.Handlers
{
    public class ClientHandler : IDisposable
    {
        private readonly BindingSource _source;
        private readonly hulomclientloandbEntities _context;

        public ClientHandler(BindingSource _source)
        {
            this._source = _source;
            _context = new hulomclientloandbEntities();

            _source.DataSource = _context.Clients.ToList();
        }

        public Client GetToEditClient(int _id)
        {
            return _context.Clients.FirstOrDefault(id => id.ID == _id);
        }

        public void AddClient(Client _getNewClient)
        {
            _context.Clients.Add(_getNewClient);
            _context.SaveChanges();
            _source.DataSource = _context.Clients.ToList();
        }

        public void DeleteClient(int client_ID)
        {
            Client toRemove = _context.Clients.FirstOrDefault(id => id.ID == client_ID);

            _context.Clients.Remove(toRemove);
            _context.SaveChanges();

            _source.DataSource = _context.Clients.ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
