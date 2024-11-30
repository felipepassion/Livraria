using Bunit;
using FluentAssertions;
using Niu.Nutri.Shared.Blazor.Components.Layout.DesignSystem.Inputs.Buttons;
using Niu.Nutri.Shared.Blazor.Components.Layout.DesignSystem.Inputs.Buttons.Enums;

namespace Shared.Blazor.Components.Tests
{
    public class DefaultButtonTests : TestContext
    {
        [Fact]
        public void DefaultButton_ShouldRenderWithText()
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.Text, "123"));

            // Assert
            cut.Find("button").InnerHtml.Should().Be("123");
        }

        [Fact]
        public void DefaultButton_ShouldApplyCssClass()
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.Class, "miauu"));

            // Assert
            cut.Find("button").ClassList.Any(x => x.Equals("miauu")).Should().BeTrue();
        }

        [Theory]
        [InlineData(ButtonSizes.Small, "small")]
        [InlineData(ButtonSizes.Medium, "medium")]
        [InlineData(ButtonSizes.Large, "large")]
        public void DefaultButton_ShouldRenderWithCorrectSizeClass(ButtonSizes size, string expectedClass)
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.Size, size));

            // Assert
            cut.Find("button").ClassList.Any(x => x.Equals(expectedClass)).Should().BeTrue();
        }

        [Fact]
        public void DefaultButton_ShouldRenderIcon()
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.Icon, "miauu"));

            // Assert
            cut.Find(".miauu").Should().NotBeNull();
        }

        [Theory]
        [InlineData(true, "mobile-full-width")]
        [InlineData(false, "")]
        public void DefaultButton_ShouldRenderCorrectWidthClass(bool isFullWidth, string expectedClass)
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.MobileFullWidth, isFullWidth));
            var containsMyClass = cut.Find("button").ClassList.Any(x => x.Equals(expectedClass));

            // Assert
            containsMyClass.Should().Be(isFullWidth);
        }

        [Theory]
        [InlineData(ButtonTypes.Primary, "primary")]
        [InlineData(ButtonTypes.Secondary, "secondary")]
        public void DefaultButton_ShouldRenderWithCorrectButtonTypeClass(ButtonTypes buttonType, string expectedClass)
        {
            // Arrange & Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.Type, buttonType));

            // Assert
            cut.Find("button").ClassList.Any(x => x.Equals(expectedClass)).Should().BeTrue();
        }

        [Fact]
        public void DefaultButton_ShouldTriggerOnClickEvent()
        {
            // Arrange
            var testValue = 10;
            var functionToChangeValue = () =>
            {
                testValue = 20;
            };

            // Act
            var cut = RenderComponent<DefaultButton>(parameters => parameters.Add(p => p.OnClick, functionToChangeValue));
            var button = cut.Find("button");
            button.Click();

            // Assert
            testValue.Should().Be(20);
        }


    }
}