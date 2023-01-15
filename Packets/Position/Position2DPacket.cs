using System;
using Shared.Packets.Core;

namespace Shared.Packets.Position
{
    [Serializable]
    public class Position2DPacket : IPacket
    {
        public string ClientId { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}