using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.TwoxTwo {
    public class Aztec2 : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.TwoByTwo;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Aztec2");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 2;
        }
    }
}