
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PINF.Model.Model
{
    public class User : IModelBase
    {
        private string firstName;
        private string lastName;
        private string email;
        private string password;
        private byte[] photo;
        private UserRole role;
        //za registraciju ako bude trebalo
        //za sad uvek true
        private bool activated;
       

        public int Id { get; set; }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public byte[] Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
        
        public int RoleId { get; set; }
        public UserRole Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public bool Activated
        {
            get
            {
                return true;
                //return activated;
            }

            set
            {
                activated = value;
            }
        }

        
    }
}

