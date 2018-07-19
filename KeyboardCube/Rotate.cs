using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardCube
{
	public static class Rotate
	{
		#region Rotates
		public static void U(ref Cube cube)
		{
			// Внутренние блоки
			byte cache = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cache;
			cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cache;

			// Внешние блоки
			cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cache;
			cache = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cache;
			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cache;
		}
		
		public static void Ui(ref Cube cube)
		{
			byte cache = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cache;
			cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cache;

			cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cache;
			cache = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cache;
			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cache;
		}
		
		public static void Ud(ref Cube cube)
		{
			byte cache = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cache;
			cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cache;
			cache = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cache;
			cache = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cache;

			cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cache;
			cache = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cache;
			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cache;
			cache = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cache;
			cache = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cache;
			cache = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cache;
		}
		
		public static void D(ref Cube cube)
		{
			byte cache = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
			cache = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cache;

			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cache;
			cache = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cache;
			cache = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cache;
		}
		
		public static void Di(ref Cube cube)
		{
			byte cache = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cache;
			cache = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cache;

			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cache;
			cache = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;
			cache = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cache;
		}
		
		public static void Dd(ref Cube cube)
		{
			byte cache = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cache;
			cache = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cache;
			cache = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
			cache = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cache;

			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cache;
			cache = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cache;
			cache = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cache;
			cache = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cache;
			cache = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;
			cache = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cache;
		}
		
		public static void R(ref Cube cube)
		{
			byte cache = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cache;
			cache = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cache;

			cache = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cache;
			cache = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cache;
			cache = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cache;
		}
		
		public static void Ri(ref Cube cube)
		{
			byte cache = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cache;
			cache = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cache;

			cache = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
			cache = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cache;
			cache = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cache;
		}
		
		public static void Rd(ref Cube cube)
		{
			byte cache = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cache;
			cache = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cache;
			cache = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cache;
			cache = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cache;

			cache = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cache;
			cache = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cache;
			cache = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cache;
			cache = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cache;
			cache = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cache;
			cache = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
		}
		
		public static void L(ref Cube cube)
		{
			byte cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cache;
			cache = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cache;

			cache = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cache;
			cache = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cache;
			cache = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cache;
		}
		
		public static void Li(ref Cube cube)
		{
			byte cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cache;
			cache = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cache;

			cache = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cache;
			cache = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cache;
			cache = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cache;
		}
		
		public static void Ld(ref Cube cube)
		{
			byte cache = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cache;
			cache = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cache;
			cache = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cache;
			cache = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cache;

			cache = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cache;
			cache = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cache;
			cache = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cache;
			cache = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cache;
			cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cache;
			cache = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cache;
		}
		
		public static void F(ref Cube cube)
		{
			byte cache = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cache;
			cache = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cache;

			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cache;
			cache = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cache;
			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cache;
		}
		
		public static void Fi(ref Cube cube)
		{
			byte cache = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cache;
			cache = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cache;

			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cache;
			cache = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cache;
			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
		}
		
		public static void Fd(ref Cube cube)
		{
			byte cache = cube.Edges[2][0, 0];
			cube.Edges[2][0, 0] = cube.Edges[2][2, 2];
			cube.Edges[2][2, 2] = cache;
			cache = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cache;
			cache = cube.Edges[2][0, 2];
			cube.Edges[2][0, 2] = cube.Edges[2][2, 0];
			cube.Edges[2][2, 0] = cache;
			cache = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cache;

			cache = cube.Edges[1][2, 0];
			cube.Edges[1][2, 0] = cube.Edges[3][0, 2];
			cube.Edges[3][0, 2] = cache;
			cache = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cache;
			cache = cube.Edges[1][2, 2];
			cube.Edges[1][2, 2] = cube.Edges[3][0, 0];
			cube.Edges[3][0, 0] = cache;
			cache = cube.Edges[0][0, 2];
			cube.Edges[0][0, 2] = cube.Edges[5][2, 0];
			cube.Edges[5][2, 0] = cache;
			cache = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cache;
			cache = cube.Edges[0][2, 2];
			cube.Edges[0][2, 2] = cube.Edges[5][0, 0];
			cube.Edges[5][0, 0] = cache;
		}
		
		public static void B(ref Cube cube)
		{
			byte cache = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cache;
			cache = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cache;

			cache = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cache;
			cache = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cache;
			cache = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cache;
		}
		
		public static void Bi(ref Cube cube)
		{
			byte cache = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cache;
			cache = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;

			cache = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cache;
			cache = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cache;
			cache = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cache;
		}
		
		public static void Bd(ref Cube cube)
		{
			byte cache = cube.Edges[4][0, 0];
			cube.Edges[4][0, 0] = cube.Edges[4][2, 2];
			cube.Edges[4][2, 2] = cache;
			cache = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cache;
			cache = cube.Edges[4][0, 2];
			cube.Edges[4][0, 2] = cube.Edges[4][2, 0];
			cube.Edges[4][2, 0] = cache;
			cache = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;

			cache = cube.Edges[3][2, 0];
			cube.Edges[3][2, 0] = cube.Edges[1][0, 2];
			cube.Edges[1][0, 2] = cache;
			cache = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cache;
			cache = cube.Edges[3][2, 2];
			cube.Edges[3][2, 2] = cube.Edges[1][0, 0];
			cube.Edges[1][0, 0] = cache;
			cache = cube.Edges[0][2, 0];
			cube.Edges[0][2, 0] = cube.Edges[5][0, 2];
			cube.Edges[5][0, 2] = cache;
			cache = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cache;
			cache = cube.Edges[0][0, 0];
			cube.Edges[0][0, 0] = cube.Edges[5][2, 2];
			cube.Edges[5][2, 2] = cache;
		}
		
		public static void M(ref Cube cube)
		{
			byte cache = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cache;
			cache = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cache;
			cache = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;
		}
		
		public static void Mi(ref Cube cube)
		{
			byte cache = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cache;
			cache = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cache;
			cache = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cache;
		}
		
		public static void Md(ref Cube cube)
		{
			byte cache = cube.Edges[5][1, 2];
			cube.Edges[5][1, 2] = cube.Edges[0][1, 2];
			cube.Edges[0][1, 2] = cache;
			cache = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cache;
			cache = cube.Edges[5][1, 0];
			cube.Edges[5][1, 0] = cube.Edges[0][1, 0];
			cube.Edges[0][1, 0] = cache;
			cache = cube.Edges[2][1, 2];
			cube.Edges[2][1, 2] = cube.Edges[4][1, 0];
			cube.Edges[4][1, 0] = cache;
			cache = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cache;
			cache = cube.Edges[2][1, 0];
			cube.Edges[2][1, 0] = cube.Edges[4][1, 2];
			cube.Edges[4][1, 2] = cache;
		}
		
		public static void E(ref Cube cube)
		{
			byte cache = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cache;
			cache = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cache;
			cache = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cache;
		}
		
		public static void Ei(ref Cube cube)
		{
			byte cache = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cache;
			cache = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cache;
			cache = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cache;
		}
		
		public static void Ed(ref Cube cube)
		{
			byte cache = cube.Edges[2][2, 1];
			cube.Edges[2][2, 1] = cube.Edges[4][2, 1];
			cube.Edges[4][2, 1] = cache;
			cache = cube.Edges[2][1, 1];
			cube.Edges[2][1, 1] = cube.Edges[4][1, 1];
			cube.Edges[4][1, 1] = cache;
			cache = cube.Edges[2][0, 1];
			cube.Edges[2][0, 1] = cube.Edges[4][0, 1];
			cube.Edges[4][0, 1] = cache;
			cache = cube.Edges[1][2, 1];
			cube.Edges[1][2, 1] = cube.Edges[3][2, 1];
			cube.Edges[3][2, 1] = cache;
			cache = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cache;
			cache = cube.Edges[1][0, 1];
			cube.Edges[1][0, 1] = cube.Edges[3][0, 1];
			cube.Edges[3][0, 1] = cache;
		}
		
		public static void S(ref Cube cube)
		{
			byte cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cache;
			cache = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cache;
			cache = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cache;
		}
		
		public static void Si(ref Cube cube)
		{
			byte cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cache;
			cache = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cache;
			cache = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cache;
		}
		
		public static void Sd(ref Cube cube)
		{
			byte cache = cube.Edges[0][0, 1];
			cube.Edges[0][0, 1] = cube.Edges[5][2, 1];
			cube.Edges[5][2, 1] = cache;
			cache = cube.Edges[0][1, 1];
			cube.Edges[0][1, 1] = cube.Edges[5][1, 1];
			cube.Edges[5][1, 1] = cache;
			cache = cube.Edges[0][2, 1];
			cube.Edges[0][2, 1] = cube.Edges[5][0, 1];
			cube.Edges[5][0, 1] = cache;
			cache = cube.Edges[1][1, 0];
			cube.Edges[1][1, 0] = cube.Edges[3][1, 2];
			cube.Edges[3][1, 2] = cache;
			cache = cube.Edges[1][1, 1];
			cube.Edges[1][1, 1] = cube.Edges[3][1, 1];
			cube.Edges[3][1, 1] = cache;
			cache = cube.Edges[1][1, 2];
			cube.Edges[1][1, 2] = cube.Edges[3][1, 0];
			cube.Edges[3][1, 0] = cache;
		}
		#endregion

		#region Twise rotates
		public static void Rw(ref Cube cube)
		{
			R(ref cube);
			Mi(ref cube);
		}
		
		public static void Rwi(ref Cube cube)
		{
			Ri(ref cube);
			M(ref cube);
		}
		
		public static void Rwd(ref Cube cube)
		{
			Rd(ref cube);
			Md(ref cube);
		}
		
		public static void Lw(ref Cube cube)
		{
			L(ref cube);
			M(ref cube);
		}
		
		public static void Lwi(ref Cube cube)
		{
			Li(ref cube);
			Mi(ref cube);
		}
		
		public static void Lwd(ref Cube cube)
		{
			Ld(ref cube);
			Md(ref cube);
		}
		
		public static void Fw(ref Cube cube)
		{
			F(ref cube);
			S(ref cube);
		}
		
		public static void Fwi(ref Cube cube)
		{
			Fi(ref cube);
			Si(ref cube);
		}
		
		public static void Fwd(ref Cube cube)
		{
			Fd(ref cube);
			Sd(ref cube);
		}
		
		public static void Bw(ref Cube cube)
		{
			B(ref cube);
			Si(ref cube);
		}

		public static void Bwi(ref Cube cube)
		{
			Bi(ref cube);
			S(ref cube);
		}
		
		public static void Bwd(ref Cube cube)
		{
			Bd(ref cube);
			Sd(ref cube);
		}
		
		public static void Uw(ref Cube cube)
		{
			U(ref cube);
			Ei(ref cube);
		}
		
		public static void Uwi(ref Cube cube)
		{
			Ui(ref cube);
			E(ref cube);
		}
		
		public static void Uwd(ref Cube cube)
		{
			Ud(ref cube);
			Ed(ref cube);
		}
		
		public static void Dw(ref Cube cube)
		{
			D(ref cube);
			E(ref cube);
		}
		
		public static void Dwi(ref Cube cube)
		{
			Di(ref cube);
			Ei(ref cube);
		}
		
		public static void Dwd(ref Cube cube)
		{
			Dd(ref cube);
			Ed(ref cube);
		}
		#endregion

		#region Cube rotates
		public static void x(ref Cube cube)
		{
			R(ref cube);
			Mi(ref cube);
			Li(ref cube);
		}
		
		public static void xi(ref Cube cube)
		{
			Ri(ref cube);
			M(ref cube);
			L(ref cube);
		}
		
		public static void xd(ref Cube cube)
		{
			Rd(ref cube);
			Md(ref cube);
			Ld(ref cube);
		}

		public static void y(ref Cube cube)
		{
			U(ref cube);
			Ei(ref cube);
			Di(ref cube);
		}
		
		public static void yi(ref Cube cube)
		{
			Ui(ref cube);
			E(ref cube);
			D(ref cube);
		}
		
		public static void yd(ref Cube cube)
		{
			Ud(ref cube);
			Ed(ref cube);
			Dd(ref cube);
		}

		public static void z(ref Cube cube)
		{
			F(ref cube);
			S(ref cube);
			Bi(ref cube);
		}
		
		public static void zi(ref Cube cube)
		{
			Fi(ref cube);
			Si(ref cube);
			B(ref cube);
		}
		
		public static void zd(ref Cube cube)
		{
			Fd(ref cube);
			Sd(ref cube);
			Bd(ref cube);
		}
		#endregion
	}
}
