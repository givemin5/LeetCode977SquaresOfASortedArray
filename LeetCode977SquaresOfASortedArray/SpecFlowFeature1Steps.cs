using System;
using System.Linq;
using ExpectedObjects;
using TechTalk.SpecFlow;

namespace LeetCode977SquaresOfASortedArray
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I Enter Array into the SortedSquares")]
        public void GivenIEnterArrayIntoTheSortedSquares(Table table)
        {
            var A = table.Rows.Select(r => Convert.ToInt32(r["A"])).ToArray();
            ScenarioContext.Current.Add("A",A);
        }
        
        [When(@"I exec SortedSquares")]
        public void WhenIExecSortedSquares()
        {
            var A = ScenarioContext.Current.Get<int[]>("A");

            Solution solution = new Solution();
            var actual = solution.SortedSquares(A);

            ScenarioContext.Current.Add("actual", actual);

        }
        
        [Then(@"the result should be")]
        public void ThenTheResultShouldBe(Table table)
        {
            var expected = table.Rows.Select(r => Convert.ToInt32(r["Result"])).ToArray();

            var actual = ScenarioContext.Current.Get<int[]>("actual");

            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}
