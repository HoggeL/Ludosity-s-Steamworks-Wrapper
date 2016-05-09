#if CSHARP
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagedSteam
{
#endif

#if CPLUSPLUS
namespace SteamAPIWrap
{
    struct EOverlayDialogToUser
    {

    enum Enum
#endif
#if CSHARP
    public enum OverlayDialogToUser
#endif
    {
        SteamId,
        Chat,
        JoinTrade,
        Stats,
        Achievements
    }
#if CPLUSPLUS
        ;
    };
#endif

} // namespace, used by both C# and C++
