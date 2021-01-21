﻿using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;


namespace FactoryMod.Items.CME
{
    public class MediumCME : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Condensed Monster Energy\nCan be deposited into an Energy Unraveler to be converted into TEX.");
            DisplayName.SetDefault("Medium C.M.E");
        }

        public override void SetDefaults()
        {
            item.rare = ItemRarityID.White;
            item.value = 100;
            item.width = 16;
            item.height = 16;
            item.maxStack = 9999;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemType<SmallCME>(), 10);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            base.AddRecipes();

            recipe.AddIngredient(ItemType<LargeCME>(), 1);
            recipe.SetResult(this, 10);
            recipe.AddRecipe();
            base.AddRecipes();
        }
    }
}
