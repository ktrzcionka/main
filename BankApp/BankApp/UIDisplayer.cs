using System;

namespace BankApp
{
    internal class UIDisplayer
    {
        internal void DisplayBankAccounts(SingleAccountInfo bankInfo)
        {
            try
            {
                Console.WriteLine("Your bank: {0}", bankInfo.bankName);
                Console.WriteLine("Your account: {0}\n", bankInfo.accountType);

            }
            catch (Exception e)
            {

                throw e;
            }

        }

        internal void BuildStartScreen()
        {

            try
            {
                Console.WriteLine("Welcome to the BankApp\n");
            }
            catch (Exception e)
            {

                throw e;
            }

        }

        internal string ChooseAccount()
        {
            Console.WriteLine("Choose account: ");
            string selectedAccount = Console.ReadLine();

            return selectedAccount;

        }

        

    }
}