using Terraria;
using Terraria.ModLoader;

namespace BugTestMod.Content; 

public class TestNPC1 : ModNPC {
    public override void SetStaticDefaults() {
        Main.npcFrameCount[NPC.type] = 2;
    }
    
    public override void SetDefaults() {
        NPC.width = 36;
        NPC.height = 36;
        NPC.damage = 10;
        NPC.defense = 2;
        NPC.lifeMax = 30;

    }

}