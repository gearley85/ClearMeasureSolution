using RemainderOutputBuilder;

namespace RemainderBuilderTests
{
    public class CheckForResults
    {
        [Fact]
        public void TestFifteen()
        {
            string firstOutput = "Clear";
            string secondOutput = "Measure";
            OutputBuilder builder = new OutputBuilder(16, firstOutput, secondOutput);

            var resultSet = builder.GetOutputs();

            Assert.Equal($"{firstOutput}{secondOutput}", actual: resultSet.FirstOrDefault(x => x.Key == 15)?.StringVal);
        }
    }
}