using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using SomeLagacyLib.Interfaces;

namespace SomeLagacyLib
{
    public class Shinx:ILegacyAnimal
    {
        public string LegacySpeakMethod()
        {
            return $"Shinx makes Quak Quak sound";
        }
    }
}
