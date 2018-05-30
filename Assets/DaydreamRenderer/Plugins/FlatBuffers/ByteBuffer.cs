using System;

namespace daydreamrenderer.FlatBuffers
{
	public class ByteBuffer
	{
		private readonly byte[] _buffer;

		private int _pos;

		private float[] floathelper = new float[1];

		private int[] inthelper = new int[1];

		private double[] doublehelper = new double[1];

		private ulong[] ulonghelper = new ulong[1];

		public int Length => _buffer.Length;

		public byte[] Data => _buffer;

		public int Position
		{
			get
			{
				return _pos;
			}
			set
			{
				_pos = value;
			}
		}

		public ByteBuffer(byte[] buffer)
			: this(buffer, 0)
		{
		}

		public ByteBuffer(byte[] buffer, int pos)
		{
			_buffer = buffer;
			_pos = pos;
		}

		public void Reset()
		{
			_pos = 0;
		}

		public static ushort ReverseBytes(ushort input)
		{
			return (ushort)((input & 0xFF) << 8 | (int)((uint)(input & 0xFF00) >> 8));
		}

		public static uint ReverseBytes(uint input)
		{
			return (input & 0xFF) << 24 | (input & 0xFF00) << 8 | (input & 0xFF0000) >> 8 | (uint)((int)input & -16777216) >> 24;
		}

		public static ulong ReverseBytes(ulong input)
		{
			return (input & 0xFF) << 56 | (input & 0xFF00) << 40 | (input & 0xFF0000) << 24 | (input & 4278190080u) << 8 | (input & 0xFF00000000) >> 8 | (input & 0xFF0000000000) >> 24 | (input & 0xFF000000000000) >> 40 | (ulong)((long)input & -72057594037927936L) >> 56;
		}

		protected void WriteLittleEndian(int offset, int count, ulong data)
		{
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < count; i++)
				{
					_buffer[offset + i] = (byte)(data >> i * 8);
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					_buffer[offset + count - 1 - j] = (byte)(data >> j * 8);
				}
			}
		}

		protected ulong ReadLittleEndian(int offset, int count)
		{
			AssertOffsetAndLength(offset, count);
			ulong num = 0uL;
			if (BitConverter.IsLittleEndian)
			{
				for (int i = 0; i < count; i++)
				{
					num |= (ulong)_buffer[offset + i] << i * 8;
				}
			}
			else
			{
				for (int j = 0; j < count; j++)
				{
					num |= (ulong)_buffer[offset + count - 1 - j] << j * 8;
				}
			}
			return num;
		}

		private void AssertOffsetAndLength(int offset, int length)
		{
			if (offset >= 0 && offset <= _buffer.Length - length)
			{
				return;
			}
			throw new ArgumentOutOfRangeException();
		}

		public void PutSbyte(int offset, sbyte value)
		{
			AssertOffsetAndLength(offset, 1);
			_buffer[offset] = (byte)value;
		}

		public void PutByte(int offset, byte value)
		{
			AssertOffsetAndLength(offset, 1);
			_buffer[offset] = value;
		}

		public void PutByte(int offset, byte value, int count)
		{
			AssertOffsetAndLength(offset, count);
			for (int i = 0; i < count; i++)
			{
				_buffer[offset + i] = value;
			}
		}

		public void Put(int offset, byte value)
		{
			PutByte(offset, value);
		}

		public void PutShort(int offset, short value)
		{
			AssertOffsetAndLength(offset, 2);
			WriteLittleEndian(offset, 2, (ulong)value);
		}

		public void PutUshort(int offset, ushort value)
		{
			AssertOffsetAndLength(offset, 2);
			WriteLittleEndian(offset, 2, value);
		}

		public void PutInt(int offset, int value)
		{
			AssertOffsetAndLength(offset, 4);
			WriteLittleEndian(offset, 4, (ulong)value);
		}

		public void PutUint(int offset, uint value)
		{
			AssertOffsetAndLength(offset, 4);
			WriteLittleEndian(offset, 4, value);
		}

		public void PutLong(int offset, long value)
		{
			AssertOffsetAndLength(offset, 8);
			WriteLittleEndian(offset, 8, (ulong)value);
		}

		public void PutUlong(int offset, ulong value)
		{
			AssertOffsetAndLength(offset, 8);
			WriteLittleEndian(offset, 8, value);
		}

		public void PutFloat(int offset, float value)
		{
			AssertOffsetAndLength(offset, 4);
			floathelper[0] = value;
			Buffer.BlockCopy(floathelper, 0, inthelper, 0, 4);
			WriteLittleEndian(offset, 4, (ulong)inthelper[0]);
		}

		public void PutDouble(int offset, double value)
		{
			AssertOffsetAndLength(offset, 8);
			doublehelper[0] = value;
			Buffer.BlockCopy(doublehelper, 0, ulonghelper, 0, 8);
			WriteLittleEndian(offset, 8, ulonghelper[0]);
		}

		public sbyte GetSbyte(int index)
		{
			AssertOffsetAndLength(index, 1);
			return (sbyte)_buffer[index];
		}

		public byte Get(int index)
		{
			AssertOffsetAndLength(index, 1);
			return _buffer[index];
		}

		public short GetShort(int index)
		{
			return (short)ReadLittleEndian(index, 2);
		}

		public ushort GetUshort(int index)
		{
			return (ushort)ReadLittleEndian(index, 2);
		}

		public int GetInt(int index)
		{
			return (int)ReadLittleEndian(index, 4);
		}

		public uint GetUint(int index)
		{
			return (uint)ReadLittleEndian(index, 4);
		}

		public long GetLong(int index)
		{
			return (long)ReadLittleEndian(index, 8);
		}

		public ulong GetUlong(int index)
		{
			return ReadLittleEndian(index, 8);
		}

		public float GetFloat(int index)
		{
			int num = (int)ReadLittleEndian(index, 4);
			inthelper[0] = num;
			Buffer.BlockCopy(inthelper, 0, floathelper, 0, 4);
			return floathelper[0];
		}

		public double GetDouble(int index)
		{
			ulong num = ReadLittleEndian(index, 8);
			ulonghelper[0] = num;
			Buffer.BlockCopy(ulonghelper, 0, doublehelper, 0, 8);
			return doublehelper[0];
		}
	}
}
