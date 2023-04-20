using SomeLagacyLib.Interfaces;

namespace SomeLagacyLib
{
    public class Pikachu : ILegacyAnimal
    {
        public Pikachu(string name)
        {
            Name = name;
        }

        protected string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public string LegacySpeakMethod()
        {
            return $"{Name} says Pika-choo!";
        }
    }
}