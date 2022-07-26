using System;
using System.Collections;
using System.Collections.Generic;

public class SampleServerPacketHandler : PacketHandlerParent
{
    public override Dictionary<int, Action<Packet>> UIDtoAction { get; } =
        new Dictionary<int, Action<Packet>>
        {
            { 100, (Packet p) => HandlePacketWithUIDOneHundred(p) } // {UID, Function}
        };

    public SampleServerPacketHandler()
    {
        UIDtoAction.Add(100, (Packet p) => HandlePacketWithUIDThreeHundred(p));
    }

    public static void HandlePacketWithUIDOneHundred(Packet packet)
    {
        SampleTestPacket sample_test_packet = new SampleTestPacket(packet); // This packet is defined in Packets.txt
        ServerLogger.ServerLog(sample_test_packet.ArgFour);
    }

    public void HandlePacketWithUIDThreeHundred(Packet packet)
    {
        SampleTestPacket sample_test_packet = new SampleTestPacket(packet); // This packet is defined in Packets.txt
        ServerLogger.ServerLog(sample_test_packet.ArgFour);
    }
}
