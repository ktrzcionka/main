using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Net;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;




namespace BankApp
{
    public class CommunicationModule
    {

        IRequestComms _selectedComms;

        public CommunicationModule(IRequestComms selectedComms)
        {
            _selectedComms = selectedComms;
        }

        public BankAccountDetails GiveAccountDetails(SingleAccountInfo info)
        {
            AccountInfoRequestFactory factory = new AccountInfoRequestFactory();
            BankCommsCapsule capsule = factory.CreateBankCommunicationsCapsule(info);

            CommunicationsResponse resp = _selectedComms.RetrieveSelectedBankAccountDetails(capsule);//the part where magic happens

            AccountInfoResponseParser parser = new AccountInfoResponseParser();
            BankAccountDetails details = parser.FormAccountDetails(resp);

            return details;
        }
    }


    [TestClass]
    public class CommunicationModuleTests
    {

        [TestMethod]
        public void GiveAccountDetailsDoesAnythingAtAll()
        {
            //Given
            SingleAccountInfo fakeAccountInfo = new SingleAccountInfo();

            IRequestComms selectedComms = new MockRequestComms(fakeAccountInfo);

            CommunicationModule moduleUnderTest = new CommunicationModule(selectedComms);

            //When
            BankAccountDetails result = moduleUnderTest.GiveAccountDetails(fakeAccountInfo);

            //Then
            Assert.IsTrue(result != null);
        }
    }



    public class MockRequestComms : IRequestComms
    {
        SingleAccountInfo _fakeInfo;

        public MockRequestComms(SingleAccountInfo fakeInfo)
        {
            _fakeInfo = fakeInfo;
        }

        public CommunicationsResponse RetrieveSelectedBankAccountDetails(BankCommsCapsule capsule)
        {
            return null;
            //if (_fakeInfo.IsEqualTo(capsule))
            //{
            //    return PrefabricatedCommsResponse();
            //}

            //return NullObjectResponse();
        }
    }

    public class WebRequestComms : IRequestComms
    {
        public WebRequestComms()
        {
        }

        public CommunicationsResponse RetrieveSelectedBankAccountDetails(BankCommsCapsule capsule)
        {
            string address = "https://online.mbank.pl/pl/Login";
            CommunicationsResponse response = new CommunicationsResponse();

            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(address);

//            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            Thread.Sleep(3000);
            
            IWebElement login = driver.FindElementByName("userID");
            IWebElement password = driver.FindElementByName("pass");

            login.SendKeys(capsule._login);
            password.SendKeys(capsule._password);

            password.Submit();

            driver.Quit();
            return response;

        }
    }

}
