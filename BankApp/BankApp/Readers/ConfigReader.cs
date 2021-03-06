﻿using System;
using Newtonsoft.Json;
using System.IO;

namespace BankApp
{
    public class ConfigReader
    {
        internal SingleAccountInfo[] ReadAccountsList()
        {
            string text = File.ReadAllText(@"C:\bank.json");
            SingleAccountInfo[] accounts = JsonConvert.DeserializeObject<SingleAccountInfo[]>(text);

            return accounts;
        }

        internal BankCommsCapsule ReadAccountInfo(SingleAccountInfo info)
        {

            BankCommsCapsule commsCapsule = new BankCommsCapsule(info.login, info.password);
            //TODO bank url creation
            return commsCapsule;
        }
    }


}