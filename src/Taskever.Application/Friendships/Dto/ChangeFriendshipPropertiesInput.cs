namespace Taskever.Friendships.Dto
{
    public class ChangeFriendshipPropertiesInput
    {
        public int Id { get; set; }

        public bool? FollowActivities { get; set; }

        public bool? CanAssignTask { get; set; }
    }
}