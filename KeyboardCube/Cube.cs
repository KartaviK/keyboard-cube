using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardCube
{
	public class Cube
	{
		public const int edgeSize = 3;
		public const int edgesCount = 6;

		public byte[][,] Edges;

		private static Cube instance = null;
		
		protected Cube()
		{
			Edges = new byte[edgesCount][,];

			for(int edge = 0; edge < edgesCount; edge++)
			{
				Edges[edge] = new byte[edgeSize, edgeSize];

				for (int line = 0; line < edgeSize; line++)
				{
					for (int column = 0; column < edgeSize; column++)
					{
						Edges[edge][line, column] = (byte)edge;
					}
				}
			}
		}

		public static Cube Instance()
		{
			if (instance == null)
			{
				instance = new Cube();
			}

			return instance;
		}
	}
}
