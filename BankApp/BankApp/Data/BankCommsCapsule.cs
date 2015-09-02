using Newtonsoft.Json;
namespace BankApp
{
    public class BankCommsCapsule
    {
        string _bankURL;

        public string _login;
        public string _password;

        public BankCommsCapsule(string login, string password)
        {
            _login = login;
            _password = password;
        }

        
    }
}