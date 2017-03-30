using FluentAssertions;
using NUnit.Framework;

namespace BigBlueButtonApi.Tests
{
    [TestFixture]
    public class BigBlueButtonTests
    {
        private BigBlueButton bbb = new BigBlueButton("http://test-install.blindsidenetworks.com/bigbluebutton/api",
            "8cd8ef52e8e101574e400365b55e11a6");

        [Test]
        public void GetVersionTest()
        {
            /* Arrange */

            /* Act */
            var response = bbb.GetVersion();

            /* Assert */
            response.ReturnCode.Should().Be("SUCCESS");
            response.Version.Should().Be("1.0");
        }
    }
}
