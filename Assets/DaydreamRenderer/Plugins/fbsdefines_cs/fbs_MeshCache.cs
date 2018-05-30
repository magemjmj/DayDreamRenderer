using daydreamrenderer.FlatBuffers;
using System;

namespace daydreamrenderer
{
	public sealed class fbs_MeshCache : Table
	{
		public int Version
		{
			get
			{
				int num = base.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public string SourceGuid
		{
			get
			{
				int num = base.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return base.__string(num + base.bb_pos);
			}
		}

		public string SourceAssetPath
		{
			get
			{
				int num = base.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return base.__string(num + base.bb_pos);
			}
		}

		public int AdjacenciesLength
		{
			get
			{
				int num = base.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int PatchRadiusLength
		{
			get
			{
				int num = base.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int BentNormalsLength
		{
			get
			{
				int num = base.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int BentWNormalsLength
		{
			get
			{
				int num = base.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int TriangleMapLength
		{
			get
			{
				int num = base.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int EdgeMapLength
		{
			get
			{
				int num = base.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public static fbs_MeshCache GetRootAsfbs_MeshCache(ByteBuffer _bb)
		{
			return GetRootAsfbs_MeshCache(_bb, new fbs_MeshCache());
		}

		public static fbs_MeshCache GetRootAsfbs_MeshCache(ByteBuffer _bb, fbs_MeshCache obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_MeshCache __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public ArraySegment<byte>? GetSourceGuidBytes()
		{
			return base.__vector_as_arraysegment(6);
		}

		public ArraySegment<byte>? GetSourceAssetPathBytes()
		{
			return base.__vector_as_arraysegment(8);
		}

		public ushort GetAdjacencies(int j)
		{
			int num = base.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return base.bb.GetUshort(base.__vector(num) + j * 2);
		}

		public ArraySegment<byte>? GetAdjacenciesBytes()
		{
			return base.__vector_as_arraysegment(10);
		}

		public float GetPatchRadius(int j)
		{
			int num = base.__offset(12);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetPatchRadiusBytes()
		{
			return base.__vector_as_arraysegment(12);
		}

		public float GetBentNormals(int j)
		{
			int num = base.__offset(14);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetBentNormalsBytes()
		{
			return base.__vector_as_arraysegment(14);
		}

		public float GetBentWNormals(int j)
		{
			int num = base.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetBentWNormalsBytes()
		{
			return base.__vector_as_arraysegment(16);
		}

		public uint GetTriangleMap(int j)
		{
			int num = base.__offset(18);
			if (num == 0)
			{
				return 0u;
			}
			return base.bb.GetUint(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetTriangleMapBytes()
		{
			return base.__vector_as_arraysegment(18);
		}

		public uint GetEdgeMap(int j)
		{
			int num = base.__offset(20);
			if (num == 0)
			{
				return 0u;
			}
			return base.bb.GetUint(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetEdgeMapBytes()
		{
			return base.__vector_as_arraysegment(20);
		}

		public static Offset<fbs_MeshCache> Createfbs_MeshCache(FlatBufferBuilder builder, int version = 0, StringOffset sourceGuidOffset = default(StringOffset), StringOffset sourceAssetPathOffset = default(StringOffset), VectorOffset adjacenciesOffset = default(VectorOffset), VectorOffset patchRadiusOffset = default(VectorOffset), VectorOffset bentNormalsOffset = default(VectorOffset), VectorOffset bentWNormalsOffset = default(VectorOffset), VectorOffset triangleMapOffset = default(VectorOffset), VectorOffset edgeMapOffset = default(VectorOffset))
		{
			builder.StartObject(9);
			AddEdgeMap(builder, edgeMapOffset);
			AddTriangleMap(builder, triangleMapOffset);
			AddBentWNormals(builder, bentWNormalsOffset);
			AddBentNormals(builder, bentNormalsOffset);
			AddPatchRadius(builder, patchRadiusOffset);
			AddAdjacencies(builder, adjacenciesOffset);
			AddSourceAssetPath(builder, sourceAssetPathOffset);
			AddSourceGuid(builder, sourceGuidOffset);
			AddVersion(builder, version);
			return Endfbs_MeshCache(builder);
		}

		public static void Startfbs_MeshCache(FlatBufferBuilder builder)
		{
			builder.StartObject(9);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 0);
		}

		public static void AddSourceGuid(FlatBufferBuilder builder, StringOffset sourceGuidOffset)
		{
			builder.AddOffset(1, sourceGuidOffset.Value, 0);
		}

		public static void AddSourceAssetPath(FlatBufferBuilder builder, StringOffset sourceAssetPathOffset)
		{
			builder.AddOffset(2, sourceAssetPathOffset.Value, 0);
		}

		public static void AddAdjacencies(FlatBufferBuilder builder, VectorOffset adjacenciesOffset)
		{
			builder.AddOffset(3, adjacenciesOffset.Value, 0);
		}

		public static VectorOffset CreateAdjacenciesVector(FlatBufferBuilder builder, ushort[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUshort(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartAdjacenciesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		public static void AddPatchRadius(FlatBufferBuilder builder, VectorOffset patchRadiusOffset)
		{
			builder.AddOffset(4, patchRadiusOffset.Value, 0);
		}

		public static VectorOffset CreatePatchRadiusVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartPatchRadiusVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddBentNormals(FlatBufferBuilder builder, VectorOffset bentNormalsOffset)
		{
			builder.AddOffset(5, bentNormalsOffset.Value, 0);
		}

		public static VectorOffset CreateBentNormalsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartBentNormalsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddBentWNormals(FlatBufferBuilder builder, VectorOffset bentWNormalsOffset)
		{
			builder.AddOffset(6, bentWNormalsOffset.Value, 0);
		}

		public static VectorOffset CreateBentWNormalsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartBentWNormalsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddTriangleMap(FlatBufferBuilder builder, VectorOffset triangleMapOffset)
		{
			builder.AddOffset(7, triangleMapOffset.Value, 0);
		}

		public static VectorOffset CreateTriangleMapVector(FlatBufferBuilder builder, uint[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUint(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartTriangleMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddEdgeMap(FlatBufferBuilder builder, VectorOffset edgeMapOffset)
		{
			builder.AddOffset(8, edgeMapOffset.Value, 0);
		}

		public static VectorOffset CreateEdgeMapVector(FlatBufferBuilder builder, uint[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUint(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartEdgeMapVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<fbs_MeshCache> Endfbs_MeshCache(FlatBufferBuilder builder)
		{
			return new Offset<fbs_MeshCache>(builder.EndObject());
		}

		public static void Finishfbs_MeshCacheBuffer(FlatBufferBuilder builder, Offset<fbs_MeshCache> offset)
		{
			builder.Finish(offset.Value);
		}
	}
}
