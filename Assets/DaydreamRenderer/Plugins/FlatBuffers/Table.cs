using System;
using System.Text;

namespace daydreamrenderer.FlatBuffers
{
	public abstract class Table
	{
		protected int bb_pos;

		protected ByteBuffer bb;

		public ByteBuffer ByteBuffer => bb;

		protected int __offset(int vtableOffset)
		{
			int num = bb_pos - bb.GetInt(bb_pos);
			if (vtableOffset >= bb.GetShort(num))
			{
				return 0;
			}
			return bb.GetShort(num + vtableOffset);
		}

		protected static int __offset(int vtableOffset, int offset, ByteBuffer bb)
		{
			int num = bb.Length - offset;
			return bb.GetShort(num + vtableOffset - bb.GetInt(num)) + num;
		}

		protected int __indirect(int offset)
		{
			return offset + bb.GetInt(offset);
		}

		protected static int __indirect(int offset, ByteBuffer bb)
		{
			return offset + bb.GetInt(offset);
		}

		protected string __string(int offset)
		{
			offset += bb.GetInt(offset);
			int @int = bb.GetInt(offset);
			int index = offset + 4;
			return Encoding.UTF8.GetString(bb.Data, index, @int);
		}

		protected int __vector_len(int offset)
		{
			offset += bb_pos;
			offset += bb.GetInt(offset);
			return bb.GetInt(offset);
		}

		protected int __vector(int offset)
		{
			offset += bb_pos;
			return offset + bb.GetInt(offset) + 4;
		}

		protected ArraySegment<byte>? __vector_as_arraysegment(int offset)
		{
			int num = __offset(offset);
			if (num == 0)
			{
				return null;
			}
			int offset2 = __vector(num);
			int count = __vector_len(num);
			return new ArraySegment<byte>(bb.Data, offset2, count);
		}

		protected TTable __union<TTable>(TTable t, int offset) where TTable : Table
		{
			offset += bb_pos;
			t.bb_pos = offset + bb.GetInt(offset);
			t.bb = bb;
			return t;
		}

		protected static bool __has_identifier(ByteBuffer bb, string ident)
		{
			if (ident.Length != 4)
			{
				throw new ArgumentException("FlatBuffers: file identifier must be length " + 4, "ident");
			}
			for (int i = 0; i < 4; i++)
			{
				if (ident[i] != bb.Get(bb.Position + 4 + i))
				{
					return false;
				}
			}
			return true;
		}

		protected static int CompareStrings(int offset_1, int offset_2, ByteBuffer bb)
		{
			offset_1 += bb.GetInt(offset_1);
			offset_2 += bb.GetInt(offset_2);
			int @int = bb.GetInt(offset_1);
			int int2 = bb.GetInt(offset_2);
			int num = offset_1 + 4;
			int num2 = offset_2 + 4;
			int num3 = Math.Min(@int, int2);
			byte[] data = bb.Data;
			for (int i = 0; i < num3; i++)
			{
				if (data[i + num] != data[i + num2])
				{
					return data[i + num] - data[i + num2];
				}
			}
			return @int - int2;
		}

		protected static int CompareStrings(int offset_1, byte[] key, ByteBuffer bb)
		{
			offset_1 += bb.GetInt(offset_1);
			int @int = bb.GetInt(offset_1);
			int num = key.Length;
			int num2 = offset_1 + 4;
			int num3 = Math.Min(@int, num);
			byte[] data = bb.Data;
			for (int i = 0; i < num3; i++)
			{
				if (data[i + num2] != key[i])
				{
					return data[i + num2] - key[i];
				}
			}
			return @int - num;
		}
	}
}
