using Terraria.ID;
using Terraria.ModLoader;

namespace BossBiomeAnywhere
{
	public class BossBiomeAnywherePlayer : ModPlayer
	{
		public override void PostUpdateEquips()
		{
			base.PostUpdateEquips();
			if (BossBiomeAnywhereGlobalNPC.BiomeBossActive(ref BossBiomeAnywhereGlobalNPC.EaterofWorlds, NPCID.EaterofWorldsHead))
			{
				player.ZoneCorrupt = true;
			}
			if (BossBiomeAnywhereGlobalNPC.BiomeBossActive(ref BossBiomeAnywhereGlobalNPC.BrainofCthulhu, NPCID.BrainofCthulhu))
			{
				player.ZoneCrimson = true;
			}
			if (BossBiomeAnywhereGlobalNPC.BiomeBossActive(ref BossBiomeAnywhereGlobalNPC.EaterofWorlds, NPCID.Plantera))
			{
				player.ZoneJungle = true;
			}
		}
		public BossBiomeAnywherePlayer()
		{
		}
	}
}