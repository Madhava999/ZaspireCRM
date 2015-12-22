using System;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zaspire.PageHelpers;
using Zaspire.PageHelpers.Com;

namespace Zaspire.Scripts
{
    [TestClass]
    public class AddNewNote : DriverTestCase
    {
        [TestMethod]
        public void addnewnote()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewNoteHelper = new AddNewNoteHelper(GetWebDriver());

            //Variable

            var NoteSubject = "Test Note" + RandomNumber(1, 99);
            

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Activities
            AddNewNoteHelper.ClickElement("ClickOnActivitiess");

            //Click on Notes
            AddNewNoteHelper.ClickElement("ClickOnNotes");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes");
            //AddNewNoteHelper.WaitForWorkAround(7000);


            //#################### CREATE A NOTE   #####################################

            //Create on Note
            //AddNewNoteHelper.ClickElement("ClickOnNoteAddNew");

            GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/notes/addnew");
            


            //################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Note Category
            AddNewNoteHelper.Select("SelectNoteCategory", "8926");

            //Select Owner  
            AddNewNoteHelper.Select("SelectNoteOwner", "1");

            //Select Related To
            AddNewNoteHelper.Select("SelectRelatedTo", "11");

            //Click On Merge Button
            AddNewNoteHelper.ClickElement("ClickOnMergeButton");

            //Select Related To Record
            AddNewNoteHelper.ClickElement("SelectRelatedToRecord");

            //Enter Note Subject
            AddNewNoteHelper.TypeText("EnterNoteSubject", NoteSubject);
            AddNewNoteHelper.WaitForWorkAround(4000);

            //Click On Save
            //AddNewNoteHelper.ClickElement("SelectFile");

            //Upload File
            //var filename = GetPath() + "//image//sample.jpg";
            //AddNewNoteHelper.Upload("upload", filename);

            //Click On Save
            AddNewNoteHelper.ClickElement("ClickOnSave");
            AddNewNoteHelper.WaitForWorkAround(10000);














        }
    }
}