using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankApp
{
    public interface IRequestComms
    {
        CommunicationsResponse RetrieveSelectedBankAccountDetails(BankCommsCapsule capsule);
    }
}
