using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using MinecraftPaintings.Items.ThreexTwo;

namespace MinecraftPaintings.Tiles {
    public class PaintTile3x2 : ModTile {
        public override void SetStaticDefaults() {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.Width = 3;
            TileObjectData.newTile.Height = 2;
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.newTile.CoordinateHeights = new int[] { 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Painting");
            AddMapEntry(new Color(90, 50, 30), name);
        }

        public override void NumDust(int i, int j, bool fail, ref int num) {
            num = 0;
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY) {
            int style = frameX / 54; // 270px / 5
            var paintingList = new[] {
                ModContent.ItemType<Courbet>(),
                ModContent.ItemType<Creebet>(),
                ModContent.ItemType<Pool>(),
                ModContent.ItemType<Sea>(),
                ModContent.ItemType<Sunset>()
            }; // Array MUST be in same order as corresponding item.placeStyle!
            Item.NewItem(i * 16, j * 16, 16, 48, paintingList[style]);
        }
    }
}