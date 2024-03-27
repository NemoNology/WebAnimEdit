using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Enums
{
    public static class BlocksOfProperties
    {
        /// <summary>
        /// Transform block of properties that contains base transform properties: translate, rotate and scale
        /// </summary>
        public static BlockOfProperties Transform =>
            new(Emums.BlockOfPropertiesType.AnimationTransform,
                new() {
                    { "translateX", "0px" }, { "translateY", "0px" },
                    { "rotate", "0deg" }, { "scaleX", "1" }, { "scaleY", "1" },
                });

        /// <summary>
        /// Style block of properties that contains base style properties:
        /// canvas position (left, top), absolute positioning, size (width, height), z-index
        /// </summary>
        public static BlockOfProperties Style =>
            new(Emums.BlockOfPropertiesType.Style,
            new() {
                {"left", "0px"}, {"top", "0px"}, {"position", "absolute"},
                {"width", "0px"}, {"height", "0px"}, {"z-index", "0"},
            });
    }
}