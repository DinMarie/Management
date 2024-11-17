using Modelsa;
using DL;


namespace KpopBL
{
    public class Business  //USERGET
    {
        validationSer ValidationSer = new validationSer(); //
        GroupInfo Services = new GroupInfo();

        public bool CreateGroup(Group group)
        {
            bool result = false;
            if (ValidationSer.CheckIfNameExists(group.Name))
            {   
                result = Services.AddGroup(group) > 0;
            }
            return result;
        }

        public bool CreateGroup(string GroupID, string Name)
        {
            Group group = new Group {  GroupID = GroupID, Name = Name };

            return CreateGroup(group);
        }

        public bool UpdateGroup(Group group)
        {
            bool result = false;

            if (ValidationSer.CheckIfNameExists(group.Name))
            {
                result = Services.UpdateGroup(group) > 0;

            }
            return result;
        }

        public bool UpdateGroup(string GroupID, string Name)
        {
            Group group = new Group { GroupID = GroupID, Name = Name };

            return UpdateGroup(group);
        }

        public bool DeleteGroup(Group group)
        {
            bool result = false;
            if (ValidationSer.CheckIfNameExists(group.Name))
            {
                result = Services.DeleteGroup(group) > 0;
            }
            return result;
        }

    }
}