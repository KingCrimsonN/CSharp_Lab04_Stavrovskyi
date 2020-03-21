using System.Collections.Generic;
using Sharp_lab03_stavrovskyi.Models;

namespace Sharp_lab03_stavrovskyi.DataStorage
{
    internal interface IDataStorage
    {
        bool UserExists(string name, string surname);

        Person GetUserByName(string name, string surname);

        void AddUser(Person user);

        List<Person> UserList { get; }
    }
}
