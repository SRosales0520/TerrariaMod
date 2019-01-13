using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Weapons
{
    public class SamuelsGun : ModItem
    {
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int a = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, Main.myPlayer);
            Main.projectile[a].friendly = true;
            Main.projectile[a].hostile = false;
            return true;
        }
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("SamuelsGun");
	    Tooltip.SetDefault("This is a op modded sword.");
 //gun description
        }
        public override void SetDefaults()
        {  
            item.damage = 4000;  //gun damage
            item.ranged = true;   //its a gun so set this to true
            item.width = 38;     //gun image width
            item.height = 18;   //gun image  height
            item.useTime = 20;  //how fast 
            item.useAnimation = 8;
            item.useStyle = 5;    //
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 4;
            item.value = 10000;
            item.rare = 2;
            item.autoReuse = true;
            item.shoot = 10; //idk why but all the guns in the vanilla source have this
            item.shootSpeed = 50f;
	    item.useAmmo = AmmoID.Bullet;
            
        }

        public override void AddRecipes()  //How to craft this gun
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);   //you need 1 DirtBlock
            recipe.AddTile(TileID.WorkBenches);   //at work bench
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}