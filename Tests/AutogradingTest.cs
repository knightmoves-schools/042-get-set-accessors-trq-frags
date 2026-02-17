namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Provide_The_Ability_To_Get_The_Name_Field_Without_Providing_The_Ability_To_Set_It()
    {
        var organization = new Organization("test");
        Assert.Equal("test", organization.Name);

        var nameProperty = organization.GetType().GetProperty("Name");
        Assert.NotNull(nameProperty);
        Assert.True(nameProperty.CanRead);
        Assert.Null(nameProperty.GetSetMethod());
    }
}
