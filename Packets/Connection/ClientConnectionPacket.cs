using System;
using Shared.Packets.Core;

namespace Shared.Packets.Connection
{
    [Serializable]
    public class ClientConnectionPacket : IPacket
    {
        public int ClientId { get; set; }
    }
}