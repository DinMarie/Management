using System;
using DL;
using BL;
using Modelsa;


namespace BL
{
    public class Business  //USERGET
    {
        validationSer ValidationSer = new validationSer();
        UserGetServices Services = new UserGetServices();

        public bool AddGroup(Group group)
        {
            bool result = false;
            if (ValidationSer.CheckIfNameExists(group.Name))
            {
                //  result = group.AddGroup(group) > 0;
                result = group != null;
            }
            return result;
        }

        public bool CreateGroup(Group group)
        {
            bool result = false;

            if (ValidationSer.CheckIfNameExists(group.Name))
            {
                //     result = group.AddGroup(group);
                result = group.Name != null;

            }
            return result;
        }
        public bool CreateGroup(string ID, string Name)
        {
            Group group = new Group { ID = ID, Name = Name };

            {
                Group group1 = new Group { ID = ID, Name = Name };

                return CreateGroup(group1);
            }
        }

        public bool updateGroup(Group group)
        {
            bool result = false;

            if (ValidationSer.CheckIfIDExists(group.ID))
            {
                //  result = group.updateGroup(group) > 0;
                result |= group.Name != null;

            }
            return result;
        }
        public bool DeleteGroup(Group group)
        {
            bool result = false;
            if (ValidationSer.CheckIfNameExists(group.ID))
            {
                //  result = group.DeleteGroup(group) > 0;
                result = group == null;
            }
            return result;
        }

    }
}