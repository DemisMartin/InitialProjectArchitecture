﻿namespace AG.PaymentApp.Domain.tests.Query
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Threading.Tasks;
    using AG.PaymentApp.Domain.Core.Enum;
    using AG.PaymentApp.Domain.Core.ValueObject;
    using AG.PaymentApp.Domain.Entity.Mongo;
    using AG.PaymentApp.Domain.Entity.Shoppers;
    using Xunit;

    [ExcludeFromCodeCoverage]
    public class FindShopperQueryTests
    {
        [Fact]
        public async Task ExecuteAsync_GetFromMongoDB()
        {
            //ARRANGE
            var email = "test@123.com";
            var lastName = "Last Test";
            var firstName = "Test";
            var shopperID = Guid.NewGuid();
            var creditCardID = Guid.NewGuid();
            var addressID = Guid.NewGuid();
            var creditCard = new CreditCard
            {
                CreditCardID = creditCardID,
                Number = "4556950371985397",
                CreditCardType = CreditCardType.Visa,
                CVV = 123,
                ExpireDate = DateTime.Now.AddMonths(10),
                Owner = "Test A "
            };
            var address = AddressMongo.Create(addressID, "Test", "12", "Porto", "09090-123", "Portugal", DateTime.Now);

            var shopperMongo = ShopperMongo.CreateNew(Gender.Men, shopperID, firstName, lastName, email, address);

            var expectedShopper = Shopper.CreateNew(Gender.Men, shopperID, firstName, lastName, email);

            //var mockIFindShopperEventRepository = new Mock<IFindShopperRepository>();
            //mockIFindShopperEventRepository.Setup(r => r.GetAsync(shopperID))
            //    .ReturnsAsync(shopperMongo);

            //var findShopperQuery = new FindShopperQuery(shopperID, Gender.None);

            //var mapperConfiguration = new MapperConfiguration(c => c.AddProfile(new ShopperProfile()));
            //var mapper = mapperConfiguration.CreateMapper();

            //var mockIAdaptMongoEntityToEntity = new Mock<IAdaptMongoEntityToEntity<ShopperMongo, Shopper>>();
            //mockIAdaptMongoEntityToEntity.Setup(a => a.Adapt(shopperMongo, mapper));

            //var findShopperQueryHandler = new FindShopperQueryHandler(mockIFindShopperEventRepository.Object, mockIAdaptMongoEntityToEntity.Object, mapper);

            ////ACT
            //var result = findShopperQueryHandler.GetAsync(findShopperQuery);

            ////ASSERT
            //result.Result.Should().NotBeNull();
            //result.Result.Email.Should().BeEquivalentTo(expectedShopper.Email);
            //result.Result.FirstName.Should().BeEquivalentTo(expectedShopper.FirstName);
            //result.Result.LastName.Should().BeEquivalentTo(expectedShopper.LastName);
            //result.Result.Id.Should().Equals(expectedShopper.Id);
        }
    }
}

