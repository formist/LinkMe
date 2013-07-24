using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Members.Jobs.Applications.ManagedInternally.Web
{
    [TestClass]
    public class LogInTests
        : ManagedInternallyTests
    {
        [TestMethod]
        public void TestMember()
        {
            var employer = CreateEmployer();
            var jobAd = CreateJobAd(employer);
            var member = CreateMember(true);

            Get(HomeUrl);
            var anonymousId = GetAnonymousId();
            AssertNoView(jobAd.Id, anonymousId);
            AssertNoView(jobAd.Id, member.Id);
            AssertNoApplication(anonymousId, jobAd.Id);
            AssertNoApplication(member.Id, jobAd.Id);

            // Apply.

            View(jobAd.Id, AssertView);
            ApiLogIn(member);
            var applicationId = AssertApply(Apply(employer, jobAd, true, CoverLetterText));

            // Assert.

            AssertView(jobAd.Id, anonymousId);
            AssertNoView(jobAd.Id, member.Id);
            AssertNoApplication(anonymousId, jobAd.Id);
            AssertApplication(applicationId, jobAd, member.Id, CoverLetterText);
            AssertEmail(member, employer, CoverLetterText, GetProfileResumeFileName(member));
        }

        [TestMethod]
        public void TestMember2Jobs()
        {
            // Create a member and log in.

            var member = CreateMember(true);

            // Create the job ad.

            var employer = CreateEmployer();
            var jobAd = CreateJobAd(employer);

            // Apply.

            View(jobAd.Id, AssertView);
            ApiLogIn(member);
            AssertApply(Apply(employer, jobAd, true, CoverLetterText));

            // Create another.

            jobAd = CreateJobAd(employer);
            LogOut();

            View(jobAd.Id, AssertView);
            ApiLogIn(member);
            AssertApply(Apply(employer, jobAd, true, CoverLetterText));
        }

        [TestMethod]
        public void TestDeactivatedMember()
        {
            // Create the job ad.

            var employer = CreateEmployer();
            var jobAd = CreateJobAd(employer);

            // Create a member and log in.

            var member = CreateMember(true);
            member.IsActivated = false;
            _memberAccountsCommand.UpdateMember(member);

            // Apply.  The fact that the user is deactivated should make no difference.

            Get(HomeUrl);
            var anonymousId = GetAnonymousId();
            AssertNoView(jobAd.Id, anonymousId);
            AssertNoView(jobAd.Id, member.Id);
            AssertNoApplication(anonymousId, jobAd.Id);
            AssertNoApplication(member.Id, jobAd.Id);

            View(jobAd.Id, AssertView);
            ApiLogIn(member);
            var applicationId = AssertApply(Apply(employer, jobAd, true, CoverLetterText));

            // Assert.

            AssertView(jobAd.Id, anonymousId);
            AssertNoView(jobAd.Id, member.Id);
            AssertNoApplication(anonymousId, jobAd.Id);
            AssertApplication(applicationId, jobAd, member.Id, CoverLetterText);
            AssertEmail(member, employer, CoverLetterText, GetProfileResumeFileName(member));
        }
    }
}