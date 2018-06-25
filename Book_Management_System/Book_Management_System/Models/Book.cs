using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Management_System.Models
{
    class Book
    {
        private int _id;
        public int id
        {
            get
            {
                return id;
            }
            set
            {
                _id = value;
            }
        }

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _author;
        public string author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }

        private string _publisher;
        public string publisher
        {
            get
            {
                return _publisher;
            }
            set
            {
                _publisher = value;
            }
        }

        private string _isbn;
        public string isbn
        {
            get
            {
                return _isbn;
            }
            set
            {
                _isbn = value;
            }
        }

        private string _description;
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        private bool _status;
        public bool status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
    }
}
