﻿using LinkMe.Apps.Agents.Test.Users.Employers;
using LinkMe.Apps.Services.External.CareerOne.Queries;
using LinkMe.Domain.Contacts;
using LinkMe.Domain.Roles.Test.Recruiters;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Members.Jobs.Display.Web
{
    [TestClass]
    public class ContactDetailsTests
        : DisplayTests
    {
        private readonly ICareerOneQuery _careerOneQuery = Resolve<ICareerOneQuery>();

        private const string FirstName = "Monty";
        private const string LastName = "Burns";
        private const string Company = "Acme";
        private const string PhoneNumber = "99999999";
        private const string EmailAddress = "test@test.linkme.net.au";

        [TestMethod]
        public void TestContactDetails()
        {
            TestContactDetails(false, false, FirstName, LastName, Company, PhoneNumber, FirstName + " " + LastName + " at " + Company + ", " + PhoneNumber);
        }

        [TestMethod]
        public void TestSomeContactDetails()
        {
            TestContactDetails(false, false, FirstName, LastName, Company, null, FirstName + " " + LastName + " at " + Company);
        }

        [TestMethod]
        public void TestHiddenContactDetails()
        {
            TestContactDetails(true, false, FirstName, LastName, Company, PhoneNumber, "");
        }

        [TestMethod]
        public void TestHiddenCompanyDetails()
        {
            TestContactDetails(false, true, FirstName, LastName, Company, PhoneNumber, FirstName + " " + LastName + ", " + PhoneNumber);
        }

        [TestMethod]
        public void TestCareerOneHiddenCompanyNoContactDetailsCompany()
        {
            var employer = CreateEmployer();
            var jobAd = PostJobAd(
                employer,
                j =>
                {
                    j.Integration.IntegratorUserId = _careerOneQuery.GetIntegratorUser().Id;
                    j.Visibility.HideCompany = true;
                    j.Description.CompanyName = Company;
                    j.Visibility.HideContactDetails = false;
                    j.ContactDetails = new ContactDetails { EmailAddress = EmailAddress };
                });

            Get(GetJobUrl(jobAd.Id));

            Assert.AreEqual("", GetContactDetails());
            AssertPageDoesNotContain(Company);
        }

        private void TestContactDetails(bool hideContactDetails, bool hideCompany, string firstName, string lastName, string company, string phoneNumber, string expectedContactDetails)
        {
            var employer = _employerAccountsCommand.CreateTestEmployer(0, _organisationsCommand.CreateTestVerifiedOrganisation(company));
            var jobAd = PostJobAd(
                employer,
                j =>
                {
                    j.Visibility.HideContactDetails = hideContactDetails;
                    j.Visibility.HideCompany = hideCompany;
                    j.ContactDetails = new ContactDetails { FirstName = firstName, LastName = lastName, CompanyName = company, PhoneNumber = phoneNumber };
                });

            // Get the job.

            Get(GetJobUrl(jobAd.Id));
            Assert.AreEqual(expectedContactDetails, GetContactDetails());

            // Make sure the details don't appear anywhere if hidden.

            if (hideContactDetails)
            {
                AssertPageDoesNotContain(firstName);
                AssertPageDoesNotContain(lastName);
                AssertPageDoesNotContain(company);
                AssertPageDoesNotContain(phoneNumber);
            }

            if (hideCompany)
            {
                AssertPageDoesNotContain(company);
            }
        }

        private string GetContactDetails()
        {
            var nodes = Browser.CurrentHtml.DocumentNode.SelectNodes("//div[@class='summary']//div[@class='title' and text()='Contact']/../div[@class='desc']");
            return nodes.Count > 0 ? nodes[0].InnerText : null;
        }
    }
}