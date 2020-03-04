namespace Shapes.Models
{
  public class Circle
	{
		public float Radius { get; set; }

		public Circle(float radius)
		{
			Radius = radius;
		}

		public float GetDiameter()
		{
			float diameter = Radius * 2f;
			return diameter; 
		}
		public float GetCircumference()
		{
			float circum = 2f * 3.14f * Radius;
			return circum;
		}
	}
}