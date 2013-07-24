using System;
using System.Linq;
using LinkMe.Domain.Contacts;
using LinkMe.Domain.Roles.Candidates.Queries;
using LinkMe.Domain.Roles.Resumes.Queries;
using LinkMe.Domain.Users.Members.Contacts.Queries;
using LinkMe.Domain.Users.Members.Queries;
using LinkMe.Domain.Users.Members.Views.Queries;
using LinkMe.Framework.Utility;
using LinkMe.Framework.Utility.Exceptions;
using LinkMe.Framework.Utility.Unity;
using LinkMe.Web.Content;
using LinkMe.Web.Domain.Users.Members;
using LinkMe.Web.UI;

namespace LinkMe.Web.Members.Friends
{
    public partial class ViewFriends
        : LinkMePage
    {
        private static readonly IMembersQuery _membersQuery = Container.Current.Resolve<IMembersQuery>();
        private static readonly ICandidatesQuery _candidatesQuery = Container.Current.Resolve<ICandidatesQuery>();
        private static readonly IResumesQuery _resumesQuery = Container.Current.Resolve<IResumesQuery>();
        private static readonly IMemberContactsQuery _memberContactsQuery = Container.Current.Resolve<IMemberContactsQuery>();
        private static readonly IMemberViewsQuery _memberViewsQuery = Container.Current.Resolve<IMemberViewsQuery>();

        public const string NameParameter = "name";

        private int _friendsCount;

        #region Page Actions

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            AddStyleSheetReference(StyleSheets.Networking);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            try
            {
                SetUpContactsList();
            }
            catch (UserException ex)
            {
                AddError(ex.Message);
            }
        }

        private void SetUpContactsList()
        {
            var friends = _memberContactsQuery.GetFirstDegreeContacts(LoggedInMember.Id);
            _friendsCount = friends.Count;

            if (_friendsCount == 0)
            {
                phNoFriendsText.Visible = true;
                phFriends.Visible = false;
            }

            var name = HtmlUtil.CleanScriptEventHtmlTags(Request.QueryString[NameParameter]);
            ucPagingBarTop.NameStartsWith = ucPagingBarBottom.NameStartsWith = name;

            var ids = string.IsNullOrEmpty(name)
                ? friends
                : _memberContactsQuery.GetFirstDegreeContacts(LoggedInMember.Id, name[0]);

            var members = _membersQuery.GetMembers(ids);
            var candidates = _candidatesQuery.GetCandidates(ids);
            var resumes = _resumesQuery.GetResumes(from c in candidates where c.ResumeId != null select c.ResumeId.Value);
            var views = _memberViewsQuery.GetPersonalViews(LoggedInMember.Id, members);

            contactsListControl.DisplayContacts(ids, views, members, candidates, resumes);

            if(contactsListControl.CountContacts < 1)
            {
                displayFriends.Visible = false;
                displayNoFriends.Visible = true;
            }
        }

        #endregion

        protected override UserType[] AuthorizedUserTypes
        {
            get { return new[] { UserType.Member }; }
        }

        protected override bool GetRequiresActivation()
        {
            return true;
        }

        protected override UserType GetActiveUserType()
        {
            return UserType.Member;
        }

        protected string DescribeFriendsCount()
        {
            return _friendsCount.GetFriendsCountDisplayText();
        }
    }
}