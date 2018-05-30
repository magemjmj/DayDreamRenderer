namespace daydreamrenderer.FlatBuffers
{
	public struct Offset<T> where T : class
	{
		public int Value;

		public Offset(int value)
		{
			Value = value;
		}
	}
}
