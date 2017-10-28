using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace lightsword.Items.Weapons.Ranged
{
    public class Sniper_Beginning : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sniper");
            Tooltip.SetDefault("This is a modded sniper.");
        }
        public override void SetDefaults()
        {
            item.damage = 70;
            item.ranged = true;
            item.width = 60;
            item.height = 50;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shoot = 279;
            item.shootSpeed = 15f;
            item.scale = 1.5f;
            
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
