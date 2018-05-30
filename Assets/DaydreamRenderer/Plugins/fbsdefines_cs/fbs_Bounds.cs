using daydreamrenderer.FlatBuffers;

namespace daydreamrenderer
{
	public sealed class fbs_Bounds : Table
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

		public fbs_vec3 Min => GetMin(new fbs_vec3());

		public fbs_vec3 Max => GetMax(new fbs_vec3());

		public fbs_vec3 Center => GetCenter(new fbs_vec3());

		public fbs_vec3 Size => GetSize(new fbs_vec3());

		public static fbs_Bounds GetRootAsfbs_Bounds(ByteBuffer _bb)
		{
			return GetRootAsfbs_Bounds(_bb, new fbs_Bounds());
		}

		public static fbs_Bounds GetRootAsfbs_Bounds(ByteBuffer _bb, fbs_Bounds obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_Bounds __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public fbs_vec3 GetMin(fbs_vec3 obj)
		{
			int num = base.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetMax(fbs_vec3 obj)
		{
			int num = base.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetCenter(fbs_vec3 obj)
		{
			int num = base.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public fbs_vec3 GetSize(fbs_vec3 obj)
		{
			int num = base.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return obj.__init(num + base.bb_pos, base.bb);
		}

		public static void Startfbs_Bounds(FlatBufferBuilder builder)
		{
			builder.StartObject(5);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 0);
		}

		public static void AddMin(FlatBufferBuilder builder, Offset<fbs_vec3> minOffset)
		{
			builder.AddStruct(1, minOffset.Value, 0);
		}

		public static void AddMax(FlatBufferBuilder builder, Offset<fbs_vec3> maxOffset)
		{
			builder.AddStruct(2, maxOffset.Value, 0);
		}

		public static void AddCenter(FlatBufferBuilder builder, Offset<fbs_vec3> centerOffset)
		{
			builder.AddStruct(3, centerOffset.Value, 0);
		}

		public static void AddSize(FlatBufferBuilder builder, Offset<fbs_vec3> sizeOffset)
		{
			builder.AddStruct(4, sizeOffset.Value, 0);
		}

		public static Offset<fbs_Bounds> Endfbs_Bounds(FlatBufferBuilder builder)
		{
			return new Offset<fbs_Bounds>(builder.EndObject());
		}
	}
}
