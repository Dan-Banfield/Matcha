using WeAreDevs_API;

namespace Matcha.Generics
{
    public static class API
    {
        #region Properties

        public enum AvailableAPIs { WeAreDevs, EasyExploits, Comet }
        public static AvailableAPIs SelectedAPI = AvailableAPIs.WeAreDevs;

        private static ExploitAPI weAreDevsAPI = new ExploitAPI();

        #endregion

        public static void ExecuteScript(string scriptToExecute)
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    weAreDevsAPI.SendLuaCScript(scriptToExecute);
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
    }
}
