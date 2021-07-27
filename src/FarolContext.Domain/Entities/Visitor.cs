using System;

namespace FarolContext.Domain.Entities
{
    public class Visitor : People
    {
        public DateTime VisitDate { get; private set; }
        public Church Church { get; private set; }
        public Member MemberInvited { get; private set; }
    }
}