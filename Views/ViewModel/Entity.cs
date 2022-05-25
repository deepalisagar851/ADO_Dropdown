using ADO_Dropdown.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ADO_Dropdown.Views.ViewModel
{
    public class Entity
    { 
        public int Id { get; set; }

        public string Name { get; set; }
    }
}