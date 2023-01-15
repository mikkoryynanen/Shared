using System;
using Shared.Packets.Core;

namespace Shared.Packets
{
    [Serializable]
    public class TestPacket : IPacket
    {
        public string Message { get; set; }
    }
}