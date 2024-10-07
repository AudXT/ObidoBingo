using Neto.Server;
using System.Collections.Concurrent;

namespace ObidoBingoServer
{
    public record SerializableServerData(ConcurrentDictionary<string, ServerRoom> Rooms, ConcurrentDictionary<string, ClientIdentity> Identities);
}
