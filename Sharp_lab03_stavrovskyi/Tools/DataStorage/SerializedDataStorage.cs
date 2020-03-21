using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Sharp_lab03_stavrovskyi.Managers;
using Sharp_lab03_stavrovskyi.Models;
using Sharp_lab03_stavrovskyi.Tools;

namespace Sharp_lab03_stavrovskyi.DataStorage
{
    internal class SerializedDataStorage : IDataStorage
    {
        private readonly List<Person> _users;

        internal SerializedDataStorage()
        {
            try
            {
                _users = SerializationManager.Deserialize<List<Person>>(FileFolderHelper.StorageFilePath);
            }
            catch (FileNotFoundException)
            {
                _users = new List<Person>();
                fillPeople();
            }
        }



        public bool UserExists(string name, string surname)
        {
                return _users.Exists(u => (u.Name == name && u.Surname == surname));
        }

        public Person GetUserByName(string name, string surname)
        {
            return _users.FirstOrDefault(u => (u.Name == name && u.Surname == surname));
        }

        public void AddUser(Person user)
        {
            _users.Add(user);
            SaveChanges();
        }

        public List<Person> UserList
        {
            get { return _users.ToList(); }
        }

        private void SaveChanges()
        {
            SerializationManager.Serialize(_users, FileFolderHelper.StorageFilePath);
        }

        private void fillPeople()
        {
            _users.Add(new Person("Jamar", "Jarrett", "Jaja@gmail.com", new DateTime(1979, 08, 19)));
            _users.Add(new Person("Dionne", "Teal", "Dite@aia.ua", new DateTime(1937, 06, 17)));
            _users.Add(new Person("Justina", "Alicea", "Jual@asm.ua", new DateTime(2016, 04, 12)));
            _users.Add(new Person("Nguyet", "Contreras", "Ngucon@m.m", new DateTime(1960, 01, 02)));
            _users.Add(new Person("Assunta", "Baer", "Assba@m.m", new DateTime(1931, 07, 30)));
            _users.Add(new Person("Britney", "Melvin", "lvin@lvin.com", new DateTime(1993, 11, 17)));
            _users.Add(new Person("Freida", "Hinojosa", "josa@josa.com", new DateTime(1982, 10, 28)));
            _users.Add(new Person("Caprice", "Slone", "lone@lone.com", new DateTime(2018, 06, 12)));
            _users.Add(new Person("Lou", "Keeler", "eler@eler.com", new DateTime(1964, 07, 02)));
            _users.Add(new Person("Alden", "Herndon", "ndon@ndon.com", new DateTime(1988, 03, 24)));
            _users.Add(new Person("Syreeta", "Colbert", "bert@bert.com", new DateTime(1947, 12, 04)));
            _users.Add(new Person("Dorthea", "Joy", "Joy@Joy.com", new DateTime(1997, 01, 22)));
            _users.Add(new Person("Tomeka", "Reinhardt", "ardt@ardt.com", new DateTime(1930, 08, 01)));
            _users.Add(new Person("Cortney", "Reagan", "agan@agan.com", new DateTime(1985, 02, 15)));
            _users.Add(new Person("Lashawna", "Toler", "oler@oler.com", new DateTime(2014, 12, 18)));
            _users.Add(new Person("Teodora", "Watt", "Watt@Watt.com", new DateTime(1979, 05, 08)));
            _users.Add(new Person("Sang", "Dick", "Dick@Dick.com", new DateTime(1969, 12, 30)));
            _users.Add(new Person("Aline", "Whitley", "tley@tley.com", new DateTime(2008, 11, 22)));
            _users.Add(new Person("Shemika", "Hartley", "tley@tley.com", new DateTime(1927, 02, 22)));
            _users.Add(new Person("Camila", "Tatum", "atum@atum.com", new DateTime(2013, 01, 23)));
            _users.Add(new Person("Nakia", "Mcreynolds", "Nakia@le.aj", new DateTime(2007, 01, 04)));
            _users.Add(new Person("Monserrate", "Vance", "rrate@le.aj", new DateTime(1975, 02, 04)));
            _users.Add(new Person("Aida", "Loera", "Aida@le.aj", new DateTime(1940, 12, 13)));
            _users.Add(new Person("Cherri", "Sides", "herri@le.aj", new DateTime(1969, 09, 06)));
            _users.Add(new Person("Asia", "Yu", "Asia@le.ajew", new DateTime(1961, 11, 08)));
            _users.Add(new Person("Eugenie", "Finley", "genie@le.aj", new DateTime(1983, 07, 17)));
            _users.Add(new Person("Carmel", "Lemay", "armel@le.aj", new DateTime(2020, 01, 15)));
            _users.Add(new Person("Samella", "Roush", "mella@le.aj", new DateTime(1920, 06, 06)));
            _users.Add(new Person("Christel", "Oleary", "istel@le.aj", new DateTime(1946, 04, 12)));
            _users.Add(new Person("Tania", "Duffy", "ania@le.aj", new DateTime(1966, 03, 23)));
            _users.Add(new Person("Clair", "Bethea", "Clair@le.aj", new DateTime(1928, 07, 10)));
            _users.Add(new Person("James", "Peralta", "James@le.aj", new DateTime(2010, 02, 17)));
            _users.Add(new Person("Leonia", "Paradis", "eonia@le.aj", new DateTime(1992, 11, 14)));
            _users.Add(new Person("Tatum", "Knutson", "Tatum@le.aj", new DateTime(1969, 02, 15)));
            _users.Add(new Person("Jeni", "Thames", "Jeni@le.aj", new DateTime(2004, 09, 01)));
            _users.Add(new Person("Gino", "Mccloud", "Gino@le.aj", new DateTime(1973, 10, 20)));
            _users.Add(new Person("Petrina", "Beam", ",trina@le.aj", new DateTime(2017, 11, 13)));
            _users.Add(new Person("Mathilda", "Rafferty", "hilda@le.aj", new DateTime(2006, 04, 27)));
            _users.Add(new Person("Malinda", "Randall", "alinda@le.aj", new DateTime(2016, 01, 14)));
            _users.Add(new Person("Salome", "Keating", "alome@le.aj", new DateTime(2008, 06, 05)));
            _users.Add(new Person("Marylynn", "Clapp", "ylynn@le.aj", new DateTime(1929, 10, 08)));
            _users.Add(new Person("Thomasena", "Kelso", "asena@le.aj", new DateTime(1926, 11, 18)));
            _users.Add(new Person("Raleigh", "Chong", "leigh@le.aj", new DateTime(1944, 06, 29)));
            _users.Add(new Person("Gaylene", "Dow", "ylene@le.aj", new DateTime(1986, 02, 20)));
            _users.Add(new Person("Oscar", "Thurman", "Oscar@le.aj", new DateTime(2003, 01, 28)));
            _users.Add(new Person("Melvin", "Talbert", "elvin@le.aj", new DateTime(1966, 04, 26)));
            _users.Add(new Person("Marcelo", "Forrester", "rcelo@le.aj", new DateTime(1988,06,27)));
            _users.Add(new Person("Laronda", "Monson", "ronda@le.aj", new DateTime(2004, 04, 09)));
            _users.Add(new Person("Kirstin", "Renfro", "rstin@le.aj", new DateTime(1941, 11, 13)));
            _users.Add(new Person("Linsey", "Cotter", "insey@le.aj", new DateTime(2000, 10, 26)));
            SaveChanges();
        }

    }
}
