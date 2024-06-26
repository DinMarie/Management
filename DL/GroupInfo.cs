using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelsa;
using DL;



namespace DL
{
    public class GroupInfo
    {
        public List<Group> groupList = new List<Group>();

        public GroupInfo()
        {
            List<Group> groups;
            sqlDBKpop sqlDBKpop;


            Group groupOne = new Group();
            groupOne.Name = "BTS";
            groupOne.Members = "Seokjin, Yoongi, Hoseok, Namjoon, Jimin, Taehyung, Jungkook ";
            groupOne.FandomName = "ARMY - Adorable Representive M.C for Youth";
            //       groupOne.DebutDate = 2013 - 06 - 13;
            groupOne.Company = "Bighit Music";
            groupList.Add(groupOne);


            Group groupTwo = new Group();
            groupTwo.Name = "TXT";
            groupTwo.Members = "Yeonjun, Soobin, Beomgyu, Taehyun, HueningKai";
            groupTwo.FandomName = "MOA - Moments of Alwayness";
            //      groupTwo.DebutDate = "March 4. 2019";
            groupTwo.Company = "Bighit Music";
            groupList.Add(groupTwo);

            Group groupThree = new Group();
            groupThree.Name = "Seventeen";
            groupThree.Members = "Scoups, JeongHan, Joshua, Woozi, Wonwoo, Hoshi, Jun, DK, Mingyu, The8,Seungkwan, Vernon, Dino";
            groupThree.FandomName = "Carat";
            //      groupThree.DebutDate = "May 26. 2015";
            groupThree.Company = "Pledis Entertainment";
            groupList.Add(groupThree);


            Group groupFour = new Group();
            groupFour.Name = "Twice";
            groupFour.Members = "Nayeon, Jeongyeon, Momo, Sana, Mina, Dahyun, Chaeyoung, Tzuyu";
            groupFour.FandomName = "Once";
            //     groupFour.DebutDate = "October 20. 2015";
            groupFour.Company = "JYP Entertainment";
            groupList.Add(groupFour);

            Group groupFive = new Group();
            groupFive.Name = "Blackpink";
            groupFive.Members = "Jennie, Jisoo, Lisa, Rose";
            groupFive.FandomName = "Blink";
            //   groupFive.DebutDate = "August 8. 2016";
            groupFive.Company = "YG Entertainment";
            groupList.Add(groupFive);

            Group groupSix = new Group();
            groupSix.Name = "Treasure";
            groupSix.Members = "Jihoon, Haruto, Yoshi, Asahi, Junkyu, Doyoung, Hyun-suk, Jaehyuk, Junghwan, Jeongwoo";
            groupSix.FandomName = "Treasure Maker - Teume";
            // groupSix.DebutDate = "August 7. 2020";
            groupSix.Company = "YG Entertainment";
            groupList.Add(groupSix);

            Group groupSeven = new Group();
            groupSeven.Name = "Itzy";
            groupSeven.Members = "Ryujin, Lia, Yeji, Yuna, Chaeryong";
            groupSeven.FandomName = "Midzy";
            //groupSeven.DebutDate = "February 20. 2019";
            groupSeven.Company = "JYP Entertainment";
            groupList.Add(groupSeven);

            Group groupEight = new Group();
            groupEight.Name = "Enyphen";
            groupEight.Members = "Jake, Jay, Sunoo, Sunghoon, Jungwoon, Heesung, Niki";
            groupEight.FandomName = "Engene";
            //groupEight.DebutDate = "November 30. 2020";
            groupEight.Company = "Belift Lab";
            groupList.Add(groupEight);

            Group groupNine = new Group();
            groupNine.Name = "Mamamoo";
            groupNine.Members = "Solar, Hwasa, Moonbyul, Wheein";
            groupNine.FandomName = "MooMoo";
            //   groupNine.DebutDate = "June 19. 2014";
            groupNine.Company = "RBW Company";
            groupList.Add(groupNine);

            Group groupTen = new Group();
            groupTen.Name = "Lesserafim";
            groupTen.Members = "Kazuha, Hyunjin, Chaewon, Sakura, Eunchae";
            groupTen.FandomName = "Fearnot";
            // groupTen.DebutDate = "May 2. 2022";
            groupTen.Company = "Source Music";
            groupList.Add(groupTen);

            Group groupEleven = new Group();
            groupEleven.Name = "";
            groupEleven.Members = "";
            groupEleven.FandomName = "";
            //      groupEleven.DebutDate = 
            groupEleven.Company = "";
            groupList.Add(groupEleven);
        }
        public List<Group> GetGroups()
        {
            List<Group> Group = sqlDBKpop.GetGroups();
            return groupList;
        }

        public int AddGroup(Group group)
        {
            return sqlDBKpop.AddGroup(group.ID, group.Name);
        }
    }
}
      //  public int UpdateGroup(Group group)
        //{
         //   return sqlDBKpop.UpdateGroup(group.ID, group.Name);
      //  }


     //   public  int DeleteGroups(Group group)
       // {
        //    return sqlDBKpop.DeleteGroup(group.Name);
        //}

       
       // }
   // }
//}
