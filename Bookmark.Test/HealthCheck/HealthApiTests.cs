using System;
using System.Collections.Generic;
using System.Text;

namespace Bookmark.Test.HealthCheck
{
    public class HealthApiTests
    {
        [Fact]
        public void GET_Health_WhenAllServicesUp_Returns200()
        {

        }
        [Fact]
        public void GET_Health_WhenDatabaseDown_Returns503()
        {

        }
        [Fact]
        public void GET_Health_WhenRedisDown_Returns503()
        {

        }
    }
}
