using Kreta.Desktop.Database;
using Kreta.Desktop.Models;
using System;
using System.Collections.Generic;

namespace Kreta.Desktop.Repos
{
    public class SchoolClassRepo : ISchoolClassRepo
    {

        public List<SchoolClass> FindAll()
        {
            return KretaDatabase.SchoolClasses;
        }
    }
}
