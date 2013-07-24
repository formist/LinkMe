﻿using LinkMe.Apps.Agents.Test.Communities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Communities.Specific
{
    [TestClass]
    public class BusinessSpectatorTests
        : SpecificCommunityTests
    {
        protected override TestCommunity GetTestCommunity()
        {
            return TestCommunity.BusinessSpectator;
        }

        protected override bool IsTestCommunityDeleted
        {
            get { return true; }
        }
    }
}