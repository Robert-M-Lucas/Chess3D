using System;
using System.Collections;
using System.Collections.Generic;

public class ServerClientParent
{
    public List<PacketHandlerParent> DefaultHierachy = new List<PacketHandlerParent>();

    public bool Stopping = false;
}
