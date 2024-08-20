using Xunit;
using CarWorkshop.Application.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using CarWorkshop.Application.ApplicationUser;
using static CarWorkshop.Application.ApplicationUser.UserContext;
using AutoMapper;
using CarWorkshop.Application.CarWorkshop;
using FluentAssertions;

namespace CarWorkshop.Application.Mappings.Tests
{
    public class CarWorkshopMappingProfileTests
    {
        [Fact()]
        public void MappingProfile_ShouldMapCarWorkshopDtoToCarWorkshop()
        {
            //arrannge

            var userContextMock = new Mock<IUserContext>();
            userContextMock
                .Setup(c => c.GetCurrentUser())
                .Returns(new CurrentUser("1", "test@example.com", new[] { "Moderator" }));

            var configuration = new MapperConfiguration(cfg => 
            cfg.AddProfile(new CarWorkshopMappingProfile(userContextMock.Object)));

            var mapper = configuration.CreateMapper();

            var dto = new CarWorkshopDto
            {
                City = "City",
                PhoneNumber = "123456789",
                PostalCode = "12345",
                Street = "Street"
            };

            //act

            var result = mapper.Map<Domain.Entities.CarWorkshop>(dto);

            //assert

            result.Should().NotBeNull();
            result.ContactDetails.Should().NotBeNull();
            result.ContactDetails.City.Should().Be(dto.City);
            result.ContactDetails.PhoneNumber.Should().Be(dto.PhoneNumber);
        }
    }
}