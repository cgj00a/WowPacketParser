using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct CliChatLeaveChannel
    {
        public int ZoneChannelID;
        public string ChannelName;
    }
}