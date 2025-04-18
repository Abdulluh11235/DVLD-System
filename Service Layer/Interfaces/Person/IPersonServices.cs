﻿using Domain_Layer;

namespace Service_Layer.Interfaces.Person
{
    public interface IPersonServices
    {
        int? AddPerson(IPersonModel person);
        bool DeletePerson(int id);
        IEnumerable<IPersonModel> GetAllPeople();
        IPersonModel? GetPersonById(int id);
        bool UpdatePerson(IPersonModel person);
    }
}