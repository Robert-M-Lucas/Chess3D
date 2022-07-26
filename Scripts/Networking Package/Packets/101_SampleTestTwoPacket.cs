using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class SampleTestTwoPacket {
    public const int UID = 101;
    public int RID;
    public int ArgOne;
    public double ArgTwo;
    public string ArgThree;
    public string ArgFour;
    public SampleTestTwoPacket(Packet packet){
        RID = packet.RID;
        ArgOne = BitConverter.ToInt32(packet.Contents[0]);
        ArgTwo = BitConverter.ToDouble(packet.Contents[1]);
        ArgThree = ASCIIEncoding.ASCII.GetString(packet.Contents[2]);
        ArgFour = ASCIIEncoding.ASCII.GetString(packet.Contents[3]);
    }

    public static byte[] Build(int _RID, int _ArgOne, double _ArgTwo, string _ArgThree, string _ArgFour="defaultVal") {
            List<byte[]> contents = new List<byte[]>();
            contents.Add(BitConverter.GetBytes(_ArgOne));
            contents.Add(BitConverter.GetBytes(_ArgTwo));
            contents.Add(ASCIIEncoding.ASCII.GetBytes(_ArgThree));
            contents.Add(ASCIIEncoding.ASCII.GetBytes(_ArgFour));
            return PacketBuilder.Build(UID, contents, _RID);
    }
}