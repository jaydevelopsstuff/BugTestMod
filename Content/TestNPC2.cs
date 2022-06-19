using Terraria;
using Terraria.ModLoader;

namespace BugTestMod.Content; 

public class TestNPC2 : ModNPC {
    public override void SetStaticDefaults() {
        Main.npcFrameCount[NPC.type] = 2;
    }
    
    public override void SetDefaults() {
        NPC.width = 36;
        NPC.height = 36;
        NPC.damage = 10;
        NPC.defense = 10;
        NPC.lifeMax = 30;
    }
}