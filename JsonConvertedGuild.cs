using System;
using System.Collections.Generic;
using System.Text;

namespace BackupBot
{
    public class JsonConvertedGuild
    {


        public class Rootobject
        {
            public string Name { get; set; }
            public int AFKTimeout { get; set; }
            public bool IsEmbeddable { get; set; }
            public int VerificationLevel { get; set; }
            public int MfaLevel { get; set; }
            public int DefaultMessageNotifications { get; set; }
            public int MemberCount { get; set; }
            public int DownloadedMemberCount { get; set; }
            public bool IsConnected { get; set; }
            public long OwnerId { get; set; }
            public Owner Owner { get; set; }
            public string VoiceRegionId { get; set; }
            public object IconId { get; set; }
            public object SplashId { get; set; }
            public DateTime CreatedAt { get; set; }
            public Defaultchannel DefaultChannel { get; set; }
            public object IconUrl { get; set; }
            public object SplashUrl { get; set; }
            public bool HasAllMembers { get; set; }
            public bool IsSynced { get; set; }
            public Syncpromise SyncPromise { get; set; }
            public Downloaderpromise DownloaderPromise { get; set; }
            public object AudioClient { get; set; }
            public Afkchannel AFKChannel { get; set; }
            public object EmbedChannel { get; set; }
            public Textchannel[] TextChannels { get; set; }
            public Voicechannel[] VoiceChannels { get; set; }
            public Currentuser CurrentUser { get; set; }
            public Everyonerole EveryoneRole { get; set; }
            public Channel[] Channels { get; set; }
            public object[] Emotes { get; set; }
            public object[] Features { get; set; }
            public User3[] Users { get; set; }
            public Role6[] Roles { get; set; }
            public long Id { get; set; }
        }

        public class Owner
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public string AvatarId { get; set; }
            public Guildpermissions GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public Game Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Game
        {
            public string Name { get; set; }
            public object StreamUrl { get; set; }
            public int StreamType { get; set; }
        }

        public class Role
        {
            public Color Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Defaultchannel
        {
            public object Topic { get; set; }
            public string Mention { get; set; }
            public object[] CachedMessages { get; set; }
            public User[] Users { get; set; }
            public string Name { get; set; }
            public int Position { get; set; }
            public object[] PermissionOverwrites { get; set; }
            public DateTime CreatedAt { get; set; }
            public long Id { get; set; }
        }

        public class User
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public string AvatarId { get; set; }
            public Guildpermissions1 GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role1[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public Game1 Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions1
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Game1
        {
            public string Name { get; set; }
            public object StreamUrl { get; set; }
            public int StreamType { get; set; }
        }

        public class Role1
        {
            public Color1 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions1 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color1
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions1
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Syncpromise
        {
            public bool Result { get; set; }
            public int Id { get; set; }
            public object Exception { get; set; }
            public int Status { get; set; }
            public bool IsCanceled { get; set; }
            public bool IsCompleted { get; set; }
            public int CreationOptions { get; set; }
            public object AsyncState { get; set; }
            public bool IsFaulted { get; set; }
        }

        public class Downloaderpromise
        {
            public bool Result { get; set; }
            public int Id { get; set; }
            public object Exception { get; set; }
            public int Status { get; set; }
            public bool IsCanceled { get; set; }
            public bool IsCompleted { get; set; }
            public int CreationOptions { get; set; }
            public object AsyncState { get; set; }
            public bool IsFaulted { get; set; }
        }

        public class Afkchannel
        {
            public int Bitrate { get; set; }
            public object UserLimit { get; set; }
            public object[] Users { get; set; }
            public string Name { get; set; }
            public int Position { get; set; }
            public object[] PermissionOverwrites { get; set; }
            public DateTime CreatedAt { get; set; }
            public long Id { get; set; }
        }

        public class Currentuser
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public object AvatarId { get; set; }
            public Guildpermissions2 GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role2[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public object Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions2
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Role2
        {
            public Color2 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions2 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color2
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions2
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Everyonerole
        {
            public Color3 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions3 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color3
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions3
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Textchannel
        {
            public object Topic { get; set; }
            public string Mention { get; set; }
            public object[] CachedMessages { get; set; }
            public User1[] Users { get; set; }
            public string Name { get; set; }
            public int Position { get; set; }
            public Permissionoverwrite[] PermissionOverwrites { get; set; }
            public DateTime CreatedAt { get; set; }
            public long Id { get; set; }
        }

        public class User1
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public string AvatarId { get; set; }
            public Guildpermissions3 GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role3[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public Game2 Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions3
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Game2
        {
            public string Name { get; set; }
            public object StreamUrl { get; set; }
            public int StreamType { get; set; }
        }

        public class Role3
        {
            public Color4 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions4 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color4
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions4
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Permissionoverwrite
        {
            public long TargetId { get; set; }
            public int TargetType { get; set; }
            public Permissions5 Permissions { get; set; }
        }

        public class Permissions5
        {
            public int AllowValue { get; set; }
            public int DenyValue { get; set; }
            public int CreateInstantInvite { get; set; }
            public int ManageChannel { get; set; }
            public int AddReactions { get; set; }
            public int ReadMessages { get; set; }
            public int SendMessages { get; set; }
            public int SendTTSMessages { get; set; }
            public int ManageMessages { get; set; }
            public int EmbedLinks { get; set; }
            public int AttachFiles { get; set; }
            public int ReadMessageHistory { get; set; }
            public int MentionEveryone { get; set; }
            public int UseExternalEmojis { get; set; }
            public int Connect { get; set; }
            public int Speak { get; set; }
            public int MuteMembers { get; set; }
            public int DeafenMembers { get; set; }
            public int MoveMembers { get; set; }
            public int UseVAD { get; set; }
            public int ManagePermissions { get; set; }
            public int ManageWebhooks { get; set; }
        }

        public class Voicechannel
        {
            public int Bitrate { get; set; }
            public object UserLimit { get; set; }
            public object[] Users { get; set; }
            public string Name { get; set; }
            public int Position { get; set; }
            public object[] PermissionOverwrites { get; set; }
            public DateTime CreatedAt { get; set; }
            public long Id { get; set; }
        }

        public class Channel
        {
            public object Topic { get; set; }
            public string Mention { get; set; }
            public object[] CachedMessages { get; set; }
            public User2[] Users { get; set; }
            public string Name { get; set; }
            public int Position { get; set; }
            public Permissionoverwrite1[] PermissionOverwrites { get; set; }
            public DateTime CreatedAt { get; set; }
            public long Id { get; set; }
            public int Bitrate { get; set; }
            public object UserLimit { get; set; }
        }

        public class User2
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public string AvatarId { get; set; }
            public Guildpermissions4 GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role4[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public Game3 Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions4
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Game3
        {
            public string Name { get; set; }
            public object StreamUrl { get; set; }
            public int StreamType { get; set; }
        }

        public class Role4
        {
            public Color5 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions6 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color5
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions6
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Permissionoverwrite1
        {
            public long TargetId { get; set; }
            public int TargetType { get; set; }
            public Permissions7 Permissions { get; set; }
        }

        public class Permissions7
        {
            public int AllowValue { get; set; }
            public int DenyValue { get; set; }
            public int CreateInstantInvite { get; set; }
            public int ManageChannel { get; set; }
            public int AddReactions { get; set; }
            public int ReadMessages { get; set; }
            public int SendMessages { get; set; }
            public int SendTTSMessages { get; set; }
            public int ManageMessages { get; set; }
            public int EmbedLinks { get; set; }
            public int AttachFiles { get; set; }
            public int ReadMessageHistory { get; set; }
            public int MentionEveryone { get; set; }
            public int UseExternalEmojis { get; set; }
            public int Connect { get; set; }
            public int Speak { get; set; }
            public int MuteMembers { get; set; }
            public int DeafenMembers { get; set; }
            public int MoveMembers { get; set; }
            public int UseVAD { get; set; }
            public int ManagePermissions { get; set; }
            public int ManageWebhooks { get; set; }
        }

        public class User3
        {
            public object Nickname { get; set; }
            public bool IsBot { get; set; }
            public string Username { get; set; }
            public int DiscriminatorValue { get; set; }
            public string AvatarId { get; set; }
            public Guildpermissions5 GuildPermissions { get; set; }
            public bool IsWebhook { get; set; }
            public bool IsSelfDeafened { get; set; }
            public bool IsSelfMuted { get; set; }
            public bool IsSuppressed { get; set; }
            public bool IsDeafened { get; set; }
            public bool IsMuted { get; set; }
            public DateTime JoinedAt { get; set; }
            public Role5[] Roles { get; set; }
            public object VoiceChannel { get; set; }
            public string VoiceSessionId { get; set; }
            public object VoiceState { get; set; }
            public object AudioStream { get; set; }
            public int Hierarchy { get; set; }
            public DateTime CreatedAt { get; set; }
            public string Discriminator { get; set; }
            public string Mention { get; set; }
            public Game4 Game { get; set; }
            public int Status { get; set; }
            public long Id { get; set; }
        }

        public class Guildpermissions5
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Game4
        {
            public string Name { get; set; }
            public object StreamUrl { get; set; }
            public int StreamType { get; set; }
        }

        public class Role5
        {
            public Color6 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions8 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color6
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions8
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

        public class Role6
        {
            public Color7 Color { get; set; }
            public bool IsHoisted { get; set; }
            public bool IsManaged { get; set; }
            public bool IsMentionable { get; set; }
            public string Name { get; set; }
            public Permissions9 Permissions { get; set; }
            public int Position { get; set; }
            public DateTime CreatedAt { get; set; }
            public bool IsEveryone { get; set; }
            public string Mention { get; set; }
            public long Id { get; set; }
        }

        public class Color7
        {
            public int RawValue { get; set; }
            public int R { get; set; }
            public int G { get; set; }
            public int B { get; set; }
        }

        public class Permissions9
        {
            public int RawValue { get; set; }
            public bool CreateInstantInvite { get; set; }
            public bool BanMembers { get; set; }
            public bool KickMembers { get; set; }
            public bool Administrator { get; set; }
            public bool ManageChannels { get; set; }
            public bool ManageGuild { get; set; }
            public bool AddReactions { get; set; }
            public bool ReadMessages { get; set; }
            public bool SendMessages { get; set; }
            public bool SendTTSMessages { get; set; }
            public bool ManageMessages { get; set; }
            public bool EmbedLinks { get; set; }
            public bool AttachFiles { get; set; }
            public bool ReadMessageHistory { get; set; }
            public bool MentionEveryone { get; set; }
            public bool UseExternalEmojis { get; set; }
            public bool Connect { get; set; }
            public bool Speak { get; set; }
            public bool MuteMembers { get; set; }
            public bool DeafenMembers { get; set; }
            public bool MoveMembers { get; set; }
            public bool UseVAD { get; set; }
            public bool ChangeNickname { get; set; }
            public bool ManageNicknames { get; set; }
            public bool ManageRoles { get; set; }
            public bool ManageWebhooks { get; set; }
            public bool ManageEmojis { get; set; }
        }

    }
}
