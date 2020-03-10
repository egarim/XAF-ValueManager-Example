using DevExpress.Persistent.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueManagerExample.Module
{
    public static class MainValueManager
    {

        public static string CurrentUser
        {
            get
            {
                IValueManager<string> valueManager = ValueManager.GetValueManager<string>(nameof(CurrentUser));
                if (valueManager.CanManageValue)
                    return valueManager.Value;
                else return string.Empty;
            }
            set
            {
                IValueManager<string> valueManager = ValueManager.GetValueManager<string>(nameof(CurrentUser));
                if (valueManager.CanManageValue)
                    valueManager.Value = value;
            }
        }



        public static string MyStringProperty
        {
            get
            {
                IValueManager<string> valueManager = ValueManager.GetValueManager<string>(nameof(MyStringProperty));
                if (valueManager.CanManageValue)
                    return valueManager.Value;
                else return string.Empty;
            }
            set
            {
                IValueManager<string> valueManager = ValueManager.GetValueManager<string>(nameof(MyStringProperty));
                if (valueManager.CanManageValue)
                    valueManager.Value = value;
            }
        }
        public static DateTime MyDateTimeProperty
        {
            get
            {
                IValueManager<DateTime> valueManager = ValueManager.GetValueManager<DateTime>(nameof(MyDateTimeProperty));
                if (valueManager.CanManageValue)
                    return valueManager.Value;
                else return DateTime.MinValue;
            }
            set
            {
                IValueManager<DateTime> valueManager = ValueManager.GetValueManager<DateTime>(nameof(MyDateTimeProperty));
                if (valueManager.CanManageValue)
                    valueManager.Value = value;
            }
        }

    }
}
