using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Bogus.Extensions.Brazil;
using FarolContext.Domain.Entities;
using FarolContext.Domain.Enums;
using FarolContext.Domain.Queries;
using FarolContext.Domain.ValueObjects;
using FarolContext.Tests.Fakers;
using FarolContext.Tests.Fakers.ValueObjects;
using Xunit;

namespace FarolContext.Tests.QueryTests
{
    public class ChurchQueryTests
    {

        private Church _church;
        private List<Member> _members = new List<Member>();
        private Ministry _ministry;
        private Cell _cell;

        public ChurchQueryTests()
        {
            _church = new ChurchFaker().Generate();
        }

        [Fact]
        public void Given_Id_When_Return_Church()
        {
            var result = _church.Members.AsQueryable().Where(ChurchQueries.GetAllMembers(_church.Id));

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}