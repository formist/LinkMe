﻿using LinkMe.Domain.Location;
using LinkMe.Query.Search.JobAds;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Members.Jobs.Search.Criteria.Web
{
    [TestClass]
    public class LocationTests
        : CriteriaTests
    {
        private Country _newZealand;

        private const string MelbourneVic3000 = "Melbourne VIC 3000";

        [TestInitialize]
        public void TestInitialize()
        {
            _newZealand = _locationQuery.GetCountry("New Zealand");
        }

        protected override void TestDisplay()
        {
            var criteria = new JobAdSearchCriteria();
            criteria.SetKeywords(BusinessAnalyst);

            criteria.Location = null;
            TestDisplay(false, criteria);

            criteria.Location = _locationQuery.ResolveLocation(Australia, MelbourneVic3000);
            TestDisplay(false, criteria);

            criteria.Distance = 100;
            TestDisplay(false, criteria);

            criteria.Location = _locationQuery.ResolveLocation(_newZealand, null);
            TestDisplay(false, criteria);
        }
    }
}