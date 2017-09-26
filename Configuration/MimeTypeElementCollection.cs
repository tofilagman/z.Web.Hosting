using System.Configuration;

namespace z.Web.Hosting.Configuration
{
    [ConfigurationCollection(typeof(MimeTypeElement))]
    public class MimeTypeElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new MimeTypeElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((MimeTypeElement)element).Extension;
        }
    }
}