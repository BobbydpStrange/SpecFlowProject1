using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using SharedLib;
using FluentAssertions;

namespace SpecFlowProject1
{
    [Binding]
    public sealed class MPGsteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public MPGsteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"Miles driven is (.*)")]
        public void GivenMilesDrivenIs(int p0)
        {

            float miles = Convert.ToSingle(p0);
                _scenarioContext.Add("miles", miles);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(int p0)
        {
            float gallons = Convert.ToSingle(p0);
            _scenarioContext.Add("gallons", gallons);
            
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", f.calc_mpg(
            _scenarioContext.Get<float>("miles"),
            _scenarioContext.Get<float>("gallons")
            ));
        }

        [Then(@"the fuel efficiency should be (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(float p0)
        {
            var m = _scenarioContext.Get<float>("mpg");
            m.Should().Be(p0);
        }


        //Assignment

        [Given(@"gallons used more than (.*)")]
        public void GivenGallonsUsedMoreThan(int p0)
        {

            float gallons = Convert.ToSingle(p0);
            _scenarioContext.Add("gallons", gallons);
        }

        [Given(@"miles driven is less than (.*)")]
        public void GivenMilesDrivenIsLessThan(int p0)
        {
            float miles = Convert.ToSingle(p0);
            _scenarioContext.Add("miles", miles);

        }

        [When(@"gasUse is called")]
        public void WhenCal_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("gasUse", f.gasUse(
            _scenarioContext.Get<float>("miles"),
            _scenarioContext.Get<float>("gallons")
            ));
        }

        [Then(@"they should be gas hogs (.*)")]
        public void ThenTheyAreGassHogs(bool p0)
        {
            var g = _scenarioContext.Get<bool>("gasUse");
            g.Should().Be(p0);
        }


        //miles and gallons calculation from mpg

        [Given(@"mpg is (.*)")]
        public void GivenMpgIs(int p0)
        {
            float mpg = Convert.ToSingle(p0);
            _scenarioContext.Add("mpg", mpg);
        }

        [When(@"calc_gallons is called")]
        public void WhenCalc_GallonsIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("gallons", f.calc_gallons(
            _scenarioContext.Get<float>("miles"),
            _scenarioContext.Get<float>("mpg")
            ));
        }

        [Then(@"the gas used should be (.*)")]
        public void ThenTheGasUsedShouldBe(float p0)
        {
            var g = _scenarioContext.Get<float>("gallons");
            g.Should().Be(p0);
        }

        [When(@"calc_miles is called")]
        public void WhenCalc_MilesIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("miles", f.calc_miles(
            _scenarioContext.Get<float>("gallons"),
            _scenarioContext.Get<float>("mpg")
            ));
        }

        [Then(@"the miles traveled should be (.*)")]
        public void ThenTheMilesTraveledShouldBe(float p0)
        {
            var g = _scenarioContext.Get<float>("miles");
            g.Should().Be(p0);
        }


        //payment validation
        [Given(@"Gallon price is (.*)")]
        public void GivenGallonPriceIs(int p0)
        {
            float price = Convert.ToSingle(p0);
            _scenarioContext.Add("price", price);
        }

        [Given(@"card amount is (.*)")]
        public void GivenCardAmountIs(int p0)
        {
            float  cardAmount = Convert.ToSingle(p0);
            _scenarioContext.Add("cardAmount", cardAmount);
        }

        [When(@"calc_pay is called")]
        public void WhenCalc_PayIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("validation", f.calc_pay(
            _scenarioContext.Get<float>("gallons"),
            _scenarioContext.Get<float>("price"),
             _scenarioContext.Get<float>("cardAmount")
            ));
        }

        [Then(@"the validation for payment should be (.*)")]
        public void ThenThePaymentShouldBeTrue(bool p0)
        {
            var g = _scenarioContext.Get<bool>("validation");
            g.Should().Be(p0);
        }

        //tank stop calculation
        [Given(@"Tank is (.*)")]
        public void GivenTankIs(int p0)
        {
            float tank = Convert.ToSingle(p0);
            _scenarioContext.Add("tank", tank);
        }

        [When(@"calc_fuelUse")]
        public void WhenCalc_FuelUse()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("stops", f.calc_fuelUse(
            _scenarioContext.Get<float>("gallons"),
            _scenarioContext.Get<float>("tank"))
            );
        }

        [Then(@"the times stoped should be (.*)")]
        public void ThenTheTimesStopedShouldBe(float p0)
        {
            var g = _scenarioContext.Get<float>("stops");
            g.Should().Be(p0);
        }

    }
}