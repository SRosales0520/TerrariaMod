using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    public class IdansChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Idan's Chestplate");
            Tooltip.SetDefault("This is a modded body armor"
                                + "Gives regeneration");

        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.rare = 9;
            item.defense = 1; 
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Regeneration] = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}