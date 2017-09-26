using System;
using System.Configuration;

namespace z.Web.Hosting.Configuration
{
    ///<summary>
    ///</summary>
    public class WebConfigurationSection : ConfigurationSection
    {

        ///<summary>
        ///</summary>
        public static WebConfigurationSection Instance
        {
            get
            {
                try
                {
                    object section = ConfigurationManager.GetSection("z.Web.Hosting");
                    if (section != null)
                    {
                        return (WebConfigurationSection)section;
                    }
                }

#pragma warning disable 168
                catch (Exception ex)
#pragma warning restore 168
                {

                    // #TODO: log it
                    throw;
                }
                return null;
            }
        }

        ///<summary>
        ///</summary>
        [ConfigurationProperty("profiles")]
        public WebProfileElementCollection Profiles
        {
            get
            {
                return (WebProfileElementCollection)this["profiles"];
            }
        }
    }
}
