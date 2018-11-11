using Xunit;

namespace BarebonesAutoMapperIntegration.Service.Tests
{
    public class MappingTests
    {
        [Fact]
        public void AssertConfiguration() => MapperConfig.Default.AssertConfigurationIsValid();
    }
}