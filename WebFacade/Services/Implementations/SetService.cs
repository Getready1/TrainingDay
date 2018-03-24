using Application.ManagerContracts;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using WebFacade.Services.Contracts;

namespace WebFacade.Services.Implementations
{
    public class SetService : ISetService
    {
        private ISetManager setManager;

        public SetService(ISetManager setManager)
        {
            this.setManager = setManager;
        }

        public void Add(Set set)
        {
            throw new NotImplementedException();
        }

        public void Delete(Set set)
        {
            throw new NotImplementedException();
        }

        public List<Set> GetAll()
        {
            throw new NotImplementedException();
        }

        public Training GetById(Set id)
        {
            throw new NotImplementedException();
        }

        public void Update(Set set)
        {
            throw new NotImplementedException();
        }
    }
}
