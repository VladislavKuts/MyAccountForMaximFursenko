using MyAccountForMaximFursenko.Core;
using OpenQA.Selenium;

namespace MyAccountForMaximFursenko.POM
{
    class DocumentsPagePOM : SeleniumWrapper

    {
        /// <summary>
        /// Top block of elements
        /// </summary>
        internal static By PersonalCabinet = By.CssSelector(".nav > li:nth-child(1) > a:nth-child(1)");
        internal static By DepositPage = By.CssSelector(".nav > li:nth-child(2) > a:nth-child(1)");
        internal static By ConclusionPage = By.CssSelector(".nav > li:nth-child(3) > a:nth-child(1)");
        internal static By TopBlockPersonalDataPage = By.CssSelector(".nav > li:nth-child(4) > a:nth-child(1)");
        internal static By StateOfAnAccountPage = By.CssSelector(".nav > li:nth-child(5) > a:nth-child(1)");
        internal static By PromoActionsPage = By.CssSelector(".nav > li:nth-child(6) > a:nth-child(1)");
        internal static By DocumentsPage = By.CssSelector(".nav > li:nth-child(7) > a:nth-child(1)");
        internal static By SignOut = By.CssSelector(".pull-right");

        /// <summary>
        /// Left block of elements
        /// </summary>
        internal static By LeftBlockPersonalDataPage = By.CssSelector("#sub-menu > a:nth-child(1)");
        internal static By LeftBlockDocumentsPage = By.CssSelector("#sub-menu > a:nth-child(2)");
        internal static By SecurityPage = By.CssSelector("#sub-menu > a:nth-child(3)");

        /// <summary>
        /// Passport photo loading unit
        /// </summary>
        internal static By DownloadPasport = By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button");
        internal static By DownloadPasportPhoto = By.CssSelector("div:nth-child(1) > div > div input");
        internal static By WhatShouldBeAPasport = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangePassportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Adress Document loading unit
        /// </summary>
        internal static By DownloadAdressDocument = By.CssSelector("div:nth-child(2) > div > div:nth-child(3) > button");
        internal static By DownloadAdressDocumnetPhoto = By.CssSelector("div:nth-child(2) > div > div input");
        internal static By WhatShouldBeAAdressDocument = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Additional Document loading unit
        /// </summary>
        internal static By DownloadAdditionalDocument = By.CssSelector("div:nth-child(3) > div > div:nth-child(3) > button");
        internal static By DownloadAdditionalDocumnetPhoto = By.CssSelector("div:nth-child(3) > div > div input");
        internal static By WhatShouldBeAAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdditionalDocument= By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Second Additional Document loading unit
        /// </summary>
        internal static By DownloadSecondAdditional = By.CssSelector("div:nth-child(4) > div > div:nth-child(3) > button");
        internal static By DownloadSecondAdditionalPhoto = By.CssSelector("div:nth-child(4) > div > div input");
        internal static By WhatShouldBeASecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUploadedSecondAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadSecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeSecondAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Account status page
        /// </summary>
        internal static By ChoiceTradingAccount = By.CssSelector("select.form-control");
        internal static By StartDdate = By.Id("start-date");
        internal static By EndDate = By.Id("end-date");
        internal static By ShowAccountStatus = By.CssSelector("button.btn:nth-child(3)");
        internal static By DownloadTransactionDocument = By.CssSelector("button.btn:nth-child(4)");
        internal static By NameOfTheTradingPlatform = By.CssSelector(".information-block > div:nth-child(1)");

        /// <summary>
        /// This method open Documents page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM OpenDocumentsPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/?lang=ru#documents");
            return this;
        }

        /// <summary>
        /// This method open Account status page of MyAccount.
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM OpenAccountStatusPage()
        {
            OpenPage("https://test-myaccount.maximarkets.org/?lang=ru#account-status");
            return this;
        }

        /// <summary>
        /// This method open Personal cabinet of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalCabinet()
        {
            FindElement(PersonalCabinet).Click();
            return this;
        }

        /// <summary>
        /// This method open Deposit page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickDepositPage()
        {
            FindElement(DepositPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Conclusion page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickConclusionPage()
        {
            FindElement(ConclusionPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal data of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickTopBlockPersonalDatasPage()
        {
            FindElement(TopBlockPersonalDataPage).Click();
            return this;
        }

        /// <summary>
        /// This method open State of an account page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickStateOfAnAccountPage()
        {
            FindElement(StateOfAnAccountPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Promo actions page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPromoActionsPage()
        {
            FindElement(PromoActionsPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Documents page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickDocumentsPage()
        {
            FindElement(DocumentsPage).Click();
            return this;
        }

        /// <summary>
        /// This method is logged out
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickSignOut()
        {
            FindElement(SignOut).Click();
            return this;
        }

        /// <summary>
        /// This method open Left block personal data page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickLeftBlockPersonalData()
        {
            FindElement(LeftBlockPersonalDataPage).Click();
            return this;
        }

        /// <summary>
        /// This method open left block documents page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickLeftBlockDocumentsPage()
        {
            FindElement(LeftBlockDocumentsPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickSecurityPage()
        {
            FindElement(SecurityPage).Click();
            return this;
        }


        //-------------------------------------------------------------------------


        /// <summary>
        /// This method open block uload photo of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickDownloadPasport()
        {
            FindElement(DownloadPasport).Click();
            return this;
        }

        /// <summary>
        /// This method upload Pasport photo of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM SendKeyDownloadPasportPhoto()
        {
            FindElement(DownloadPasportPhoto).SendKeys("Ukazat put");
            return this;
        }

        /// <summary>
        /// This method open notification with validation data of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickWhatShouldBeAPasport()
        {
            FindElement(WhatShouldBeAPasport).Click();
            return this;
        }

        /// <summary>
        /// This method take expected result
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM TextNameOfTheUploadedPasportPhoto()
        {
            string Expected = FindElement(NameOfTheUploadedPasportPhoto).Text.ToString();
            return this;
        }

        /// <summary>
        /// This method closed Upload pasport Photo page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickCancelUploadPasportPhoto()
        {
            FindElement(CancelUploadPasportPhoto).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickChangePassportPhoto()
        {
            FindElement(ChangePassportPhoto).SendKeys("Ukazat put");
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }
        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }

        /// <summary>
        /// This method open Personal page of My Account
        /// </summary>
        /// <returns></returns>
        public DocumentsPagePOM ClickPersonalPage()
        {
            FindElement(PersonalPage).Click();
            return this;
        }








    }
}
