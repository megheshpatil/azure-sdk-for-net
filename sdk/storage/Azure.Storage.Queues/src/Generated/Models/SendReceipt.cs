// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The object returned in the QueueMessageList array when calling Put Message on a Queue. </summary>
    public partial class SendReceipt
    {
        /// <summary> Initializes a new instance of <see cref="SendReceipt"/>. </summary>
        /// <param name="messageId"> The Id of the Message. </param>
        /// <param name="insertionTime"> The time the Message was inserted into the Queue. </param>
        /// <param name="expirationTime"> The time that the Message will expire and be automatically deleted. </param>
        /// <param name="popReceipt"> This value is required to delete the Message. If deletion fails using this popreceipt then the message has been dequeued by another client. </param>
        /// <param name="timeNextVisible"> The time that the message will again become visible in the Queue. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/> or <paramref name="popReceipt"/> is null. </exception>
        internal SendReceipt(string messageId, DateTimeOffset insertionTime, DateTimeOffset expirationTime, string popReceipt, DateTimeOffset timeNextVisible)
        {
            if (messageId == null)
            {
                throw new ArgumentNullException(nameof(messageId));
            }
            if (popReceipt == null)
            {
                throw new ArgumentNullException(nameof(popReceipt));
            }

            MessageId = messageId;
            InsertionTime = insertionTime;
            ExpirationTime = expirationTime;
            PopReceipt = popReceipt;
            TimeNextVisible = timeNextVisible;
        }
    }
}
