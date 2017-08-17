using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyData.Models
{
    public class PersonalContact
    {
        private string name;
        private string workAddress;
        private string workPhone;
        private string mobilePhone;
        private string email;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string WorkAddress
        {
            get
            {
                return workAddress;
            }

            set
            {
                workAddress = value;
            }
        }

        public string WorkPhone
        {
            get
            {
                return workPhone;
            }

            set
            {
                workPhone = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return mobilePhone;
            }

            set
            {
                mobilePhone = value;
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
    }
}