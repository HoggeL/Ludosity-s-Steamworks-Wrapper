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
    struct ELoadStatus
    {

    enum Enum
#endif
#if CSHARP
    /// <summary>
    /// The load status of the native dll
    /// </summary>
    enum LoadStatus
#endif
    {
        NotLoaded,
        Loaded,
        Unloaded,
    }
#if CPLUSPLUS
        ;
    };
#endif

} // namespace, used by both c# and C++
