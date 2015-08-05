using System;

namespace BankApp
{
    internal class AccountInfoRequestFactory
    {
        internal BankCommsCapsule CreateBankCommunicationsCapsule(SingleAccountInfo info)
        {
            ConfigReader configReader = new ConfigReader();

            BankCommsCapsule capsule = configReader.ReadAccountInfo(info);

            return capsule;
        }
    }

}