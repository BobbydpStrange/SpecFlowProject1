﻿using System;
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
            _scenarioContext.Add("miles",p0);
        }

        [Given(@"Gallons used is (.*)")]
        public void GivenGallonsUsedIs(int p0)
        {
            _scenarioContext.Add("gallons", p0);
        }

        [When(@"calc_mpg is called")]
        public void WhenCalc_MpgIsCalled()
        {
            FuelEfficiency f = new FuelEfficiency();
            _scenarioContext.Add("mpg", calc_mpg(_scenarioContext.Get<int>("miles"), _scenarioContext.Get<int>("gallons"));

        }

        private object calc_mpg(int v1, int v2)
        {
            throw new NotImplementedException();
        }

        [Then(@"Fuel Efficiency is (.*)")]
        public void ThenTheFuelEfficiencyShouldBe(int p0)
        {
            var m = _scenarioContext.Get<int>("mpg");
            m.Should().Be(p0);
        }
    }
}
