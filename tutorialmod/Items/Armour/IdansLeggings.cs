using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace tutorialmod.Items.Armour
{
    [AutoloadEquip(EquipType.Legs)]
    public class IdansLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is Idans modded leg armor."
                + "\n10% increased movement speed");
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
            player.moveSpeed += 0.1f;
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