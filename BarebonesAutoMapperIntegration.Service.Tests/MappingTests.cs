using Xunit;

namespace BarebonesAutoMapperIntegration.Service.Tests
{
    public class MappingTests
    {
        // This test ensures that all properties of the target data models are mapped to, otherwise test will fail
        [Fact]
        public void AssertConfiguration() => MapperConfig.Default.AssertConfigurationIsValid();
    }
}