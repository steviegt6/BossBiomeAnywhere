using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace BossBiomeAnywhere
{
	public class BossBiomeAnywhereGlobalItem : GlobalItem
	{
		public override bool CanUseItem(Item item, Player player)
		{
			if (item.type == ItemID.WormFood)
			{
				player.ZoneCorrupt = true;
				return true;
			}
			else if (item.type == ItemID.BloodySpine)
			{
				player.ZoneCrimson = true;
				return true;
			}
			else
				return base.CanUseItem(item, player);
		}
		public BossBiomeAnywhereGlobalItem()
		{
		}
	}
}