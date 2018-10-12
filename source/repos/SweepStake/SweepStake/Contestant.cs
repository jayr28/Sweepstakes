using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStake
{

    public class Contestant

    {
        public void GetContestant()
        {

        }
        
        private string _firstName;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        private string _emailAddress;

        public string EmailAddress
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                _emailAddress = value;
            }
        }

        private string _registrationNumber;

        public string registrationNumber
        {
            get
            {
                return _registrationNumber;
            }
            set
            {
                _registrationNumber = value;
            }
        }
        public Contestant()
        {
            _firstName = UserInput.GetInput("Please Enter Contestant's First Name:  ");
            _lastName = UserInput.GetInput("Please Enter Contestant's Last Name:  ");
            _emailAddress = UserInput.GetInput("Please Enter Contestant's Email Address:");
          //  _registrationNumber = "";
        
            generateRegistrationNumber();
        }
        private void generateRegistrationNumber()

        {

            Random rnd = new Random();
            int generateRnd = rnd.Next(1, 100000);

            _registrationNumber = generateRnd.ToString();

        }
    }
}
