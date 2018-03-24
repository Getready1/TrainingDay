using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;

namespace WebFacade.Services.Contracts
{
    public interface ISetService
    {
        List<Set> GetAll();
        void Add(Set set);
        void Delete(Set set);
        void Update(Set set);
        Training GetById(Set id);
    }
}
