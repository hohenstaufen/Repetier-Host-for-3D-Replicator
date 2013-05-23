using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace RepetierHost.Replicator3D
{
    class Settings: ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string DAVIDLaserscanner
        {
            get { return this["DAVIDLaserscanner"].ToString(); }
            set { this["DAVIDLaserscanner"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string Processing
        {
            get { return this["Processing"].ToString(); }
            set { this["Processing"] = value; }
        }

        [UserScopedSetting()]
        [DefaultSettingValue("")]
        public string Directory
        {
            get { return this["Directory"].ToString(); }
            set { this["Directory"] = value; }
        }
    }
}
