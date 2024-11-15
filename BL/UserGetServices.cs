using DL;
using Modelsa;

namespace KpopBL
{
    public class UserGetServices
    {
        public List<Group> GetAllGroups()
        {
            GroupInfo groupInfo = new GroupInfo();
            return groupInfo.GetGroups();
        }

        public List<Group> GetGroup(string Name)
        {
            List<Group> groups = new List<Group>();

            foreach (var group in GetAllGroups())
            {
                if (group.Name == Name)
                {
                    groups.Add(group);
                }
            }
            return groups;
        }

        public Group GetGroups(string GroupID, string Name)
        {
            Group foundGroup = new Group();
            foreach (var group in GetAllGroups())
            {
                if (group.GroupID == GroupID && group.Name == Name)
                {
                    foundGroup = group;
                }
            }
            return foundGroup;
        }

    }
}
