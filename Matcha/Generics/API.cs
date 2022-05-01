using WeAreDevs_API;

namespace Matcha.Generics
{
    public static class API
    {
        #region Properties

        public enum AvailableAPIs { WeAreDevs, EasyExploits, Comet }

        public static AvailableAPIs SelectedAPI
        {
            get
            {
                switch (Properties.Settings.Default.selectedAPI)
                {
                    case 0:
                        return AvailableAPIs.WeAreDevs;
                    case 1:
                        return AvailableAPIs.EasyExploits;
                    case 2:
                        return AvailableAPIs.Comet;
                }
                return AvailableAPIs.WeAreDevs;
            }
            set
            {
                switch (value)
                {
                    case AvailableAPIs.WeAreDevs:
                        Properties.Settings.Default.selectedAPI = 0;
                        break;
                    case AvailableAPIs.EasyExploits:
                        Properties.Settings.Default.selectedAPI = 1;
                        break;
                    case AvailableAPIs.Comet:
                        Properties.Settings.Default.selectedAPI = 2;
                        break;
                }
                Properties.Settings.Default.Save();
            }
        }

        private static ExploitAPI weAreDevsAPI = new ExploitAPI();

        #endregion

        public static void ExecuteScript(string scriptToExecute)
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    weAreDevsAPI.SendLuaScript(scriptToExecute);
                    break;
                case AvailableAPIs.EasyExploits:
                    break;
                case AvailableAPIs.Comet:
                    break;
            }
        }

        public static void Attach()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    weAreDevsAPI.LaunchExploit();
                    break;
                case AvailableAPIs.EasyExploits:
                    break;
                case AvailableAPIs.Comet:
                    break;
            }
        }

        public static bool isAttached()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    return weAreDevsAPI.isAPIAttached();
                case AvailableAPIs.EasyExploits:
                    return false;
                case AvailableAPIs.Comet:
                    return false;
            }
            return false;
        }
    }
}
