using Blazor_pwa.Models.Enums;
using Blazor_pwa.Models.Interfaces;

namespace Blazor_pwa.Models.Implementations
{
    public class KeyFrame : IObjectWithBlocksOfProperties
    {
        private readonly BlockOfProperties[] _blocks = { BlocksOfProperties.Transform };

        public int PercentValue { get; set; }
        public BlockOfProperties[] Blocks => _blocks;
    }
}