using KrnlAPI;
using WeAreDevs_API;
using Matcha.Generics;

namespace Matcha.Generics
{
    public static class API
    {
        #region Properties

        private const string API_NOT_AVAILABLE = "This API is currently not available.";

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

        private static KrnlApi krnlAPI;

        private static KrnlApi krnlAPIInstance
        {
            get
            {
                if (krnlAPI == null)
                    krnlAPI = new KrnlApi();
                return krnlAPI;
            }
        }

        public enum AvailableAPIs { WeAreDevs = 0, Krnl = 1, Comet = 2 }

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
                case AvailableAPIs.Krnl:
                    krnlAPI.Execute(scriptToExecute);
                    break;
                case AvailableAPIs.Comet:
                    MessageBox.ShowInformationMessage(API_NOT_AVAILABLE);
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
                case AvailableAPIs.Krnl:
                    krnlAPIInstance.Inject();
                    break;
                case AvailableAPIs.Comet:
                    MessageBox.ShowInformationMessage(API_NOT_AVAILABLE);
                    break;
            }
        }

        public static bool IsAttached()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
                    return weAreDevsAPIInstace.isAPIAttached();
                case AvailableAPIs.Krnl:
                    return krnlAPIInstance.IsInjected();
                case AvailableAPIs.Comet:
                    return false;
            }
            return false;
        }
    }
}
