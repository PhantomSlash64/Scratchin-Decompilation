using System;
using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Meshing;

namespace UnityEngine.U2D.Animation.TriangleNet.IO
{
	internal static class FileProcessor
	{
		private static List<IFileFormat> formats;

		static FileProcessor()
		{
			formats = new List<IFileFormat>();
			formats.Add(new TriangleFormat());
		}

		internal static void Add(IFileFormat format)
		{
			formats.Add(format);
		}

		internal static bool IsSupported(string file)
		{
			foreach (IFileFormat format in formats)
			{
				if (format.IsSupported(file))
				{
					return true;
				}
			}
			return false;
		}

		internal static IPolygon Read(string filename)
		{
			foreach (IPolygonFormat format in formats)
			{
				if (format != null && format.IsSupported(filename))
				{
					return format.Read(filename);
				}
			}
			throw new Exception("File format not supported.");
		}

		internal static void Write(IPolygon polygon, string filename)
		{
			foreach (IPolygonFormat format in formats)
			{
				if (format != null && format.IsSupported(filename))
				{
					format.Write(polygon, filename);
					return;
				}
			}
			throw new Exception("File format not supported.");
		}

		internal static IMesh Import(string filename)
		{
			foreach (IMeshFormat format in formats)
			{
				if (format != null && format.IsSupported(filename))
				{
					return format.Import(filename);
				}
			}
			throw new Exception("File format not supported.");
		}

		internal static void Write(IMesh mesh, string filename)
		{
			foreach (IMeshFormat format in formats)
			{
				if (format != null && format.IsSupported(filename))
				{
					format.Write(mesh, filename);
					return;
				}
			}
			throw new Exception("File format not supported.");
		}
	}
}
