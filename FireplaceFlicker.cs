using MSCLoader;
using UnityEngine;

namespace FireplaceFlicker
{
    public class FireplaceFlicker : Mod
    {
        private GameObject home_fireplace;
        private GameObject portable_grill;
        private GameObject cottage_grill;
        private GameObject cottage_fireplace;
        private GameObject cottage_sauna;
        public override string ID => "FireplaceFlicker";
        public override string Name => "Fireplace flicker";
        public override string Author => "ensimed";
        public override string Version => "1.0";
        public override string Description => "Adds forgotten flicker to fireplaces, it ain't much, but it's honest work";

        public override void ModSetup()
        {
            SetupFunction(Setup.OnLoad, Mod_OnLoad);
        }

        public override void ModSettings()
        {
            // All settings should be created here. 
            // DO NOT put anything else here that settings or keybinds
        }

        private void Mod_OnLoad()
        {
            home_fireplace = GameObject.Find("YARD/Building/LIVINGROOM/Fireplace/Flame");
            home_fireplace.AddComponent<HomeFireplace>();
            portable_grill = GameObject.Find("ITEMS/grill(itemx)/Fireplace/Flame");
            portable_grill.AddComponent<PortableGrill>();
            cottage_fireplace = GameObject.Find("COTTAGE/Fireplace/Flame");
            cottage_fireplace.AddComponent<CottageFireplace>();
            cottage_grill = GameObject.Find("COTTAGE/Grill/Fireplace/Flame");
            cottage_grill.AddComponent<CottageGrill>();
            cottage_sauna = GameObject.Find("COTTAGE/Sauna/Stove/Flame");
            cottage_sauna.AddComponent<CottageSauna>();
        }
    }
}
