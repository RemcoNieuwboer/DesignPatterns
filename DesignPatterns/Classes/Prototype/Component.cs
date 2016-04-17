using System;

namespace DesignPatterns.Classes.Prototype
{
    [Serializable]
    public class Component : Prototype<Component>
    {
        public ComponentData ComponentData;

        public Component()
        {
            ComponentData = new ComponentData();
        }

        public void SetComponentData(Settings setting)
        {
            ComponentData.Config(setting);
        }

        public override string ToString()
        {
            return String.Format("componentdata: {0}, {1}, {2}",

                ComponentData.Property1,
                ComponentData.Property2,
                ComponentData.Property3);

        }
    }
}