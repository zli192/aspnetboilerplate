﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Abp.Webhooks
{
    /// <summary>
    /// Store created web hooks. To see who get that webhook check with <see cref="WebhookSendAttempt.WebhookId"/> and you can get <see cref="WebhookSendAttempt.WebhookSubscriptionId"/>
    /// </summary>
    [Table("AbpWebhooks")]
    public class WebhookInfo : Entity<Guid>, IMayHaveTenant, IHasCreationTime, IHasDeletionTime
    {
        /// <summary>
        /// Webhook unique name <see cref="WebhookDefinition.Name"/>
        /// </summary>
        public string WebhookName { get; set; }

        /// <summary>
        /// Webhook data as JSON string.
        /// </summary>
        public string Data { get; set; }

        public DateTime CreationTime { get; set; }

        public int? TenantId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletionTime { get; set; }
    }
}