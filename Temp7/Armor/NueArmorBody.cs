﻿using TenShadows.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TenShadows.Armor
{
    // The AutoloadEquip attribute automatically attaches an equip texture to this item.
    // Providing the EquipType.Body value here will result in TML expecting X_Arms.png, X_Body.png and X_FemaleBody.png sprite-sheet files to be placed next to the item's main texture.
    [AutoloadEquip(EquipType.Body)]
    public class NueArmorBody : ModItem
    {

        public override void SetStaticDefaults()
        {

            DisplayName.SetDefault("Feathery Chest Plate");
            Tooltip.SetDefault("Slightly increases max health");
        }

        public override void SetDefaults()
        {
            Item.width = 34; // Width of the item
            Item.height = 22; // Height of the item
            Item.value = Item.sellPrice(gold: 1); // How many coins the item is worth
            Item.rare = ItemRarityID.Blue; // The rarity of the item
            Item.defense = 4; // The amount of defense the item will give when equipped
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 20;
        }

        // Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient<NueFeather>(12)
        .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}