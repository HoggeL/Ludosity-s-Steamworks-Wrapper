using System;
using System.Collections.Generic;
using System.Text;

namespace ManagedSteam
{
    /// <summary>
    /// Do not use. Will be removed. Use the Constants class instead.
    /// </summary>
    public class Settings
    {
        internal Settings()
        {

        }

        /// <summary>
        /// Obsolete: Use the StatNameMax in the Constants.Stats class instead.
        /// </summary>
        [Obsolete("Use the StatNameMax in the Constants.Stats class instead.")]
        public const int AchievementNameMaxLength = 128;
        /// <summary>
        /// Obsolete: Use the values in the Constants class instead.
        /// </summary>
        [Obsolete("Use the values in the Constants class instead.")]
        public const int StatNameMaxLength = 128;
        /// <summary>
        /// Obsolete: Use the values in the Constants class instead.
        /// </summary>
        [Obsolete("Use the values in the Constants class instead.")]
        public const int LeaderboardNameMaxLength = 128;
        /// <summary>
        /// Obsolete: Use the values in the Constants class instead.
        /// </summary>
        [Obsolete("Use the values in the Constants class instead.")]
        public const int LeaderboardMaxDetails = 64;

        /// <summary>
        /// Obsolete: Use the values in the Constants class instead.
        /// </summary>
        [Obsolete("Use the values in the Constants class instead.")]
        public const int CloudFilenameMaxLength = 260;
    }
}
