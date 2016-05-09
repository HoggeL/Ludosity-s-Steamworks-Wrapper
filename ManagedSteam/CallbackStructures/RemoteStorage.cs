using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ManagedSteam.SteamTypes;

namespace ManagedSteam.CallbackStructures
{
    using u8 = Byte;
    using s8 = SByte;
    using u16 = UInt16;
    using s16 = Int16;
    using u32 = UInt32;
    using s32 = Int32;
    using u64 = UInt64;
    using s64 = Int64;
    using f32 = Single;
    using f64 = Double;

    using Enum = Int32;

    #region Cloud
    /// <summary>
    /// Wrapper for the \a RemoteStorageFileShareResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking)]
    public struct CloudFileShareResult
    {
        private Result result;
        private UGCHandle handle;

        internal static CloudFileShareResult Create(IntPtr dataPointer, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudFileShareResult>(dataPointer, dataSize);
        }

        public Result Result { get { return result; } }
        public UGCHandle Handle { get { return handle; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageDownloadUGCResult_t struct
    /// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi, Size = 296)]
    public struct CloudDownloadUGCResult
    {
        private Result result;
        private u64 handle;
        private u32 appID;
        private s32 size;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.FileNameMax)]
        private string name;
        private u64 creatorID;


        internal static CloudDownloadUGCResult Create(IntPtr dataPointer, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudDownloadUGCResult>(dataPointer, dataSize);
        }

        public Result Result { get { return result; } }
        public UGCHandle Handle { get { return new UGCHandle(handle); } }
        public SteamTypes.AppID AppID { get { return new AppID(appID); } }
        public int Size { get { return size; } }
        /// <summary>
        /// The name of the shared file
        /// </summary>
        public string FileName { get { return name; } }
        public SteamID CreatorID { get { return new SteamID(creatorID); } }
    };

    /// <summary>
    /// Wrapper for the \a RemoteStoragePublishFileResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudPublishFileResult
    {
        private Result result;
        private PublishedFileId publishedFileId;

        internal static CloudPublishFileResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudPublishFileResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageUpdatePublishedFileResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudUpdatePublishedFileResult
    {
        Result result;
        PublishedFileId publishedFileId;

        internal static CloudUpdatePublishedFileResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudUpdatePublishedFileResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageGetPublishedFileDetailsResult_t struct
    /// </summary>
	//HARDCODED SIZE
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi, Size=9752)]
    public struct CloudGetPublishedFileDetailsResult
    {
        Result result;
        PublishedFileId publishedFileId;
        u32 creatorAppID;
        u32 consumerAppID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.PublishedDocumentTitleMax)]
        string title;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.PublishedDocumentDescriptionMax)]
        string description;
        UGCHandle file;
        UGCHandle previewFile;
        SteamID steamIDOwner;
        u32 timeCreated;
        u32 timeUpdated;
        RemoteStoragePublishedFileVisibility visibility;
        [MarshalAs(UnmanagedType.I1)]
        bool banned;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.TagListMax)]
        string tags;
        [MarshalAs(UnmanagedType.I1)]
        bool tagsTruncated;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.FileNameMax)]
        string fileName;
        s32 fileSize;
        s32 previewFileSize;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = Constants.Cloud.PublishedFileURLMax)]
        string url;

        internal static CloudGetPublishedFileDetailsResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudGetPublishedFileDetailsResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
        public uint CreatorAppID { get { return creatorAppID; } }
        public uint ConsumerAppID { get { return consumerAppID; } }
        public string Title { get { return title; } }
        public string Description { get { return description; } }
        public UGCHandle File { get { return file; } }
        public UGCHandle PreviewFile { get { return previewFile; } }
        public SteamID SteamIDOwner { get { return steamIDOwner; } }
        public uint TimeCreated { get { return timeCreated; } }
        public uint TimeUpdated { get { return timeUpdated; } }
        public RemoteStoragePublishedFileVisibility Visibility { get { return visibility; } }
        public bool Banned { get { return banned; } }
        public string Tags { get { return tags; } }
        public bool TagsTruncated { get { return tagsTruncated; } }
        public string FileName { get { return fileName; } }
        public int FileSize { get { return fileSize; } }
        public int PreviewFileSize { get { return previewFileSize; } }
        public string Url { get { return url; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageDeletePublishedFileResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudDeletePublishedFileResult
    {
        Result result;
        PublishedFileId publishedFileId;

        internal static CloudDeletePublishedFileResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudDeletePublishedFileResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageEnumerateUserPublishedFilesResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudEnumerateUserPublishedFilesResult
    {
        Result result;
        s32 resultsReturned;
        s32 totalResultCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        PublishedFileId[] publishedFileId;

        internal static CloudEnumerateUserPublishedFilesResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudEnumerateUserPublishedFilesResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public int ResultsReturned { get { return resultsReturned; } }
        public int TotalResultCount { get { return totalResultCount; } }
        public PublishedFileId[] PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageSubscribePublishedFileResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudSubscribePublishedFileResult
    {
        Result result;

        internal static CloudSubscribePublishedFileResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudSubscribePublishedFileResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageEnumerateUserSubscribedFilesResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi, Size=616)]
    public struct CloudEnumerateUserSubscribedFilesResult
    {
        Result result;
        s32 resultsReturned;
        s32 totalResultCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        PublishedFileId[] publishedFileId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        u32[] timeSubscribed;

        internal static CloudEnumerateUserSubscribedFilesResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudEnumerateUserSubscribedFilesResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public int ResultsReturned { get { return resultsReturned; } }
        public int TotalResultCount { get { return totalResultCount; } }
        public PublishedFileId[] PublishedFileId { get { return publishedFileId; } }
        public uint[] TimeSubscribed { get { return timeSubscribed; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageUnsubscribePublishedFileResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudUnsubscribePublishedFileResult
    {
        Result result;

        internal static CloudUnsubscribePublishedFileResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudUnsubscribePublishedFileResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageGetPublishedItemVoteDetailsResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudGetPublishedItemVoteDetailsResult
    {
        Result result;
        PublishedFileId publishedFileId;
        s32 votesFor;
        s32 votesAgainst;
        s32 reports;
        f32 score;

        internal static CloudGetPublishedItemVoteDetailsResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudGetPublishedItemVoteDetailsResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
        public int VotesFor { get { return votesFor; } }
        public int VotesAgainst { get { return votesAgainst; } }
        public int Reports { get { return reports; } }
        public float Score { get { return score; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageUpdateUserPublishedItemVoteResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudUpdateUserPublishedItemVoteResult
    {
        Result result;
        PublishedFileId publishedFileId;

        internal static CloudUpdateUserPublishedItemVoteResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudUpdateUserPublishedItemVoteResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageUserVoteDetails_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudUserVoteDetails
    {
        Result result;
        PublishedFileId publishedFileId;
        WorkshopVote vote;

        internal static CloudUserVoteDetails Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudUserVoteDetails>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
        public WorkshopVote Vote { get { return vote; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageEnumerateUserSharedWorkshopFilesResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudEnumerateUserSharedWorkshopFilesResult
    {
        Result result;
        s32 resultsReturned;
        s32 totalResultCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        PublishedFileId[] publishedFileId;

        internal static CloudEnumerateUserSharedWorkshopFilesResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudEnumerateUserSharedWorkshopFilesResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public int ResultsReturned { get { return resultsReturned; } }
        public int TotalResultCount { get { return totalResultCount; } }
        public PublishedFileId[] PublishedFileId { get { return publishedFileId; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageSetUserPublishedFileActionResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudSetUserPublishedFileActionResult
    {
        Result result;
        PublishedFileId publishedFileId;
        WorkshopFileAction action;

        internal static CloudSetUserPublishedFileActionResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudSetUserPublishedFileActionResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public PublishedFileId PublishedFileId { get { return publishedFileId; } }
        public WorkshopFileAction Action { get { return action; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageEnumeratePublishedFilesByUserActionResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudEnumeratePublishedFilesByUserActionResult
    {
        Result result;
        WorkshopFileAction action;
        s32 resultsReturned;
        s32 totalResultCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        PublishedFileId[] publishedFileId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        u32[] timeUpdated;

        internal static CloudEnumeratePublishedFilesByUserActionResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudEnumeratePublishedFilesByUserActionResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public WorkshopFileAction Action { get { return action; } }
        public int ResultsReturned { get { return resultsReturned; } }
        public int TotalResultCount { get { return totalResultCount; } }
        public PublishedFileId[] PublishedFileId { get { return publishedFileId; } }
        public uint[] TimeUpdated { get { return timeUpdated; } }
    }

    /// <summary>
    /// Wrapper for the \a RemoteStorageEnumerateWorkshopFilesResult_t struct
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = NativeHelpers.SteamStructPacking, CharSet = CharSet.Ansi)]
    public struct CloudEnumerateWorkshopFilesResult
    {
        Result result;
        s32 resultsReturned;
        s32 totalResultCount;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        PublishedFileId[] publishedFileId;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = Constants.Cloud.EnumeratePublishedFilesMaxResults)]
        f32[] score;

        internal static CloudEnumerateWorkshopFilesResult Create(IntPtr data, int dataSize)
        {
            return NativeHelpers.ConvertStruct<CloudEnumerateWorkshopFilesResult>(data, dataSize);
        }

        public Result Result { get { return result; } }
        public int ResultsReturned { get { return resultsReturned; } }
        public int TotalResultCount { get { return totalResultCount; } }
        public PublishedFileId[] PublishedFileId { get { return publishedFileId; } }
        public float[] Score { get { return score; } }
    }
    #endregion


}
