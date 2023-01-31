using NetCoreDesignPatterns.Common.Extensions;
using NetCoreDesignPatterns.SimpleFactory.Models;

namespace NetCoreDesignPatterns.Unit.Test
{
    public class JsonExtensionsTests
    {
        [Fact]
        public void ToJson_WhenValidAnnonymous_ExpectStringInJson()
        {
            // Assamble
            var client = new
            {
                Id = Guid.NewGuid(),
                Name = "name"
            };

            // Act
            var jsonString = client.ToJson();

            // Assert
            Assert.NotNull(jsonString);
        }

        [Fact]
        public void FromJson_WhenValidObject_ExpectDeserialization()
        {
            // Assamble
            var jsonString = @"{""Id"":""6ee96f7a-76c1-4f9b-9f17-d8982d40a016"",""YearsAsDeveloper"":5}";

            // Act
            var developer = jsonString.FromJson<Developer>();

            // Assert
            Assert.NotNull(developer);
        }
    }
}