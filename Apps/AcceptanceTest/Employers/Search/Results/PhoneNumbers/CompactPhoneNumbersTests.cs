﻿using System.Linq;
using LinkMe.Domain.Contacts;
using LinkMe.Query.Search.Members;
using LinkMe.Web.Areas.Employers.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkMe.AcceptanceTest.Employers.Search.Results.PhoneNumbers
{
    [TestClass]
    public class CompactPhoneNumbersTests
        : PhoneNumbersTests
    {
        protected override void TestPhoneNumbers(Member member, int? credits, bool unlocked, PhoneNumberVisibility visibility)
        {
            var criteria = new MemberSearchCriteria();
            criteria.SetKeywords(BusinessAnalyst);
            Get(GetPartialSearchUrl(criteria, DetailLevel.Compact));
            AssertCompactPhoneNumbers(member, unlocked, visibility);
        }

        private void AssertCompactPhoneNumbers(IHavePhoneNumbers member, bool unlocked, PhoneNumberVisibility visibility)
        {
            // Unlocked node.

            var unlockedNode = Browser.CurrentHtml.DocumentNode.SelectSingleNode("//ul/li/span[@class='contact-unlocked-icon']");
            if (unlocked)
            {
                Assert.IsNotNull(unlockedNode);
                Assert.AreEqual("", unlockedNode.InnerText);
            }
            else
            {
                Assert.IsNull(unlockedNode);
            }

            // Locked node.

            var lockedNode = Browser.CurrentHtml.DocumentNode.SelectSingleNode("//ul/li/a[@class='contact-locked-icon']");
            if (unlocked)
            {
                Assert.IsNull(lockedNode);
            }
            else
            {
                Assert.IsNotNull(lockedNode);
                Assert.AreEqual("", lockedNode.InnerText);
            }

            // Mobile node.

            var mobileNode = Browser.CurrentHtml.DocumentNode.SelectSingleNode("//ul/li/span[@class='phone-mobile-icon phone-number']");
            var mobileDimmedNode = Browser.CurrentHtml.DocumentNode.SelectSingleNode("//ul/li/span[@class='phone-mobile-dimmed-icon']");
            var mobilePhoneNumber = member.PhoneNumbers == null
                ? null
                : (from p in member.PhoneNumbers where p.Type == PhoneNumberType.Mobile select p).Single().Number;

            switch (visibility)
            {
                case PhoneNumberVisibility.Shown:
                    Assert.IsNotNull(mobileNode);
                    Assert.AreEqual(mobilePhoneNumber, mobileNode.Attributes["title"].Value);
                    Assert.IsNull(mobileDimmedNode);
                    break;

                case PhoneNumberVisibility.Available:
                    Assert.IsNull(mobileNode);
                    Assert.IsNotNull(mobileDimmedNode);
                    Assert.AreEqual("", mobileDimmedNode.InnerText);
                    AssertPageDoesNotContain(mobilePhoneNumber);
                    break;

                default:
                    Assert.IsNull(mobileNode);
                    Assert.IsNull(mobileDimmedNode);
                    if (mobilePhoneNumber != null)
                        AssertPageDoesNotContain(mobilePhoneNumber);
                    break;
            }
        }
    }
}