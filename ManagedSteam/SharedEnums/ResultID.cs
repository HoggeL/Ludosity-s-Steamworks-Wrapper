﻿#if CSHARP
using System;
using System.Collections.Generic;
using System.Text;

namespace ManagedSteam
{
#endif

#if CPLUSPLUS
namespace SteamAPIWrap
{
    struct EResultID
    {

    enum Enum
#endif
#if CSHARP
    /// <summary>
    /// Id for async result callbacks.
    /// </summary>
    enum ResultID
#endif
    {
        // <RemoteStorage>
        CloudFileShareResult,
        CloudDownloadUGCResult,
        CloudPublishFileResult,

        CloudUpdatePublishedFileResult,
        CloudGetPublishedFileDetailsResult,
        CloudDeletePublishedFileResult,
        CloudEnumerateUserPublishedFilesResult,
        CloudSubscribePublishedFileResult,
        CloudEnumerateUserSubscribedFilesResult,
        CloudUnsubscribePublishedFileResult,
        CloudGetPublishedItemVoteDetailsResult,
        CloudUpdateUserPublishedItemVoteResult,
        CloudUserVoteDetails,
        CloudEnumerateUserSharedWorkshopFilesResult,
        CloudSetUserPublishedFileActionResult,
        CloudEnumeratePublishedFilesByUserActionResult,
        CloudEnumerateWorkshopFilesResult,

        // </RemoteStorage>

        // <Stats>
        LeaderboardFindResult,
        LeaderboardScoresDownloaded,
        LeaderboardScoreUploaded,
        LeaderboardUGCSet,
        NumberOfCurrentPlayers,
        GlobalAchievementPercentagesReady,
        GlobalStatsReceived,

        // </Stats>


        // <Friends>
        DownloadClanActivityCountsResult,
        ClanOfficerListResponse,
        JoinClanChatRoomCompletionResult,
        FriendsGetFollowerCount,
        FriendsIsFollowing,
        FriendsEnumerateFollowingList,
        // </Friends>



        //MatchMaking
        LobbyMatchList,
        LobbyCreated,
        LobbyEnterResult,
        // MatchMaking

        // <SteamUser>
        EncryptedAppTicketResponse,
        // </SteamUser>

        // <GameServer>
        GSReputation,
        AssociateWithClanResult,
        ComputeNewPlayerCompatibilityResult,
        // </GameServer>


        // <GameServerStats>
        GSStatsReceived,
        GSStatsStored,
        // </GameServerStats>

        //<HTTP>
        HTTPRequestCompleted,
        //</HTTP>
    }
#if CPLUSPLUS
        ;
    };
#endif

} // namespace, used by both c# and C++
