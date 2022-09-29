using suivi_des_drones.Core.Application.Repositories;
using suivi_des_drones.Core.Interfaces.Infrastructures;
using suivi_des_drones.Core.Interfaces.Repositories;
using suivi_des_drones.Core.Models;
using suivi_des_drones.Tests.Web.UI.Fakes;
using suivi_des_drones.Web.UI.Pages;

namespace suivi_des_drones.Tests.Web.UI
{
    public class DeliveryPageModelUnitTest
    {
        [Fact]
        public void ShouldListTwoDeliveries()
        {
            // Arrange
            var mockLayer = new Moq.Mock<IDeliveryDataLayer>();
            mockLayer.Setup(item => item.GetAll()).Returns(new List<Delivery>() { new(), new() });

            IDeliveryRepository repository = new DeliveryRepository(mockLayer.Object);
            DeliveryListModel model = new DeliveryListModel(repository);

            // Act
            var result = model.OnGet();
            var list = model.List;

            // Assert
            mockLayer.VerifyAll();

            Assert.IsType<List<Delivery>>(list);
            Assert.NotNull(result);
            Assert.NotNull(list);
            Assert.Equal(2, list.Count);
        }
    }
}