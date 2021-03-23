using System;
using Common.Enums;

namespace Common.Objects
{
    public class Invitation
    {
        /// <summary>
        /// ID of the user who has been invited to the event.
        /// </summary>
        public int InviteeID { get; set; }

        /// <summary>
        /// Response from the invitee.
        /// </summary>
        public InvitationResponse Response { get; set; }

        /// <summary>
        /// Timestamp of when the response was received from the invitee.
        /// </summary>
        public DateTime? ResponseChangedAt { get; set; }

        /// <summary>
        /// Timestamp of when this invitation was created.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// ID of the creator of this invitation.
        /// </summary>
        public int CreatedBy { get; set; }
    }
}
