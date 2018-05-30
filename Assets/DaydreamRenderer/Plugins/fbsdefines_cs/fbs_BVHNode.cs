using daydreamrenderer.FlatBuffers;
using System;

namespace daydreamrenderer
{
	public sealed class fbs_BVHNode : Table
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

		public int InstanceId
		{
			get
			{
				int num = base.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public bool BoundsSet
		{
			get
			{
				int num = base.__offset(8);
				if (num == 0)
				{
					return false;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public bool Leaf
		{
			get
			{
				int num = base.__offset(10);
				if (num == 0)
				{
					return false;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public fbs_Bounds Bounds => GetBounds(new fbs_Bounds());

		public int TriangleCount
		{
			get
			{
				int num = base.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int PositionsLength
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

		public int TrianglesLength
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

		public int ChildrenLength
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

		public int MasterListLength
		{
			get
			{
				int num = base.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int Id
		{
			get
			{
				int num = base.__offset(24);
				if (num == 0)
				{
					return -1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public fbs_vec3 CentroidMin => GetCentroidMin(new fbs_vec3());

		public fbs_vec3 CentroidMax => GetCentroidMax(new fbs_vec3());

		public int WorldLength
		{
			get
			{
				int num = base.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public uint MeshOpt
		{
			get
			{
				int num = base.__offset(32);
				if (num == 0)
				{
					return 0u;
				}
				return base.bb.GetUint(num + base.bb_pos);
			}
		}

		public uint Layer
		{
			get
			{
				int num = base.__offset(34);
				if (num == 0)
				{
					return 0u;
				}
				return base.bb.GetUint(num + base.bb_pos);
			}
		}

		public int FaceCount
		{
			get
			{
				int num = base.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int FacesLength
		{
			get
			{
				int num = base.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public static fbs_BVHNode GetRootAsfbs_BVHNode(ByteBuffer _bb)
		{
			return GetRootAsfbs_BVHNode(_bb, new fbs_BVHNode());
		}

		public static fbs_BVHNode GetRootAsfbs_BVHNode(ByteBuffer _bb, fbs_BVHNode obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_BVHNode __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public fbs_Bounds GetBounds(fbs_Bounds obj)
		{
			int num = base.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(base.__indirect(num + base.bb_pos), base.bb);
		}

		public float GetPositions(int j)
		{
			int num = base.__offset(16);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetPositionsBytes()
		{
			return base.__vector_as_arraysegment(16);
		}

		public ushort GetTriangles(int j)
		{
			int num = base.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return base.bb.GetUshort(base.__vector(num) + j * 2);
		}

		public ArraySegment<byte>? GetTrianglesBytes()
		{
			return base.__vector_as_arraysegment(18);
		}

		public ushort GetChildren(int j)
		{
			int num = base.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return base.bb.GetUshort(base.__vector(num) + j * 2);
		}

		public ArraySegment<byte>? GetChildrenBytes()
		{
			return base.__vector_as_arraysegment(20);
		}

		public fbs_BVHNode GetMasterList(int j)
		{
			return GetMasterList(new fbs_BVHNode(), j);
		}

		public fbs_BVHNode GetMasterList(fbs_BVHNode obj, int j)
		{
			int num = base.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(base.__indirect(base.__vector(num) + j * 4), base.bb);
		}

		public fbs_vec3 GetCentroidMin(fbs_vec3 obj)
		{
			int num = base.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetCentroidMax(fbs_vec3 obj)
		{
			int num = base.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public float GetWorld(int j)
		{
			int num = base.__offset(30);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetWorldBytes()
		{
			return base.__vector_as_arraysegment(30);
		}

		public ushort GetFaces(int j)
		{
			int num = base.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return base.bb.GetUshort(base.__vector(num) + j * 2);
		}

		public ArraySegment<byte>? GetFacesBytes()
		{
			return base.__vector_as_arraysegment(38);
		}

		public static void Startfbs_BVHNode(FlatBufferBuilder builder)
		{
			builder.StartObject(18);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 0);
		}

		public static void AddInstanceId(FlatBufferBuilder builder, int instanceId)
		{
			builder.AddInt(1, instanceId, 0);
		}

		public static void AddBoundsSet(FlatBufferBuilder builder, bool boundsSet)
		{
			builder.AddBool(2, boundsSet, false);
		}

		public static void AddLeaf(FlatBufferBuilder builder, bool leaf)
		{
			builder.AddBool(3, leaf, false);
		}

		public static void AddBounds(FlatBufferBuilder builder, Offset<fbs_Bounds> boundsOffset)
		{
			builder.AddOffset(4, boundsOffset.Value, 0);
		}

		public static void AddTriangleCount(FlatBufferBuilder builder, int triangleCount)
		{
			builder.AddInt(5, triangleCount, 0);
		}

		public static void AddPositions(FlatBufferBuilder builder, VectorOffset positionsOffset)
		{
			builder.AddOffset(6, positionsOffset.Value, 0);
		}

		public static VectorOffset CreatePositionsVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartPositionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddTriangles(FlatBufferBuilder builder, VectorOffset trianglesOffset)
		{
			builder.AddOffset(7, trianglesOffset.Value, 0);
		}

		public static VectorOffset CreateTrianglesVector(FlatBufferBuilder builder, ushort[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUshort(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartTrianglesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		public static void AddChildren(FlatBufferBuilder builder, VectorOffset childrenOffset)
		{
			builder.AddOffset(8, childrenOffset.Value, 0);
		}

		public static VectorOffset CreateChildrenVector(FlatBufferBuilder builder, ushort[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUshort(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartChildrenVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		public static void AddMasterList(FlatBufferBuilder builder, VectorOffset masterListOffset)
		{
			builder.AddOffset(9, masterListOffset.Value, 0);
		}

		public static VectorOffset CreateMasterListVector(FlatBufferBuilder builder, Offset<fbs_BVHNode>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddOffset(data[num].Value);
			}
			return builder.EndVector();
		}

		public static void StartMasterListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(10, id, -1);
		}

		public static void AddCentroidMin(FlatBufferBuilder builder, Offset<fbs_vec3> centroidMinOffset)
		{
			builder.AddStruct(11, centroidMinOffset.Value, 0);
		}

		public static void AddCentroidMax(FlatBufferBuilder builder, Offset<fbs_vec3> centroidMaxOffset)
		{
			builder.AddStruct(12, centroidMaxOffset.Value, 0);
		}

		public static void AddWorld(FlatBufferBuilder builder, VectorOffset worldOffset)
		{
			builder.AddOffset(13, worldOffset.Value, 0);
		}

		public static VectorOffset CreateWorldVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartWorldVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddMeshOpt(FlatBufferBuilder builder, uint meshOpt)
		{
			builder.AddUint(14, meshOpt, 0u);
		}

		public static void AddLayer(FlatBufferBuilder builder, uint layer)
		{
			builder.AddUint(15, layer, 0u);
		}

		public static void AddFaceCount(FlatBufferBuilder builder, int faceCount)
		{
			builder.AddInt(16, faceCount, 0);
		}

		public static void AddFaces(FlatBufferBuilder builder, VectorOffset facesOffset)
		{
			builder.AddOffset(17, facesOffset.Value, 0);
		}

		public static VectorOffset CreateFacesVector(FlatBufferBuilder builder, ushort[] data)
		{
			builder.StartVector(2, data.Length, 2);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUshort(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartFacesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(2, numElems, 2);
		}

		public static Offset<fbs_BVHNode> Endfbs_BVHNode(FlatBufferBuilder builder)
		{
			return new Offset<fbs_BVHNode>(builder.EndObject());
		}

		public static void Finishfbs_BVHNodeBuffer(FlatBufferBuilder builder, Offset<fbs_BVHNode> offset)
		{
			builder.Finish(offset.Value);
		}
	}
}
