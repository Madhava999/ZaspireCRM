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
    public class AddNewOpportunity : DriverTestCase
    {
        [TestMethod]
        public void addnewopportunity()
        {
            string[] username = null;
            string[] password = null;

            var oXMLData = new XMLParse();
            oXMLData.LoadXML("../../Config/OrganizationSetting.xml");

            username = oXMLData.getData("settings/Credentials", "username");
            password = oXMLData.getData("settings/Credentials", "password");

            //Initializing the objects
            var loginHelper = new LoginHelper(GetWebDriver());
            var AddNewOpportunityHelper = new AddNewOpportunityHelper(GetWebDriver());

            //Variable

            var FirstName = "Test" + RandomNumber(1, 99);
            var LastName = "Tester" + RandomNumber(1, 99);
            var Number = "12345678" + RandomNumber(10, 99);
            var OpportunityName = "Test Opportunity" + RandomNumber(1, 999);
            var CompanyName = "Test Company" + RandomNumber(1, 999);

            //Login with valid username and password
            Login(username[0], password[0]);
            Console.WriteLine("Logged in as: " + username[0] + " / " + password[0]);

            //Verify Page title
            VerifyTitle("Dashboard");
            Console.WriteLine("Redirected at Dashboard screen.");

            //Click on Opportunities
            AddNewOpportunityHelper.ClickElement("ClickOnOpportunities");

            //GetWebDriver().Navigate().GoToUrl("http://zaspire.com/infoaspire/opportunities");
            //AddNewOpportunityHelper.WaitForWorkAround(7000);


//#################### CREATE A OPPORTUNITY   #####################################

            //Create on Opportunity
            AddNewOpportunityHelper.ClickElement("ClickOnOpportunityAddNew");


//################### CLASSIFICATIONS & OWNERSHIP  #########################

            //Select Status
            AddNewOpportunityHelper.Select("SelectStatus", "New");

            //Select Source
            AddNewOpportunityHelper.Select("SelectSource", "Web Site");

            //Select Category
            AddNewOpportunityHelper.Select("SelectCategory", "9264");

            //Select Owner  
            AddNewOpportunityHelper.Select("SelectOwner", "1");

            //Select Manager
            AddNewOpportunityHelper.Select("SelectManager", "1");

            


//####################### PRIMARY INFORMATION #############################

            
            //Enter Opportunity Name
            AddNewOpportunityHelper.TypeText("EnterOpportunityName", OpportunityName);

            //Enter Compamny Name
            AddNewOpportunityHelper.TypeText("EnterCompamnyName", CompanyName);

            //Select Industry
            AddNewOpportunityHelper.Select("SelectIndustry", "Administrative");

            //Enter No Of Employees
            AddNewOpportunityHelper.TypeText("EnterNoOfEmployees", "49");

            //Enter Annual Revenue
            AddNewOpportunityHelper.TypeText("EnterAnnualRevenue", "485712");

            //Enter Probability
            AddNewOpportunityHelper.TypeText("EnterProbability", "43");

            //Enter Amount
            AddNewOpportunityHelper.TypeText("EnterAmount", "87452");

            //Enter Gross Amount
            AddNewOpportunityHelper.TypeText("EnterGrossAmount", "87568");

            //Enter Unweighted Pipeline
            AddNewOpportunityHelper.TypeText("EnterUnweightedPipeline", "78");

            //Enter Weighted Pipeline
            AddNewOpportunityHelper.TypeText("EnterWeightedPipeline", "47");

            //Select Skill Type
            AddNewOpportunityHelper.Select("SelectSkillType", "Development");

            //Enter Specific Skill
            AddNewOpportunityHelper.TypeText("EnterSpecificSkill", "Testing");

            //Enter Pay Rate
            AddNewOpportunityHelper.TypeText("EnterPayRate", "7852");

            //Enter Bill Rate
            AddNewOpportunityHelper.TypeText("EnterBillRate", "7562");

            //Enter Next Step
            AddNewOpportunityHelper.TypeText("EnterNextStep", "Test process");
                  





//##################   CONTACT INFORMATION  #############################


            //Select Contact Salutation
            AddNewOpportunityHelper.Select("SelectContactSalutation", "Mr");

            //Enter Contact First Name
            AddNewOpportunityHelper.TypeText("EnterContactFirstName", "Mark");

            //Enter Contact Middle Name
            AddNewOpportunityHelper.TypeText("EnterContactMiddleName", "G");

            //Enter Contact Last Name
            AddNewOpportunityHelper.TypeText("EnterContactLastName", "John");

            //Select Contact Phone Type
            AddNewOpportunityHelper.Select("SelectContactPhoneType", "Cell");

            //Enter Contact Phone Number
            AddNewOpportunityHelper.TypeText("EnterContactPhoneNumber", "8745213698");

            //Select Contact Email Type
            AddNewOpportunityHelper.Select("SelectContactEmailType", "Home");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Email
            AddNewOpportunityHelper.TypeText("EnterContactEmail", "testemail@ymail.com");

            // Select Contact Social Link Type
            AddNewOpportunityHelper.Select("SelectContactSocialLinkType", "Facebook");

            //Enter Contact Social Link
            AddNewOpportunityHelper.TypeText("EnterContactSocialLink", "test@facebook.com");



//###################### CONTACT INFORMATION ADDRESS  ######################################


            //Click on Add Address
            AddNewOpportunityHelper.ClickElement("ClickOnAddAddress");

            //Select Contact Address Type
            AddNewOpportunityHelper.Select("SelectContactAddressType", "Location");

            //Enter Contact Address Line1
            AddNewOpportunityHelper.TypeText("EnterContactAddressLine1", "Test Contact Addressline1");

            //Enter Contact Address Line2
            AddNewOpportunityHelper.TypeText("EnterContactAddressLine2", "Test Contact Addressline2");

            //Enter Contact City
            AddNewOpportunityHelper.TypeText("EnterContactCity", "Test Contact City");

            //Select Contact State
            AddNewOpportunityHelper.Select("SelectContactState", "GA");

            //Select Contact Country
            AddNewOpportunityHelper.Select("SelectContactCountry", "USA");
            //AddNewLeadHelper.WaitForWorkAround(3000);

            //Enter Contact Zip Code
            AddNewOpportunityHelper.TypeText("EnterContactZipCode", "25417");


//######################  SAVE OPPORTUNITY  ###########################

            //Click on Save
            AddNewOpportunityHelper.ClickElement("ClickOnSave");
            AddNewOpportunityHelper.WaitForWorkAround(10000);

           

        }
    }
}
