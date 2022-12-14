using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCrudOperations
{
    public class Connection
    {
        public static string GetConnect
        {
            get { return "Data Source=HOME-PC\\SQLEXPRESS;Integrated Security=True; Database=Northwind;"; }
        }
    }
}