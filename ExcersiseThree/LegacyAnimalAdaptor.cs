using SomeLagacyLib;
using SomeLagacyLib.Interfaces;

namespace ExcersiseThree
{
    public class LegacyAnimalAdaptor : Animal
    {
        private ILegacyAnimal _legacyAnimal;

        public LegacyAnimalAdaptor(ILegacyAnimal legacyAnimal)
        {
            this._legacyAnimal = legacyAnimal;
        }

        public override string Speak()
        {
            return _legacyAnimal.LegacySpeakMethod();
        }
    }
}
