using System.Collections.Generic;
using Terraria;
using Microsoft.Xna.Framework;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Weapons
{ 
    public class ShenalsBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("ShenalsBow"); //Bow Name
            Tooltip.SetDefault("This is a OP Bow"); //Bow Description
        }
        public override void SetDefaults()
        {
            item.damage = 1000; //The Bow Damage
            item.noMelee = true; //So The Ttem's Animation Doesn't do Damage
            item.ranged = true; //Its A Bow So its True
            item.width = 25; //Bow Image Width
            item.height = 25; //Bow Image Height
            item.useTime = 30; //How Fast
            item.useAnimation = 30; //The Animation
            item.useStyle = 5; //The Style
            item.shoot = 3; //Its What Makes It Shoot
            item.useAmmo = AmmoID.Arrow;
            item.knockBack = 1; //How Far It Knocks You Back
            item.value = 10000; //How Much The Bow Is Worth 
            item.rare = 7; //Rarity Of The Bow
            item.UseSound = SoundID.Item5; //The Sound
            item.autoReuse = true; //Lets You Reuse It
            item.shootSpeed = 10f; //How Fast the Gun Shoots

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FrostburnArrow, damage, knockBack, player.whoAmI, 0f, 0f); //This is spawning a projectile of type FrostburnArrow using the original stats
            return false; //Makes Sure Its Not Fire
        }

        public override void AddRecipes() //How to Craft this Sword
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1); 
            recipe.AddTile(TileID.WorkBenches);          
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}