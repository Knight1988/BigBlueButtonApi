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

        [Test]
        public void CreateTest()
        {
            /* Arrange */

            /* Act */
            var response = bbb.Create("Test", "Test", "ap", "mp");

            /* Assert */
            response.ReturnCode.Should().Be("SUCCESS");
            response.MeetingId.Should().Be("Test");
        }

        [Test]
        public void JoinTest()
        {
            /* Arrange */

            /* Act */
            var response = bbb.Join("random-606821", "User 7561069", "mp");

            /* Assert */
            response.Should().Be("http://test-install.blindsidenetworks.com/bigbluebutton/api/join?fullName=User+7561069&meetingID=random-606821&password=mp&redirect=true&checksum=8691f92d8e4bb148adab2ebe73fcdb1de9af8535");
        }



        [Test]
        public void IsMeetingRunningTest()
        {
            /* Arrange */

            /* Act */
            var response = bbb.IsMeetingRunning("Test");

            /* Assert */
            response.ReturnCode.Should().Be("SUCCESS");
        }
    }
}
