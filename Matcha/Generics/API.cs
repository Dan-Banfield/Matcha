using WeAreDevs_API;

namespace Matcha.Generics
{
    public static class API
    {
        #region Properties

        private static ExploitAPI weAreDevsAPI;

        private static ExploitAPI weAreDevsAPIInstace
        {
            get
            {
                if (weAreDevsAPI == null)
                    weAreDevsAPI = new ExploitAPI();
                return weAreDevsAPI;
            }
        }

        public enum AvailableAPIs { WeAreDevs = 0, EasyExploits = 1, Comet = 2 }

        public static AvailableAPIs SelectedAPI
        {
            get
            {
                return (AvailableAPIs)Properties.Settings.Default.selectedAPI;
            }
            set
            {
                Properties.Settings.Default.selectedAPI = (int)value;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        public static void ExecuteScript(string scriptToExecute)
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    weAreDevsAPIInstace.SendLuaScript(scriptToExecute);
                    break;
                case AvailableAPIs.EasyExploits:
                    // TODO: Add script execution code.
                    break;
                case AvailableAPIs.Comet:
                    // TODO: Add script execution code.
                    break;
            }
        }

        public static void Attach()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    weAreDevsAPIInstace.LaunchExploit();
                    break;
                case AvailableAPIs.EasyExploits:
                    // TODO: Add attach code.
                    break;
                case AvailableAPIs.Comet:
                    // TODO: Add attach code.
                    break;
            }
        }

        public static bool IsAttached()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    return weAreDevsAPIInstace.isAPIAttached();
                case AvailableAPIs.EasyExploits:
                    // TODO: Add attach check code.
                    break;
                case AvailableAPIs.Comet:
                    // TODO: Add attach check code.
                    break;
            }
            return false;
        }
    }
}
