﻿using DDD1.Domain.Entities;
using DDD1.Domain.Repositories;
using DDD1.WinForm.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;

namespace DDD1Test.Tests
{
    [TestClass]
    public class WeatherLatestViewModelTest
    {
        [TestMethod]
        public void シナリオ()
        {
            var viewModel = new WeatherLatestViewModel(new WeatherMock());
            Assert.AreEqual("", viewModel.AreaIdText);
            Assert.AreEqual("", viewModel.DataDateText);
            Assert.AreEqual("", viewModel.ConditionText);
            Assert.AreEqual("", viewModel.TemperatureText);

            viewModel.AreaIdText = "1";
            viewModel.Search();
            Assert.AreEqual("1", viewModel.AreaIdText);
            Assert.AreEqual("2018/01/01 12:34:56", viewModel.DataDateText);
            Assert.AreEqual("2", viewModel.ConditionText);
            Assert.AreEqual("12.30 ℃", viewModel.TemperatureText);
        }
    }

    internal class WeatherMock : IWeatherRepository
    {
        public WeatherEntity GetLatest(int areaId)
        {
            return new WeatherEntity(1,
                                           Convert.ToDateTime("2018/01/01 12:34:56"),
                                           2,
                                           12.3f
                ) ;

        }
    }
}
