using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ManagerContracts
{
    public interface ISetManager
    {
        List<Set> GetAll();
        void Add(Set set);
        void Delete(Set set);
        void Update(Set set);
        Training GetById(Set id);
    }
}
