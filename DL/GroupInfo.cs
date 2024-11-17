using Modelsa;

namespace DL
{
    public class GroupInfo
    {
        List<Group> groups;
        SqlDBKpop sqlData;
        public GroupInfo()
        {
            groups = new List<Group>();
            sqlData = new SqlDBKpop(); //
        }

        public List<Group> GetGroups()
        {
            groups = sqlData.GetGroups();
            return groups;
        }

        public int AddGroup (Group group)
        {
            return sqlData.AddGroup(group.GroupID, group.Name);
        }

        public int UpdateGroup(Group group)
        {
            return sqlData.UpdateGroup(group.GroupID, group.Name);
        }

        public int DeleteGroup(Group group)
        {
            return sqlData.DeleteGroup(group.GroupID);
        }


    }
}

