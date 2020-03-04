using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.TestTools
{
  [TestClass]
  public class CircleTests
  {
    
    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      Circle newCircle = new Circle(5);
      float result = newCircle.GetDiameter();
      Assert.AreEqual(result, 10f);
    }
    
    [TestMethod]
    public void Circle_GetCircumference_CircumOfCircle()
    {
      Circle newCircle = new Circle(5);
      float result = newCircle.GetCircumference();
      float number = 31.4f;
      Assert.AreEqual(number, result, .01);
    }
  }
}