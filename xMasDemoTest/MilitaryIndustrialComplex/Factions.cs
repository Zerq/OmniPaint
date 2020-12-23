using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryIndustrialComplex
{
    public enum Factions
    {
        ImperialArms,
        OutbackArms,
        ModularisCorp
    }

    public class PowerPlant {
        public int OutputMax { get; private set; }
        public int OutputPerTurn { get; private set; }
        public int Storage { get; private set; }
        public int Fuel { get; private set; }
        public float Efficency { get; set; }
        public int Hp {get; set;}
    }

    public enum TerrainType { 
        Asphalt,
        Dirt,
        sand,
        Gravel,
        Mud,
        Forest,
        Rocky,
        ShallowWater,
        DeepWater,
        Lava,
        Space
    }

    public enum ArmorType { 
        None,
        Light,
        Medium,
        Heavy,
        Fortified,
        Reactive,
        LightComposit,
        Cermaic,
        Ablative,

    }

    public class Locomotor {
        public Dictionary<TerrainType, float> Efficiencies { get; set; }
    }

}
