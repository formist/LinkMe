using LinkMe.Framework.Content;
using LinkMe.Web.Cms.ContentEditors;

namespace LinkMe.Web.Cms.ContentEditViews
{
    public class ContentItemEditView
        : ContentEditView
    {
        protected override IContentEditor CreateContentEditor(ContentItem item)
        {
            return ContentEditor.CreateEditor(item);
        }
    }
}
