using daydreamrenderer.FlatBuffers;
using System;

namespace daydreamrenderer
{
	public sealed class fbs_SamplePatch : Table
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

		public fbs_vec3 Center => GetCenter(new fbs_vec3());

		public fbs_vec3 Size => GetSize(new fbs_vec3());

		public fbs_vec3 Basis0 => GetBasis0(new fbs_vec3());

		public fbs_vec3 Basis1 => GetBasis1(new fbs_vec3());

		public int FacesLength
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

		public static fbs_SamplePatch GetRootAsfbs_SamplePatch(ByteBuffer _bb)
		{
			return GetRootAsfbs_SamplePatch(_bb, new fbs_SamplePatch());
		}

		public static fbs_SamplePatch GetRootAsfbs_SamplePatch(ByteBuffer _bb, fbs_SamplePatch obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_SamplePatch __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public fbs_vec3 GetCenter(fbs_vec3 obj)
		{
			int num = base.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetSize(fbs_vec3 obj)
		{
			int num = base.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetBasis0(fbs_vec3 obj)
		{
			int num = base.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetBasis1(fbs_vec3 obj)
		{
			int num = base.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public uint GetFaces(int j)
		{
			int num = base.__offset(14);
			if (num == 0)
			{
				return 0u;
			}
			return base.bb.GetUint(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetFacesBytes()
		{
			return base.__vector_as_arraysegment(14);
		}

		public static void Startfbs_SamplePatch(FlatBufferBuilder builder)
		{
			builder.StartObject(6);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 0);
		}

		public static void AddCenter(FlatBufferBuilder builder, Offset<fbs_vec3> centerOffset)
		{
			builder.AddStruct(1, centerOffset.Value, 0);
		}

		public static void AddSize(FlatBufferBuilder builder, Offset<fbs_vec3> sizeOffset)
		{
			builder.AddStruct(2, sizeOffset.Value, 0);
		}

		public static void AddBasis0(FlatBufferBuilder builder, Offset<fbs_vec3> basis0Offset)
		{
			builder.AddStruct(3, basis0Offset.Value, 0);
		}

		public static void AddBasis1(FlatBufferBuilder builder, Offset<fbs_vec3> basis1Offset)
		{
			builder.AddStruct(4, basis1Offset.Value, 0);
		}

		public static void AddFaces(FlatBufferBuilder builder, VectorOffset facesOffset)
		{
			builder.AddOffset(5, facesOffset.Value, 0);
		}

		public static VectorOffset CreateFacesVector(FlatBufferBuilder builder, uint[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddUint(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartFacesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static Offset<fbs_SamplePatch> Endfbs_SamplePatch(FlatBufferBuilder builder)
		{
			return new Offset<fbs_SamplePatch>(builder.EndObject());
		}
	}
}
