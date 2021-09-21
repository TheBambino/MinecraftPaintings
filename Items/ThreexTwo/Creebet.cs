using Terraria.ModLoader;
using Terraria.ID;

namespace MinecraftPaintings.Items.ThreexTwo {
    public class Creebet : MCPaintingItem {
        public override MCPaintingType PaintingType => MCPaintingType.ThreeByTwo;

        public override void SafeSetStaticDefaults() {
            DisplayName.SetDefault("Creebet");
            Tooltip.SetDefault(DefaultTooltip);
        }

        public override void SafeSetDefaults() {
            PaintingPlaceStyle = 1;
        }
    }
}