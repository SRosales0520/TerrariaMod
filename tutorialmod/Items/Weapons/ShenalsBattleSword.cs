using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Weapons
{
	public class ShenalsBattleSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shenals Battle Sword"); //Sword Name
			Tooltip.SetDefault("This is a OP Sword"); //Sword Description
		}
		public override void SetDefaults()
		{
			item.damage = 1000; //The Sword Damage
			item.melee = true; //So the Items Animation Will do Damage
			item.width = 40; //Sword Image Width
			item.height = 40; //Sword Image Height
			item.useTime = 20; //How Fast
			item.useAnimation = 20; //The Animation
			item.useStyle = 1; //The Style
			item.knockBack = 6; //How Far It Knocks You Back
            item.value = 10000; //How Much the Sword Is Worth
			item.rare = 2; //The Sword Rarity
			item.UseSound = SoundID.Item1; //The Sound
			item.autoReuse = true; //Lets you Reuse It			item.shoot = mod.ProjectileType("FireCoreBullet");			item.shootSpeed = 50f;
        }

		public override void AddRecipes() //How To Craft This Gun
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1); //You Will Need 1 Dirt Block
            recipe.AddTile(TileID.WorkBenches); //At The Work Bench
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
