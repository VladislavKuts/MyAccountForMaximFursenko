using MyAccountForMaximFursenko.Core;
using OpenQA.Selenium;

namespace MyAccountForMaximFursenko.POM
{
    class DocumentsPagePOM : SeleniumWrapper

    {
        /// <summary>
        /// Top block of elements
        /// </summary>
        internal static By PersonalPage = By.CssSelector(".nav > li:nth-child(1) > a:nth-child(1)");
        internal static By Deposit = By.CssSelector(".nav > li:nth-child(2) > a:nth-child(1)");
        internal static By Conclusion = By.CssSelector(".nav > li:nth-child(3) > a:nth-child(1)");
        internal static By TopBlockPersonalFunds = By.CssSelector(".nav > li:nth-child(4) > a:nth-child(1)");
        internal static By StateOfAnAccount = By.CssSelector(".nav > li:nth-child(5) > a:nth-child(1)");
        internal static By PromoActions = By.CssSelector(".nav > li:nth-child(6) > a:nth-child(1)");
        internal static By Documents = By.CssSelector(".nav > li:nth-child(7) > a:nth-child(1)");
        internal static By SignOut = By.CssSelector(".pull-right");

        /// <summary>
        /// Left block of elements
        /// </summary>
        internal static By LeftBlockPersonalFunds = By.CssSelector("#sub-menu > a:nth-child(1)");
        internal static By LeftBlockDocuments = By.CssSelector("#sub-menu > a:nth-child(2)");
        internal static By Security = By.CssSelector("#sub-menu > a:nth-child(3)");

        /// <summary>
        /// Passport photo loading unit
        /// </summary>
        internal static By DownloadPasport = By.CssSelector("div:nth-child(1) > div > div:nth-child(3) > button");
        internal static By DownloadPasportPhoto = By.CssSelector("div:nth-child(1) > div > div input");
        internal static By WhatShouldBeAPasport = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUloadedPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadPasportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangePassportPhoto = By.CssSelector("div.b-document-item:nth-child(1) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Adress Document loading unit
        /// </summary>
        internal static By DownloadAdressDocument = By.CssSelector("div:nth-child(2) > div > div:nth-child(3) > button");
        internal static By DownloadAdressDocumnetPhoto = By.CssSelector("div:nth-child(2) > div > div input");
        internal static By WhatShouldBeAAdressDocument = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUloadedAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdressDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(2) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Additional Document loading unit
        /// </summary>
        internal static By DownloadAdditionalDocument = By.CssSelector("div:nth-child(3) > div > div:nth-child(3) > button");
        internal static By DownloadAdditionalDocumnetPhoto = By.CssSelector("div:nth-child(3) > div > div input");
        internal static By WhatShouldBeAAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUloadedAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadAdditionalDocument= By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(3) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");

        /// <summary>
        /// Second Additional Document loading unit
        /// </summary>
        internal static By DownloadSecondAdditional = By.CssSelector("div:nth-child(4) > div > div:nth-child(3) > button");
        internal static By DownloadSecondAdditionalPhoto = By.CssSelector("div:nth-child(4) > div > div input");
        internal static By WhatShouldBeASecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(4) > div:nth-child(1) > div:nth-child(1) > a:nth-child(1)");
        internal static By NameOfTheUloadedSecondAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(1) > div:nth-child(2)");
        internal static By CancelUploadSecondAdditionalDocument = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(3) > div:nth-child(1)");
        internal static By ChangeSecondAdditionalDocumentPhoto = By.CssSelector("div.b-document-item:nth-child(4) > div:nth-child(1) > div:nth-child(3) > button:nth-child(1)");
        
    }
}
