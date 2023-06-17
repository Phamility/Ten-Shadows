﻿using System; using TenShadows.Buffs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Bestiary;
using Terraria.GameContent.ItemDropRules;
using Terraria.ModLoader.Utilities;
using Terraria.Audio;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using IL.Terraria.GameContent.Personalities;
using On.Terraria.GameContent.Personalities;
using static Terraria.ModLoader.PlayerDrawLayer;
using TenShadows.Projectiles;

namespace TenShadows.Items.Materials
{
    public class CursedEnergy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cursed Energy");
            Tooltip.SetDefault("With proper technique, it can be wielded\nCursed energy must be stacked accordingly to utilize weapons");
            Main.RegisterItemAnimation(Item.type, new DrawAnimationVertical(45, 2));

            ItemID.Sets.AnimatesAsSoul[Item.type] = true; // Makes the item have an animation while in world (not held.). Use in combination with RegisterItemAnimation

          //  ItemID.Sets.ItemIconPulse[Item.type] = true; // The item pulses while in the player's inventory
            ItemID.Sets.ItemNoGravity[Item.type] = true; // Makes the item have no gravity

        }

        public override void SetDefaults()
        {
            Item.ammo = Item.type;
            Item.consumable = true;
            Item.width = 28;
            Item.height = 32;
            Item.maxStack = 9999;
            Item.value = 0; // Makes the item worth 1 gold.
            Item.rare = ItemRarityID.Blue;
        }
        public override bool CanBeConsumedAsAmmo(Item weapon, Player player)
        {
            return true;        }


    }
}

