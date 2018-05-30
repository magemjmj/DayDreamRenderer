using daydreamrenderer.FlatBuffers;
using System;

namespace daydreamrenderer
{
	public sealed class fbs_BVH : Table
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

		public int InstanceID
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

		public int SamplePatchLength
		{
			get
			{
				int num = base.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int WorldLength
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

		public int MasterListLength
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

		public string CacheGuid
		{
			get
			{
				int num = base.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return base.__string(num + base.bb_pos);
			}
		}

		public uint MeshOpt
		{
			get
			{
				int num = base.__offset(16);
				if (num == 0)
				{
					return 0u;
				}
				return base.bb.GetUint(num + base.bb_pos);
			}
		}

		public static fbs_BVH GetRootAsfbs_BVH(ByteBuffer _bb)
		{
			return GetRootAsfbs_BVH(_bb, new fbs_BVH());
		}

		public static fbs_BVH GetRootAsfbs_BVH(ByteBuffer _bb, fbs_BVH obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_BVH __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public fbs_SamplePatch GetSamplePatch(int j)
		{
			return GetSamplePatch(new fbs_SamplePatch(), j);
		}

		public fbs_SamplePatch GetSamplePatch(fbs_SamplePatch obj, int j)
		{
			int num = base.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(base.__indirect(base.__vector(num) + j * 4), base.bb);
		}

		public float GetWorld(int j)
		{
			int num = base.__offset(10);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetWorldBytes()
		{
			return base.__vector_as_arraysegment(10);
		}

		public fbs_BVHNode GetMasterList(int j)
		{
			return GetMasterList(new fbs_BVHNode(), j);
		}

		public fbs_BVHNode GetMasterList(fbs_BVHNode obj, int j)
		{
			int num = base.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(base.__indirect(base.__vector(num) + j * 4), base.bb);
		}

		public ArraySegment<byte>? GetCacheGuidBytes()
		{
			return base.__vector_as_arraysegment(14);
		}

		public static Offset<fbs_BVH> Createfbs_BVH(FlatBufferBuilder builder, int version = 0, int instanceID = 0, VectorOffset samplePatchOffset = default(VectorOffset), VectorOffset worldOffset = default(VectorOffset), VectorOffset masterListOffset = default(VectorOffset), StringOffset cacheGuidOffset = default(StringOffset), uint meshOpt = 0u)
		{
			builder.StartObject(7);
			AddMeshOpt(builder, meshOpt);
			AddCacheGuid(builder, cacheGuidOffset);
			AddMasterList(builder, masterListOffset);
			AddWorld(builder, worldOffset);
			AddSamplePatch(builder, samplePatchOffset);
			AddInstanceID(builder, instanceID);
			AddVersion(builder, version);
			return Endfbs_BVH(builder);
		}

		public static void Startfbs_BVH(FlatBufferBuilder builder)
		{
			builder.StartObject(7);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 0);
		}

		public static void AddInstanceID(FlatBufferBuilder builder, int instanceID)
		{
			builder.AddInt(1, instanceID, 0);
		}

		public static void AddSamplePatch(FlatBufferBuilder builder, VectorOffset samplePatchOffset)
		{
			builder.AddOffset(2, samplePatchOffset.Value, 0);
		}

		public static VectorOffset CreateSamplePatchVector(FlatBufferBuilder builder, Offset<fbs_SamplePatch>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddOffset(data[num].Value);
			}
			return builder.EndVector();
		}

		public static void StartSamplePatchVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddWorld(FlatBufferBuilder builder, VectorOffset worldOffset)
		{
			builder.AddOffset(3, worldOffset.Value, 0);
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

		public static void AddMasterList(FlatBufferBuilder builder, VectorOffset masterListOffset)
		{
			builder.AddOffset(4, masterListOffset.Value, 0);
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

		public static void AddCacheGuid(FlatBufferBuilder builder, StringOffset cacheGuidOffset)
		{
			builder.AddOffset(5, cacheGuidOffset.Value, 0);
		}

		public static void AddMeshOpt(FlatBufferBuilder builder, uint meshOpt)
		{
			builder.AddUint(6, meshOpt, 0u);
		}

		public static Offset<fbs_BVH> Endfbs_BVH(FlatBufferBuilder builder)
		{
			return new Offset<fbs_BVH>(builder.EndObject());
		}

		public static void Finishfbs_BVHBuffer(FlatBufferBuilder builder, Offset<fbs_BVH> offset)
		{
			builder.Finish(offset.Value);
		}
	}
}
