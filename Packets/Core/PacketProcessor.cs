using System;
using System.Collections.Generic;
using Shared.Packets.Core.Handlers;

namespace Shared.Packets.Core
{
    public class PacketProcessor
    {
        private readonly Dictionary<Type, IPacketHandler> _handlers = new Dictionary<Type, IPacketHandler>();

        public PacketProcessor()
        {
            // TODO Can we finish this?
            // var types = Assembly.GetExecutingAssembly().GetTypes();
            // foreach (var type in types)
            // {
            //     if(type.Namespace == "")
            //         AddHandler((PacketHandler.IPacketHandler)type);
            // }
        }

        public void AddHandler(IPacketHandler handler)
        {
            var type = handler.Type;
            if (_handlers.ContainsKey((type)))
            {
                throw new Exception($"Handler for type {type} already exists");

                // If multiple messages of the same type are supported
                // Use list in dictionary
            }

            _handlers[type] = handler;
        }

        public void Process(IPacket packet)
        {
            if (_handlers.TryGetValue(packet.GetType(), out var handler))
            {
                handler.Handle(packet);
            }
            else
            {
                throw new Exception($"Failed to process packet of type {packet.GetType()}");
            }
        }
    }
}