﻿using System;
using System.Collections.Generic;

namespace PnP.Core.Model.Teams
{
    internal partial class TeamChatMessage : BaseDataModel<ITeamChatMessage>, ITeamChatMessage
    {
        public string Id { get => GetValue<string>(); set => SetValue(value); }

        public string ReplyToId { get => GetValue<string>(); set => SetValue(value); }

        public ITeamIdentitySet From { get => GetValue<ITeamIdentitySet>(); set => SetValue(value); }

        public string Etag { get => GetValue<string>(); set => SetValue(value); }

        public ChatMessageType MessageType { get => GetValue<ChatMessageType>(); set => SetValue(value); }

        public DateTimeOffset CreatedDateTime { get => GetValue<DateTimeOffset>(); set => SetValue(value); }

        public DateTimeOffset LastModifiedDateTime { get => GetValue<DateTimeOffset>(); set => SetValue(value); }

        public DateTimeOffset DeletedDateTime { get => GetValue<DateTimeOffset>(); set => SetValue(value); }

        public string Subject { get => GetValue<string>(); set => SetValue(value); }

        public ITeamChatMessageContent Body { get => GetValue<ITeamChatMessageContent>(); set => SetValue(value); }

        public string Summary { get => GetValue<string>(); set => SetValue(value); }

        public Uri WebUrl { get => GetValue<Uri>(); set => SetValue(value); }

        public string Locale { get => GetValue<string>(); set => SetValue(value); }

        public ChatMessageImportance Importance { get => GetValue<ChatMessageImportance>(); set => SetValue(value); }

        public List<ITeamChatMessageReaction> Reactions
        {
            get
            {
                if (!HasValue(nameof(Reactions)))
                {
                    SetValue(new List<ITeamChatMessageReaction>());
                }
                return GetValue<List<ITeamChatMessageReaction>>();
            }
        }

        public List<ITeamChatMessageMention> Mentions
        {
            get
            {
                if (!HasValue(nameof(Mentions)))
                {
                    SetValue(new List<ITeamChatMessageMention>());
                }
                return GetValue<List<ITeamChatMessageMention>>();
            }
        }

        public List<ITeamChatMessageAttachment> Attachments
        {
            get
            {
                if (!HasValue(nameof(Attachments)))
                {
                    SetValue(new List<ITeamChatMessageAttachment>());
                }
                return GetValue<List<ITeamChatMessageAttachment>>();
            }
        }

        [KeyProperty("Id")]
        public override object Key { get => this.Id; set => this.Id = value.ToString(); }
    }
}
