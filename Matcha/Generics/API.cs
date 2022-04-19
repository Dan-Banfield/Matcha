namespace Matcha.Generics
{
    public static class API
    {
        #region Properties

        public enum AvailableAPIs { WeAreDevs, EasyExploits, Comet }
        public static AvailableAPIs SelectedAPI = AvailableAPIs.WeAreDevs;

        #endregion

        public static void ExecuteScript()
        {
            switch (SelectedAPI)
            {
                case AvailableAPIs.WeAreDevs:
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
                    break;
                case AvailableAPIs.EasyExploits:
                    break;
                case AvailableAPIs.Comet:
                    break;
            }
        }
    }
}
