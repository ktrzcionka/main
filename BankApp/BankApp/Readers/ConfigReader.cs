using System;
using Newtonsoft.Json;
using System.IO;

namespace BankApp
{
    public class ConfigReader
    {
        internal SingleAccountInfo ReadAccountsList()
        {
            //JObject jObject = JObject.Parse(File.ReadAllText(@"c:\bank.json"));
            string text = File.ReadAllText(@"C:\bank.json");
            SingleAccountInfo[] accounts;

            //foreach (BankInfo account in accounts)
            //{
                
            //}

            var bankInfo = JsonConvert.DeserializeObject<SingleAccountInfo>(text);
            return bankInfo;
        }

        internal BankCommsCapsule ReadAccountInfo(SingleAccountInfo info)
        {
            throw new NotImplementedException();
        }
    }


}