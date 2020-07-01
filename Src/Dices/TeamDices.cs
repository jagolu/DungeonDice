using DungeonDice.Models.Dices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonDice.Src.Dices
{
    class TeamDices
    {
        #region singleton

        private TeamDices() 
        {
            this.initializeDicesVars();
        }
        private static TeamDices _instance;

        public static TeamDices getInstance()
        {
            if (_instance == null)
            {
                _instance = new TeamDices();
            }
            return _instance;
        }

        #endregion

        #region vars

        private List<Tuple<TeamDice, bool>> teamDices;
        private int teamNumberMembers;

        #endregion

        #region public

        public void createTeam()
        {
            for(int i = 0; i < this.teamNumberMembers; i++)
            {
                this.rollMemberTeam(i);
            }
        }

        public void rollMemberTeam(int numberDice)
        {
            this.teamDices[numberDice].Item1.roll();
        }

        public TeamDice getMember(int memberNumber)
        {
            if (!this.existMemberPosition(memberNumber) || !this.isMemberUsable(memberNumber))
            {
                return null;
            }

            return this.teamDices[memberNumber].Item1;
        }

        public void useMember(int memberNumber)
        {
            if (!this.existMemberPosition(memberNumber) || !this.isMemberUsable(memberNumber))
            {
                return;
            }

            TeamDice member = this.teamDices[memberNumber].Item1;
            this.teamDices[memberNumber] = new Tuple<TeamDice, bool>(member, true);
        }

        public bool isMemberUsable(int memberNumber)
        {
            return this.teamDices[memberNumber].Item2;
        }

        public int unusedMembersCount()
        {
            return this.teamDices.Count(td => !td.Item2);
        }

        public int availableMembersCount()
        {
            return this.teamDices.Count(td => td.Item2);
        }

        #endregion

        #region private

        private bool existMemberPosition(int memberNumber)
        {
            return memberNumber <= this.teamNumberMembers;
        }

        private void initializeDicesVars()
        {
            Tuple<TeamDice, bool> baseMemberDice =  new Tuple<TeamDice, bool>(new TeamDice(), true);
            this.teamDices = Enumerable.Repeat(baseMemberDice, 7).ToList();
            this.teamNumberMembers = 7;
        }

        #endregion
    }
}
