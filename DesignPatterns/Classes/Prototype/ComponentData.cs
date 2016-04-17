using System;


namespace DesignPatterns.Classes.Prototype
{
    public enum Settings
    {
        SettingA,
        SettingB
    }

    [Serializable]
    public class ComponentData
    {
        public string Property1;
        public string Property2;
        public int Property3;

        public void Config(Settings setting)
        {
            switch (setting)
            {
                case Settings.SettingA:
                    Property1 = "dots";
                    Property2 = "green";
                    Property3 = 102;
                    break;
                case Settings.SettingB:
                    Property1 = "line";
                    Property2 = "red";
                    Property3 = 33;
                    break;

            }
        }
    }
}