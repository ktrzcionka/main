using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    class ApplicationManager
    {
        public UIDisplayer uiDisp = new UIDisplayer();
        public SingleAccountInfo[] allBanksInfo;

        public void Initialise()
        {
            AccountManager accountManager = new AccountManager();
            allBanksInfo = accountManager.AllBankAccounts();

            foreach (var bankInfo in allBanksInfo)
            {
                uiDisp.DisplayBankAccounts(bankInfo);
            }

            string selectedAccount = uiDisp.ChooseAccount();
            SingleAccountInfo chosenAccount = accountManager.ChooseAccount(selectedAccount, allBanksInfo);
            accountManager.GiveAccountDetails(chosenAccount);

        }




        public void BuildUI()
        {
            uiDisp.BuildStartScreen();

        }


    }
}
