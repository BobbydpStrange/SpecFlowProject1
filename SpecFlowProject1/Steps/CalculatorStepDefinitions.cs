using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    

    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public int tempAns = 0;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")] 
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Add("num1",number);


            tempAns = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Add("num2", number);
            //_scenarioContext.Pending();
        }


        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer",n1+n2);
        }

        [Then("the result should be (.*)")] //*the  Two blobs are (.*) and then second is (.*")
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            var n3 = _scenarioContext.Get<int>("answer"); //needed to specify that it was an int because all it knows is that its a name.
            n3.Should().Be(result);

            //_scenarioContext.Pending();
        }


        [When(@"the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer", n1 - n2);
        }

        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            var n1 = _scenarioContext.Get<int>("num1");
            var n2 = _scenarioContext.Get<int>("num2");

            _scenarioContext.Add("answer", n1 * n2);
        }


        //Assignment

       

        [When(@"operation (.*) is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(string opt, int number)
        {
           int ans = 0;

            if (opt == "+")
            {
                ans = tempAns + number;
                tempAns = ans;
            
            }
            else if (opt == "-")
            {
                ans = tempAns - number;
                tempAns = ans;
            }
            else if (opt == "/")
            {
                ans = tempAns / number;
                tempAns = ans;
            }
            else if (opt == "%")
            {
                ans = tempAns % number;
                tempAns = ans;
            }
            else if (opt == "*")
            {
                ans = tempAns * number;
                tempAns = ans;
            }

            if (_scenarioContext.ContainsKey("answer"))
            {
                _scenarioContext.Remove("answer");
            }
            _scenarioContext.Add("answer", ans);
            
                
        }

    }
}
