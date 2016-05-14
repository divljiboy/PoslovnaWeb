
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class KorisnikUloga : IModelBase
    {
        public const string ADMIN = "ADMIN";

        private string role;
        private string about;

        public int Id { get; set; }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public string About
        {
            get { return about; }
            set { about = value; }
        }
    }
}
