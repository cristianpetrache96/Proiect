using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Proiect_TP.DBContext
{
    public class DbInitializer:DropCreateDatabaseIfModelChanges<Context>
    {
    }
}