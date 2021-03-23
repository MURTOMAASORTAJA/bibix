using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Common.Objects
{
    public class Invitations : IEnumerable<Invitation>
    {
        public List<Invitation> List { get; set; }

        public Invitations()
        {
            List = new List<Invitation>();
        }

        public IEnumerator<Invitation> GetEnumerator()
        {
            return List.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return List.AsEnumerable<Invitation>().GetEnumerator();
        }

        public bool TryGetInvitation(int inviteeId, out Invitation invitation)
        {
            try
            {
                invitation = List.Where(inv => inv.InviteeID == inviteeId).First();
                return true;
            }
            catch (Exception)
            {
                invitation = null;
                return false;
            }
        }

        public bool HasInvitationFor(int inviteeId)
        {
            return TryGetInvitation(inviteeId, out _);
        }
    }
}
