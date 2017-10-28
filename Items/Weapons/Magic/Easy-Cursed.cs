using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace lightsword.Items.Weapons.Magic
{
    public class Easy_Cursed : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Curse of the Flames");
            Tooltip.SetDefault("This is a modded Spell.");
        }
        public override void SetDefaults()
        {
            item.damage = 20;
            item.magic = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 7;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = 95;
            item.shootSpeed = 15f;
            item.mana = 5;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            
            recipe.AddIngredient(ItemID.DirtBlock, 20);
           
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}