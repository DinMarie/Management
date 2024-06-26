using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
using Modelsa;

namespace BL
{
    public class UserGetServices
    {
        private List<Group> GetAllGroups()
        {
            GroupInfo groupInfo = new GroupInfo();
            return groupInfo.GetGroups();
        }



        public Group GetGroup(string id, string name)
        {
            Group foundGroup = new Group();
            foreach (var group in GetAllGroups())
            {
                if (group.ID == id && group.Name == name)
                {
                    foundGroup = group;
                }
            }
            return foundGroup;
        }

        public Group GetGroup(string name)
        {
            Group foundGroup = new Group();
            foreach (var group in GetAllGroups())
            {
                if (group.Name == name)
                {
                    foundGroup = group;
                }
            }
            return foundGroup;
        }



    }
}
