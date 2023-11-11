using System;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet.Tools
{
	internal class Statistic
	{
		internal static long InCircleCount = 0L;

		internal static long InCircleAdaptCount = 0L;

		internal static long CounterClockwiseCount = 0L;

		internal static long CounterClockwiseAdaptCount = 0L;

		internal static long Orient3dCount = 0L;

		internal static long HyperbolaCount = 0L;

		internal static long CircumcenterCount = 0L;

		internal static long CircleTopCount = 0L;

		internal static long RelocationCount = 0L;

		private double minEdge;

		private double maxEdge;

		private double minAspect;

		private double maxAspect;

		private double minArea;

		private double maxArea;

		private double minAngle;

		private double maxAngle;

		private int[] angleTable;

		private int[] minAngles;

		private int[] maxAngles;

		private double meshArea;

		private static readonly int[] plus1Mod3 = new int[3] { 1, 2, 0 };

		private static readonly int[] minus1Mod3 = new int[3] { 2, 0, 1 };

		public double ShortestEdge => minEdge;

		public double LongestEdge => maxEdge;

		public double ShortestAltitude => minAspect;

		public double LargestAspectRatio => maxAspect;

		public double SmallestArea => minArea;

		public double LargestArea => maxArea;

		public double SmallestAngle => minAngle;

		public double LargestAngle => maxAngle;

		public int[] AngleHistogram => angleTable;

		public int[] MinAngleHistogram => minAngles;

		public int[] MaxAngleHistogram => maxAngles;

		public double MeshArea => meshArea;

		private void GetAspectHistogram(Mesh mesh)
		{
			int[] array = new int[16];
			double[] array2 = new double[16]
			{
				1.5, 2.0, 2.5, 3.0, 4.0, 6.0, 10.0, 15.0, 25.0, 50.0,
				100.0, 300.0, 1000.0, 10000.0, 100000.0, 0.0
			};
			Otri otri = default(Otri);
			Vertex[] array3 = new Vertex[3];
			double[] array4 = new double[3];
			double[] array5 = new double[3];
			double[] array6 = new double[3];
			otri.orient = 0;
			foreach (Triangle triangle in mesh.triangles)
			{
				otri.tri = triangle;
				array3[0] = otri.Org();
				array3[1] = otri.Dest();
				array3[2] = otri.Apex();
				double num = 0.0;
				for (int i = 0; i < 3; i++)
				{
					int num2 = plus1Mod3[i];
					int num3 = minus1Mod3[i];
					array4[i] = array3[num2].x - array3[num3].x;
					array5[i] = array3[num2].y - array3[num3].y;
					array6[i] = array4[i] * array4[i] + array5[i] * array5[i];
					if (array6[i] > num)
					{
						num = array6[i];
					}
				}
				double num4 = Math.Abs((array3[2].x - array3[0].x) * (array3[1].y - array3[0].y) - (array3[1].x - array3[0].x) * (array3[2].y - array3[0].y)) / 2.0;
				double num5 = num4 * num4 / num;
				double num6 = num / num5;
				int j;
				for (j = 0; num6 > array2[j] * array2[j] && j < 15; j++)
				{
				}
				array[j]++;
			}
		}

		public void Update(Mesh mesh, int sampleDegrees)
		{
			Point[] array = new Point[3];
			sampleDegrees = 60;
			double[] array2 = new double[sampleDegrees / 2 - 1];
			double[] array3 = new double[3];
			double[] array4 = new double[3];
			double[] array5 = new double[3];
			double num = Math.PI / (double)sampleDegrees;
			double num2 = 180.0 / Math.PI;
			angleTable = new int[sampleDegrees];
			minAngles = new int[sampleDegrees];
			maxAngles = new int[sampleDegrees];
			for (int i = 0; i < sampleDegrees / 2 - 1; i++)
			{
				array2[i] = Math.Cos(num * (double)(i + 1));
				array2[i] *= array2[i];
			}
			for (int j = 0; j < sampleDegrees; j++)
			{
				angleTable[j] = 0;
			}
			minAspect = mesh.bounds.Width + mesh.bounds.Height;
			minAspect *= minAspect;
			maxAspect = 0.0;
			minEdge = minAspect;
			maxEdge = 0.0;
			minArea = minAspect;
			maxArea = 0.0;
			minAngle = 0.0;
			maxAngle = 2.0;
			meshArea = 0.0;
			bool flag = true;
			bool flag2 = true;
			double num3 = 1.0;
			foreach (Triangle triangle in mesh.triangles)
			{
				double num4 = 0.0;
				num3 = 1.0;
				array[0] = triangle.vertices[0];
				array[1] = triangle.vertices[1];
				array[2] = triangle.vertices[2];
				double num5 = 0.0;
				for (int k = 0; k < 3; k++)
				{
					int num6 = plus1Mod3[k];
					int num7 = minus1Mod3[k];
					array3[k] = array[num6].x - array[num7].x;
					array4[k] = array[num6].y - array[num7].y;
					array5[k] = array3[k] * array3[k] + array4[k] * array4[k];
					if (array5[k] > num5)
					{
						num5 = array5[k];
					}
					if (array5[k] > maxEdge)
					{
						maxEdge = array5[k];
					}
					if (array5[k] < minEdge)
					{
						minEdge = array5[k];
					}
				}
				double num8 = Math.Abs((array[2].x - array[0].x) * (array[1].y - array[0].y) - (array[1].x - array[0].x) * (array[2].y - array[0].y));
				meshArea += num8;
				if (num8 < minArea)
				{
					minArea = num8;
				}
				if (num8 > maxArea)
				{
					maxArea = num8;
				}
				double num9 = num8 * num8 / num5;
				if (num9 < minAspect)
				{
					minAspect = num9;
				}
				double num10 = num5 / num9;
				if (num10 > maxAspect)
				{
					maxAspect = num10;
				}
				int num13;
				for (int l = 0; l < 3; l++)
				{
					int num6 = plus1Mod3[l];
					int num7 = minus1Mod3[l];
					double num11 = array3[num6] * array3[num7] + array4[num6] * array4[num7];
					double num12 = num11 * num11 / (array5[num6] * array5[num7]);
					num13 = sampleDegrees / 2 - 1;
					for (int num14 = num13 - 1; num14 >= 0; num14--)
					{
						if (num12 > array2[num14])
						{
							num13 = num14;
						}
					}
					if (num11 <= 0.0)
					{
						angleTable[num13]++;
						if (num12 > minAngle)
						{
							minAngle = num12;
						}
						if (flag && num12 < maxAngle)
						{
							maxAngle = num12;
						}
						if (num12 > num4)
						{
							num4 = num12;
						}
						if (flag2 && num12 < num3)
						{
							num3 = num12;
						}
					}
					else
					{
						angleTable[sampleDegrees - num13 - 1]++;
						if (flag || num12 > maxAngle)
						{
							maxAngle = num12;
							flag = false;
						}
						if (flag2 || num12 > num3)
						{
							num3 = num12;
							flag2 = false;
						}
					}
				}
				num13 = sampleDegrees / 2 - 1;
				for (int num15 = num13 - 1; num15 >= 0; num15--)
				{
					if (num4 > array2[num15])
					{
						num13 = num15;
					}
				}
				minAngles[num13]++;
				num13 = sampleDegrees / 2 - 1;
				for (int num16 = num13 - 1; num16 >= 0; num16--)
				{
					if (num3 > array2[num16])
					{
						num13 = num16;
					}
				}
				if (flag2)
				{
					maxAngles[num13]++;
				}
				else
				{
					maxAngles[sampleDegrees - num13 - 1]++;
				}
				flag2 = true;
			}
			minEdge = Math.Sqrt(minEdge);
			maxEdge = Math.Sqrt(maxEdge);
			minAspect = Math.Sqrt(minAspect);
			maxAspect = Math.Sqrt(maxAspect);
			minArea *= 0.5;
			maxArea *= 0.5;
			if (minAngle >= 1.0)
			{
				minAngle = 0.0;
			}
			else
			{
				minAngle = num2 * Math.Acos(Math.Sqrt(minAngle));
			}
			if (maxAngle >= 1.0)
			{
				maxAngle = 180.0;
			}
			else if (flag)
			{
				maxAngle = num2 * Math.Acos(Math.Sqrt(maxAngle));
			}
			else
			{
				maxAngle = 180.0 - num2 * Math.Acos(Math.Sqrt(maxAngle));
			}
		}

		internal static void ComputeAngles(ITriangle triangle, double[] data)
		{
			double num = 0.0;
			double num2 = 1.0;
			Vertex vertex = triangle.GetVertex(0);
			Vertex vertex2 = triangle.GetVertex(1);
			Vertex vertex3 = triangle.GetVertex(2);
			double num3 = vertex2.x - vertex3.x;
			double num4 = vertex2.y - vertex3.y;
			double num5 = num3 * num3 + num4 * num4;
			double num6 = vertex3.x - vertex.x;
			double num7 = vertex3.y - vertex.y;
			double num8 = num6 * num6 + num7 * num7;
			double num9 = vertex.x - vertex2.x;
			double num10 = vertex.y - vertex2.y;
			double num11 = num9 * num9 + num10 * num10;
			double num12 = (data[0] = num6 * num9 + num7 * num10);
			double num13 = (data[1] = num9 * num3 + num10 * num4);
			double num14 = (data[2] = num3 * num6 + num4 * num7);
			data[3] = num12 * num12 / (num8 * num11);
			data[4] = num13 * num13 / (num11 * num5);
			data[5] = num14 * num14 / (num5 * num8);
			bool flag = true;
			for (int i = 0; i < 3; i++)
			{
				double num15 = data[i];
				double num16 = data[3 + i];
				if (num15 <= 0.0)
				{
					if (num16 > num)
					{
						num = num16;
					}
					if (flag && num16 < num2)
					{
						num2 = num16;
					}
				}
				else if (flag || num16 > num2)
				{
					num2 = num16;
					flag = false;
				}
			}
			data[0] = num;
			data[1] = num2;
			data[2] = (flag ? 1.0 : (-1.0));
		}
	}
}
