using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Models
{
    class User
    {
        private int _id;

        public int id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        private string _username;

        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        private string _passward;

        public string passward
        {
            get
            {
                return _passward;
            }
            set
            {
                _passward = value;
            }
        }

        private string _email;

        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        private string _phone;

        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        

        private bool authority;
    }
}
