//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ETA.FantasyFootbalBHPL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class user
    {
        public user()
        {
            this.league = new HashSet<league>();
            this.leagueparticipants = new HashSet<leagueparticipants>();
        }
    
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public System.DateTime dateOfBirth { get; set; }
        public bool gender { get; set; }
        public string cellPhone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string country { get; set; }
        public string region { get; set; }
        public string closestCity { get; set; }
        public string timeZone { get; set; }
        public string zipCode { get; set; }
        public int idPlayersTeam1 { get; set; }
        public int UserGroup_idUserGroup { get; set; }
    
        public virtual ICollection<league> league { get; set; }
        public virtual ICollection<leagueparticipants> leagueparticipants { get; set; }
        public virtual squad squad { get; set; }
        public virtual usergroup usergroup { get; set; }
    }
}
