using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace lightsword.Items.Weapons.Magic
{
    public class Easy_Ichor : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Book of Ichor");
            Tooltip.SetDefault("This is a modded Spell.");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.magic = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = 280;
            item.shootSpeed = 15f;
            item.mana = 10;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 1);
            recipe.AddIngredient(ItemID.DirtBlock, 20);
           
            recipe.SetResult(this);
            recipe.AddRecipe(); //hey, if you're looking at this, if any of the code or .png's in this mod are somewhat copyright, i am new to this and this mod is the first time using C#. i used a mod skeleton from the fourums and public code snippets.
        }
    }
}