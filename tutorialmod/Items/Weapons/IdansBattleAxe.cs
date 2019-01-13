using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Weapons
{
	public class IdansBattleAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("BattleAxe");
			Tooltip.SetDefault("This is an OP Battle Axe");
		}
		public override void SetDefaults()
		{
			item.damage = 1000000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 99999;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
