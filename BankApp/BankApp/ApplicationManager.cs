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

        public void Initialise()
        {
            AccountManager accountManager = new AccountManager();
            BankAccountCollection bac = accountManager.AllBankAccounts();

            uiDisp.DisplayBankAccounts();

        }

        public void BuildUI()
        {
            uiDisp.BuildStartScreen();

        }


    }
}
