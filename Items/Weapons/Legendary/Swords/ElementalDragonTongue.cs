using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace AwakeningMinerals.Items.Weapons.Legendary.Swords
{
    public class ElementalDragonTongue : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Elemental DragonTongue");
            Tooltip.SetDefault("Shoot 8 blades\nApply all Elementals Debuff");

        }

        public override void SetDefaults()
        {
            item.damage = 400;
            item.melee = true;
            item.width = 116;
            item.height = 122;
            item.useTime = 15;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = Item.sellPrice(gold: 2);
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.useTurn = true;
            item.crit = 4;
            
			item.shootSpeed = 4f;
            item.shoot = mod.ProjectileType("ElementalDragonTongueProj");
        }
        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            if (Main.rand.NextBool(3))
            {
                //Emit dusts when swing the sword
                Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, ModContent.DustType<Dusts.ElementalMurasamaDust>());
            }
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 origVect = new Vector2(speedX, speedY);
			//generate the remaining projectiles

			Vector2 newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj1"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj2"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj3"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj41"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
            Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj5"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
            Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj6"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
            Projectile.NewProjectile(position.X, position.Y, newVect.X, newVect.Y, mod.ProjectileType("ElementalDragonTongueProj7"), damage, knockBack, player.whoAmI, 0f, 0f);
			newVect = origVect.RotatedBy(System.Math.PI / (Main.rand.Next(72, 1800) / 10));
			Projectile.NewProjectile(position.X, position.Y, newVect.X * 1.5f, newVect.Y * 1.5f, mod.ProjectileType("ElementalDragonTongueProj8"), damage, knockBack, player.whoAmI, 0f, 0f);

			return false;
		}

        public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(mod.BuffType("AirDebuff"), 120, true);
            target.AddBuff(mod.BuffType("EarthDebuff"), 120, true);
            target.AddBuff(mod.BuffType("WaterDebuff"), 120, true);
            target.AddBuff(mod.BuffType("IceDebuff"), 120, true);
            target.AddBuff(mod.BuffType("FireDebuff"), 120, true);
            target.AddBuff(mod.BuffType("DeathDebuff"), 120, true);
            target.AddBuff(mod.BuffType("ThunderDebuff"), 120, true);
            target.AddBuff(mod.BuffType("LightDebuff"), 120, true);
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.AirDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.DeathDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.EarthDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.FireDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.IceDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.ThunderDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.LightDragonTongue>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Items.Weapons.Elemental.Sword.WaterDragonTongue>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}