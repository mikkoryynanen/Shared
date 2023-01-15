using System;
using Shared.Models;
using Shared.Packets.Core;

namespace Shared.Packets.PlayerData
{
    [Serializable]
    public class PlayerInventoryResponse : IPacket
    {
        public Item[] Items { get; set; }
    }
}