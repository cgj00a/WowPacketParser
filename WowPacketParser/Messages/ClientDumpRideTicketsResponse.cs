using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientDumpRideTicketsResponse
    {
        public List<ClientDumpRideTicket> Ticket;
    }
}