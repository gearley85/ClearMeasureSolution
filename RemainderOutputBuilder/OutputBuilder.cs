

namespace RemainderOutputBuilder
{
    public class OutputBuilder
    {
        private int _upperLimit;
        private string _firstOutput;
        private string _secondOutput;


        public OutputBuilder(int upperLimit, string firstOutput, string secondOutput)
        {
            _upperLimit = CheckUpperLimitOutliers(upperLimit);
            _firstOutput = firstOutput;
            _secondOutput = secondOutput;
        }
        public List<Outputs> GetOutputs()
        {
            var resultSet = new List<Outputs>();
            for (int i = 1; i < _upperLimit; i++)
            {
                //divisible by both 3 & 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{_firstOutput}{_secondOutput}" });
                } //divisible by 3 
                else if (i % 3 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{_firstOutput}" });
                }
                //divisiable by 5
                else if (i % 5 == 0)
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = $"{_secondOutput}" });
                }
                else
                {
                    resultSet.Add(new Outputs { Key = i, StringVal = i.ToString() });
                }

            }
            return resultSet;
        }

        private int CheckUpperLimitOutliers(int val)
        {
            return (val < 0) ? 0 : (val > int.MaxValue) ? int.MaxValue : val;
        }
    }
}
