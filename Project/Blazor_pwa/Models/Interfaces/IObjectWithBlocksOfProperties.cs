namespace Blazor_pwa.Models.Interfaces
{
    public interface IObjectWithBlocksOfProperties
    {
        /// <summary>
        /// Object blocks of properties
        /// </summary>
        public BlockOfProperties[] Blocks { get; }
    }
}