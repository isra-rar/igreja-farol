using FarolContext.Domain.Enums;

namespace FarolContext.Domain.Entities
{
    public class Member : People
    {
        public Church Church { get; private set; }
        public EMemberType MemberType { get; private set; }
        public Ministry Ministry { get; private set; }
        public Cell Cell { get; private set; }
    }
}