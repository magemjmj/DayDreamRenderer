using daydreamrenderer.FlatBuffers;

namespace daydreamrenderer
{
	public sealed class fbs_vec3 : Struct
	{
		public float X => base.bb.GetFloat(base.bb_pos);

		public float Y => base.bb.GetFloat(base.bb_pos + 4);

		public float Z => base.bb.GetFloat(base.bb_pos + 8);

		public fbs_vec3 __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public static Offset<fbs_vec3> Createfbs_vec3(FlatBufferBuilder builder, float X, float Y, float Z)
		{
			builder.Prep(4, 12);
			builder.PutFloat(Z);
			builder.PutFloat(Y);
			builder.PutFloat(X);
			return new Offset<fbs_vec3>(builder.Offset);
		}
	}
}
