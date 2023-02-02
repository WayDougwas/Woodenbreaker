using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace Woodenbreaker.Content.Items.Weapons
{
    class WoodenBreakerSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            //Texts
            DisplayName.SetDefault("Wooden Breaker Sword");
            Tooltip.SetDefault("This is a legendary sword made of wood\nHis power is infinity");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            //Scale
            Item.width = 64;
            Item.height = 64;

            //Animation
            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;

            //Damage
            Item.DamageType = DamageClass.Melee;
            Item.damage = 121;
            Item.knockBack = 5;
            Item.crit = 20;
            Item.autoReuse = true;

            //Misc
            Item.value = Item.buyPrice(gold: 30);
            Item.rare = ItemRarityID.Yellow;

            //Sound
            Item.UseSound = SoundID.Item1;


        }
        public override void AddRecipes()
        {
            //Craft
            CreateRecipe()
                .AddIngredient(ItemID.BrokenHeroSword)
                .AddIngredient(ItemID.ChlorophyteBar, 25)
                .AddIngredient(ItemID.Wood, 300)
                .AddTile(TileID.MythrilAnvil)
                .Register();


        }
    }
}
