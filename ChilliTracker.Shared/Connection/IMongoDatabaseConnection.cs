﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChilliTracker.Shared.Connection
{
    public interface IMongoDatabaseConnection
    {
        IMongoDatabase GetDatabase(string databaseName = "");
    }
}
