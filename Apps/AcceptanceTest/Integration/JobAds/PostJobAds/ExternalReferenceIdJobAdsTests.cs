﻿using System;
using System.Collections.Generic;
using System.Linq;
using LinkMe.Apps.Services.JobAds;
using LinkMe.Domain.Roles.Integration;
using LinkMe.Domain.Roles.JobAds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Integration.JobAds.PostJobAds
{
    [TestClass]
    public class ExternalReferenceIdJobAdsTests
        : PostJobAdsTests
    {
        private const string ExternalReferenceIdFormat = "ABC00{0}";

        [TestMethod]
        public void TestCreateExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            Assert.AreEqual(0, _jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id).Count);

            var externalReferenceId = CreateExternalReferenceId(0);
            var jobAd = CreateJobAd(0, externalReferenceId);
            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 1, 0, 0, 0);

            AssertJobAds(integratorUser, employer.Id, jobAd);
        }

        [TestMethod]
        public void TestUpdateExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            // Create.

            var externalReferenceId = CreateExternalReferenceId(0);
            var jobAd = CreateJobAd(0, externalReferenceId);
            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 1, 0, 0, 0);

            // Update it.

            jobAd.Summary = "A changed summary";
            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 0, 1, 0, 0);

            AssertJobAds(integratorUser, employer.Id, jobAd);
        }

        [TestMethod]
        public void TestCreateNoExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            Assert.AreEqual(0, _jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id).Count);

            var jobAd = CreateJobAd(0, null);
            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 1, 0, 0, 0);

            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id));
            Assert.AreEqual(1, jobAds.Count);
            AssertJobAd(jobAd, AssertJobAd(jobAds[0], integratorUser, null, JobAdStatus.Open));
        }

        [TestMethod]
        public void TestUpdateNoExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var jobAd = CreateJobAd(0, null);
            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 1, 0, 0, 0);

            // Without an external reference id cannot update so another one gets created.

            PostJobAds(integratorUser, employer, false, new[] { jobAd }, 1, 0, 0, 0);

            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id));
            Assert.AreEqual(2, jobAds.Count);
            AssertJobAd(jobAd, AssertJobAd(jobAds[0], integratorUser, null, JobAdStatus.Open));
            AssertJobAd(jobAd, AssertJobAd(jobAds[1], integratorUser, null, JobAdStatus.Open));
        }

        [TestMethod]
        public void TestCreateMultipleExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var externalReferenceId1 = CreateExternalReferenceId(1);
            var jobAd1 = CreateJobAd(1, externalReferenceId1);
            var externalReferenceId2 = CreateExternalReferenceId(2);
            var jobAd2 = CreateJobAd(2, externalReferenceId2);
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2 }, 2, 0, 0, 0);

            AssertJobAds(integratorUser, employer.Id, jobAd1, jobAd2);
        }

        [TestMethod]
        public void TestUpdateMultipleExternalReferenceId()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var externalReferenceId1 = CreateExternalReferenceId(1);
            var jobAd1 = CreateJobAd(1, externalReferenceId1);
            var externalReferenceId2 = CreateExternalReferenceId(2);
            var jobAd2 = CreateJobAd(2, externalReferenceId2);
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2 }, 2, 0, 0, 0);

            // Update them.

            jobAd1.Summary = "A changed summary 1";
            jobAd2.Summary = "A changed summary 2";
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2 }, 0, 2, 0, 0);

            AssertJobAds(integratorUser, employer.Id, jobAd1, jobAd2);
        }

        [TestMethod]
        public void TestCreateCloseAllOthers()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var externalReferenceId1 = CreateExternalReferenceId(1);
            var jobAd1 = CreateJobAd(1, externalReferenceId1);
            var externalReferenceId2 = CreateExternalReferenceId(2);
            var jobAd2 = CreateJobAd(2, externalReferenceId2);
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2 }, 2, 0, 0, 0);

            // Create another and close those already created.

            var externalReferenceId3 = CreateExternalReferenceId(3);
            var jobAd3 = CreateJobAd(3, externalReferenceId3);
            PostJobAds(integratorUser, employer, true, new[] { jobAd3 }, 1, 0, 2, 0);

            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id));
            Assert.AreEqual(3, jobAds.Count);
            AssertJobAd(integratorUser, JobAdStatus.Closed, jobAd1, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Closed, jobAd2, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Open, jobAd3, jobAds);
        }

        [TestMethod]
        public void TestUpdateCloseAllOthers()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var externalReferenceId1 = CreateExternalReferenceId(1);
            var jobAd1 = CreateJobAd(1, externalReferenceId1);
            var externalReferenceId2 = CreateExternalReferenceId(2);
            var jobAd2 = CreateJobAd(2, externalReferenceId2);
            var externalReferenceId3 = CreateExternalReferenceId(3);
            var jobAd3 = CreateJobAd(3, externalReferenceId3);
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2, jobAd3 }, 3, 0, 0, 0);

            // Update one and close the others.

            jobAd1.Summary = "A changed summary";
            PostJobAds(integratorUser, employer, true, new[] { jobAd1 }, 0, 1, 2, 0);

            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id));
            Assert.AreEqual(3, jobAds.Count);
            AssertJobAd(integratorUser, JobAdStatus.Open, jobAd1, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Closed, jobAd2, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Closed, jobAd3, jobAds);
        }

        [TestMethod]
        public void TestCreateUpdateCloseAllOthers()
        {
            var integratorUser = CreateIntegratorUser(0);
            var employer = CreateEmployer(0);

            var externalReferenceId1 = CreateExternalReferenceId(1);
            var jobAd1 = CreateJobAd(1, externalReferenceId1);
            var externalReferenceId2 = CreateExternalReferenceId(2);
            var jobAd2 = CreateJobAd(2, externalReferenceId2);
            PostJobAds(integratorUser, employer, false, new[] { jobAd1, jobAd2 }, 2, 0, 0, 0);

            // Update one, create another and close the others.

            jobAd1.Summary = "A changed summary";
            var externalReferenceId3 = CreateExternalReferenceId(3);
            var jobAd3 = CreateJobAd(3, externalReferenceId3);
            PostJobAds(integratorUser, employer, true, new[] { jobAd1, jobAd3 }, 1, 1, 1, 0);

            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employer.Id));
            Assert.AreEqual(3, jobAds.Count);
            AssertJobAd(integratorUser, JobAdStatus.Open, jobAd1, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Closed, jobAd2, jobAds);
            AssertJobAd(integratorUser, JobAdStatus.Open, jobAd3, jobAds);
        }

        private void AssertJobAds(IntegratorUser integratorUser, Guid employerId, params JobAdElement[] expectedJobAds)
        {
            var jobAds = _jobAdsQuery.GetJobAds<JobAd>(_jobAdIntegrationQuery.GetJobAdIds(integratorUser.Id, employerId));
            Assert.AreEqual(expectedJobAds.Length, jobAds.Count);

            foreach (var expectedJobAd in expectedJobAds)
                AssertJobAd(integratorUser, JobAdStatus.Open, expectedJobAd, jobAds);
        }

        private void AssertJobAd(IntegratorUser integratorUser, JobAdStatus expectedStatus, JobAdElement expectedJobAd, IEnumerable<JobAd> jobAds)
        {
            AssertJobAd(expectedJobAd, AssertJobAd((from j in jobAds where j.Integration.ExternalReferenceId == expectedJobAd.ExternalReferenceId select j).Single(), integratorUser, expectedJobAd.ExternalReferenceId, expectedStatus));
        }

        private static JobAdElement CreateJobAd(int index, string externalReferenceId)
        {
            return CreateJobAd(index, j => j.ExternalReferenceId = externalReferenceId);
        }

        private static string CreateExternalReferenceId(int index)
        {
            return string.Format(ExternalReferenceIdFormat, index);
        }
    }
}
