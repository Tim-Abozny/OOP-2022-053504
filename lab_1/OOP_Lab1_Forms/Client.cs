﻿
namespace OOP_Lab1_Forms
{
    class Client
    {
        private string _clientName;

        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }

        private string _clientSurname;

        public string ClientSurname
        {
            get { return _clientSurname; }
            set { _clientSurname = value; }
        }

        private int _clientPIN;

        public int ClientPIN
        {
            get { return _clientPIN; }
            set { _clientPIN = value; }
        }

        private string _clientAccLogin;

        public string ClientLogin
        {
            get { return _clientAccLogin; }
            set { _clientAccLogin = value; }
        }
        private int _clientID;

        public int ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }


        public Client() { }

        public void CreditRequsts(int id, double wantCash, int creditTime)
        {
            FileOperations.sendCreditClientRequest(id, wantCash, creditTime);
        }
        public void InstallmentsRequsts()
        {

        }
        public void SalaryRequsts()
        {

        }
    }
}
