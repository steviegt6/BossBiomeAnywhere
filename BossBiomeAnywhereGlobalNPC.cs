using Terraria.ModLoader;
using Terraria.ID;
using Terraria;

namespace BossBiomeAnywhere
{
	public class BossBiomeAnywhereGlobalNPC : GlobalNPC
	{
		internal static int[] biomeBosses = { NPCID.EaterofWorldsHead, NPCID.BrainofCthulhu, NPCID.Plantera };

		public static int EaterofWorlds = -1;
		public static int BrainofCthulhu = -1;
		public static int Plantera = -1;

		public override bool PreAI(NPC npc)
		{
			switch (npc.type)
				{
				case NPCID.EaterofWorldsHead:
					EaterofWorlds = npc.whoAmI;
					break;

				case NPCID.BrainofCthulhu:
					BrainofCthulhu = npc.whoAmI;
					break;

				case NPCID.Plantera:
					Plantera = npc.whoAmI;
					break;
			}
			return true;
		}
		public static bool BiomeBossActive(ref int biomeBosses, int bossType)
		{
			if (biomeBosses != -1)
			{
				if (Main.npc[biomeBosses].active && Main.npc[biomeBosses].type == bossType)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
		public BossBiomeAnywhereGlobalNPC()
		{
		}
	}
}