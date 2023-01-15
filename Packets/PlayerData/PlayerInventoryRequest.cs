using System;
using Shared.Packets.Core;

namespace Shared.Packets.PlayerData
{
    [Serializable]
    public class PlayerInventoryRequest : IPacket
    {
        public int PlayerId { get; set; }
        public int ClientId { get; set; }
    }
}