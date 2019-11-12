using System;
using System.Collections.Generic;

namespace RSVPME.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeTown { get; set; }
        public string MeetupsAbout { get; set; }
        public List<Interest> Interests { get; set; }
        public string GroupDescription { get; set; }
        public byte[] Image { get; set; }
        public List<Discussion> Discussions { get; set; }
        public List<Sponsor> Sponsors { get; set; }
        public List<Poll> Polls { get; set; }
        public MessageBoard MessageBoard { get; set; }
        public GroupStatistics Statistics { get; set; }
        public MailingList MailingList { get; set; }
        public List<GroupPage> Pages { get; set; }
        public List<File> Files { get; set; }
        public List<JoiningQuestion> JoiningQuestions { get; set; }
        public GroupAppearance Appearance { get; set; }
        public List<Member> Organisers { get; set; }
        public List<Member> Members { get; set; }
    }
}
