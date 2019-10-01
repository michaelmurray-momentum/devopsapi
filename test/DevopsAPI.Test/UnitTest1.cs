using System;
using Xunit;
using DevopsAPI.Controllers;
using Moq;
using Microsoft.Extensions.Logging;

namespace DevopsAPI.Test
{
    public class WeatherForecastControllerTests
    {
        //private readonly IFixture _fixture;
        private readonly Mock<ILogger<WeatherForecastController>> _mockLogger;
        //private readonly Mock<ICatalogueService> _mockCatalogueService;
        private readonly WeatherForecastController _controller;

        public WeatherForecastControllerTests()
        {
            //_fixture = new Fixture();
            _mockLogger = new Mock<ILogger<WeatherForecastController>>();
            //_mockCatalogueService = new Mock<ICatalogueService>();
            _controller = new WeatherForecastController(_mockLogger.Object);

        }


        [Fact]
        public void GetMyName()
        {
            var returnValue = _controller.Get(1);
            Assert.Equal("Mike", returnValue.Value);
        }

    }

}
