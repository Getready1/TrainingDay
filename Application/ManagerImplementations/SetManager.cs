using Application.ManagerContracts;
using DataModels;
using EntityFramework.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerImplementations
{
    public class SetManager : ISetManager
    {
        private ISetRepository setRepository;

        public SetManager(ISetRepository setRepository)
        {
            this.setRepository = setRepository;
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
