using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class AccountManager
    {
        internal SingleAccountInfo[] AllBankAccounts()
        {
           ConfigReader reader = new ConfigReader();
            return reader.ReadAccountsList();

        }

        public SingleAccountInfo ChooseAccount(string selectedAccount, SingleAccountInfo[] allBanksInfo)
        {
            SingleAccountInfo selectedAccountInfo = new SingleAccountInfo();

            foreach (var bankInfo in allBanksInfo)
            {
                if (bankInfo.bankName == selectedAccount)
                    selectedAccountInfo = bankInfo;
            }

            Console.WriteLine("Chosen account: {0}", selectedAccountInfo.bankName);
            return selectedAccountInfo;

        }

        internal BankAccountDetails GiveAccountDetails(SingleAccountInfo selectedAccountInfo)
        {
            WebRequestComms sComms = new WebRequestComms();
            CommunicationModule comms = new CommunicationModule(sComms);

            return comms.GiveAccountDetails(selectedAccountInfo);

        }
    }
}
