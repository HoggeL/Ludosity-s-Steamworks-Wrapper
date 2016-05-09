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
    struct ECallbackID
    {

    enum Enum
#endif
#if CSHARP
    enum CallbackID
#endif
    {
        // <Stats>
        UserStatsReceived,
        UserStatsStored,
        UserAchievementStored,
        UserStatsUnloaded,
        UserAchievementIconFetched,
        // </Stats>

        // <Friends>
        PersonaStateChange,
        GameOverlayActivated,
        GameServerChangeRequested,
        GameLobbyJoinRequested,
        AvatarImageLoaded,
        GameRichPresenceJoinRequested,
        FriendRichPresenceUpdate,
        GameConnectedClanChatMsg,
        GameConnectedChatJoin,
        GameConnectedChatLeave,
        GameConnectedFriendChatMsg,
        // </Friends>

        //<MatchMaking>
        FavoritesListChanged,
        LobbyInvite,
        LobbyDataUpdate,
        LobbyChatUpdate,
        LobbyChatMsg,
        LobbyGameCreated,
        LobbyKicked,
        //</MatchMakin>

        // <SteamUser>
        SteamServersConnected,
        SteamServerConnectFailure,
        SteamServersDisconnected,
        ClientGameServerDeny,
        IPCFailure,
        ValidateAuthTicketResponse,
        MicroTxnAuthorizationResponse,
        GetAuthSessionTicketResponse,
        GameWebCallback,
        // </SteamUser>

        // <GameServer>
        GSClientApprove,
        GSClientDeny,
        GSClientKick,
        GSClientAchievementStatus,
        GSPolicyResponse,
        GSGameplayStats,
        GSClientGroupStatus,
        // </GameServer>


        //<GameServerStats>
        GSStatsUnloaded,
        //</GameServerStats>

        //<Networking>
        P2PSessionConnectFail,
        P2PSessionRequest,
        SocketStatusCallback,
        //</Networking>


        //<Utils>
        IPCountry,
        LowBatteryPower,
        SteamShutdown,
        CheckFileSignature,
        GamepadTextInputDismissed,
        //</Utils>


        //<Apps>
        DlcInstalled,
        RegisterActivationCodeResponse,
        AppProofOfPurchaseKeyResponse,
        //</Apps>

        //<HTTP>
        HTTPRequestHeadersReceived,
        HTTPRequestDataReceived,
        //</HTTP>

        //<Screenshots>
        ScreenshotReady,
        ScreenshotRequested,
        //</Screenshots>
    }
#if CPLUSPLUS
        ;
    };
#endif

} // namespace, used by both c# and C++
