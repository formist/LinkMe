﻿using LinkMe.Apps.Agents.Test.Communities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Communities.Specific
{
    [TestClass]
    public class TheJunctionWorksTests
        : SpecificCommunityTests
    {
        protected override TestCommunity GetTestCommunity()
        {
            return TestCommunity.TheJunctionWorks;
        }

        protected override bool IsTestCommunityDeleted
        {
            get { return true; }
        }
    }
}
