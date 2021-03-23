
using Common.Enums;

namespace Common.Objects
{
    public class Event
    {
        #region Properties
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int OwnerID { get; set; }
        public int[] CoOwnerIDs { get; set; }

        public PermissionFlag[] InvitePermissions { get; set; }

        private Invitations invitations;
        public Invitations Invitations
        {
            get
            {
                if (invitations == null) invitations = new Invitations();
                return invitations;
            }

            set
            {
                invitations = value;
            }
        }
        #endregion
    }
}
