namespace Shapes.Models
{
  public class Circle
	{
		public int Radius { get; set; }
		public int Pi { get; }

		public Circle(int radius)
		{
			Radius = radius;

		}

		public int GetDiameter()
		{
			int diameter = Radius * 2;
			return diameter; 
		}

	}
}