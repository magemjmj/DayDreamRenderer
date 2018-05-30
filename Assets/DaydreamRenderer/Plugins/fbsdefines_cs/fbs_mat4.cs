using daydreamrenderer.FlatBuffers;

namespace daydreamrenderer
{
	public sealed class fbs_mat4 : Struct
	{
		public float M00 => base.bb.GetFloat(base.bb_pos);

		public float M01 => base.bb.GetFloat(base.bb_pos + 4);

		public float M02 => base.bb.GetFloat(base.bb_pos + 8);

		public float M03 => base.bb.GetFloat(base.bb_pos + 12);

		public float M10 => base.bb.GetFloat(base.bb_pos + 16);

		public float M11 => base.bb.GetFloat(base.bb_pos + 20);

		public float M12 => base.bb.GetFloat(base.bb_pos + 24);

		public float M13 => base.bb.GetFloat(base.bb_pos + 28);

		public float M20 => base.bb.GetFloat(base.bb_pos + 32);

		public float M21 => base.bb.GetFloat(base.bb_pos + 36);

		public float M22 => base.bb.GetFloat(base.bb_pos + 40);

		public float M23 => base.bb.GetFloat(base.bb_pos + 44);

		public float M30 => base.bb.GetFloat(base.bb_pos + 48);

		public float M31 => base.bb.GetFloat(base.bb_pos + 52);

		public float M32 => base.bb.GetFloat(base.bb_pos + 56);

		public float M33 => base.bb.GetFloat(base.bb_pos + 60);

		public fbs_mat4 __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public static Offset<fbs_mat4> Createfbs_mat4(FlatBufferBuilder builder, float M00, float M01, float M02, float M03, float M10, float M11, float M12, float M13, float M20, float M21, float M22, float M23, float M30, float M31, float M32, float M33)
		{
			builder.Prep(4, 64);
			builder.PutFloat(M33);
			builder.PutFloat(M32);
			builder.PutFloat(M31);
			builder.PutFloat(M30);
			builder.PutFloat(M23);
			builder.PutFloat(M22);
			builder.PutFloat(M21);
			builder.PutFloat(M20);
			builder.PutFloat(M13);
			builder.PutFloat(M12);
			builder.PutFloat(M11);
			builder.PutFloat(M10);
			builder.PutFloat(M03);
			builder.PutFloat(M02);
			builder.PutFloat(M01);
			builder.PutFloat(M00);
			return new Offset<fbs_mat4>(builder.Offset);
		}
	}
}
