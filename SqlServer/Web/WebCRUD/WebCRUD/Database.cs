﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace WebCRUD
{
    public class Database
    {
        static public String ConnectionString
        {
            get
            {    // get connection string with name  database from  web.config.
                return WebConfigurationManager.ConnectionStrings[@"database"].ConnectionString;
            }
        }
    }
}