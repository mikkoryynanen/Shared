/*
 * Helpful links:
 * https://stackoverflow.com/questions/1477471/design-pattern-for-handling-multiple-message-types
*/

using System;

namespace Shared.Packets.Core.Handlers
{
    public interface IPacketHandler
    {
        Type Type { get; }
        bool Handle(IPacket packet);
    }
    
    public abstract class PacketHandlerBase<T> : IPacketHandler
    {
        public Type Type => typeof(T);

        public bool Handle(IPacket packet)
        {
            if (!(packet is T type)) 
                return false;
            
            Handle(type);
            return true;
        }

        protected abstract void Handle(T packet);
    }
}