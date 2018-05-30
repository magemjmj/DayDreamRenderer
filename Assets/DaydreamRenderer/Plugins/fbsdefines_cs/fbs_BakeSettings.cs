using daydreamrenderer.FlatBuffers;
using System;

namespace daydreamrenderer
{
	public sealed class fbs_BakeSettings : Table
	{
		public int Version
		{
			get
			{
				int num = base.__offset(4);
				if (num == 0)
				{
					return 1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public bool ShadowsEnabled
		{
			get
			{
				int num = base.__offset(6);
				if (num == 0)
				{
					return false;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public float RayStartOffset
		{
			get
			{
				int num = base.__offset(8);
				if (num == 0)
				{
					return 0.1f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public int LightBlockerSamples
		{
			get
			{
				int num = base.__offset(10);
				if (num == 0)
				{
					return 64;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public bool AmbientOcclusion
		{
			get
			{
				int num = base.__offset(12);
				if (num == 0)
				{
					return false;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public float NormalBend
		{
			get
			{
				int num = base.__offset(14);
				if (num == 0)
				{
					return 0.16f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public int OccluderSearchSamples
		{
			get
			{
				int num = base.__offset(16);
				if (num == 0)
				{
					return 64;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public float OccluderStartOffset
		{
			get
			{
				int num = base.__offset(18);
				if (num == 0)
				{
					return 0.1f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float OccluderRayLength
		{
			get
			{
				int num = base.__offset(20);
				if (num == 0)
				{
					return 0.5f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public int ColorCubeLength
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

		public int ColorGradientLength
		{
			get
			{
				int num = base.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public int ColorSolidLength
		{
			get
			{
				int num = base.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return base.__vector_len(num);
			}
		}

		public float AmbientMin
		{
			get
			{
				int num = base.__offset(28);
				if (num == 0)
				{
					return 0.2f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float AmbientMax
		{
			get
			{
				int num = base.__offset(30);
				if (num == 0)
				{
					return 0.625f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float DiffuseEnergyConservation
		{
			get
			{
				int num = base.__offset(32);
				if (num == 0)
				{
					return 0.25f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float DebugSlider
		{
			get
			{
				int num = base.__offset(34);
				if (num == 0)
				{
					return 0f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public int ColorMode
		{
			get
			{
				int num = base.__offset(36);
				if (num == 0)
				{
					return 1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public bool AoForceDoubleSidedGeo
		{
			get
			{
				int num = base.__offset(38);
				if (num == 0)
				{
					return false;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public bool TessEnabled
		{
			get
			{
				int num = base.__offset(40);
				if (num == 0)
				{
					return true;
				}
				return base.bb.Get(num + base.bb_pos) != 0;
			}
		}

		public int MaxTessIterations
		{
			get
			{
				int num = base.__offset(42);
				if (num == 0)
				{
					return -1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MaxTessVertices
		{
			get
			{
				int num = base.__offset(44);
				if (num == 0)
				{
					return -1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MinTessIterations
		{
			get
			{
				int num = base.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MaxAOTessIterations
		{
			get
			{
				int num = base.__offset(48);
				if (num == 0)
				{
					return -1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MaxShadowSoftTessIterations
		{
			get
			{
				int num = base.__offset(50);
				if (num == 0)
				{
					return 2;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MaxShadowHardTessIterations
		{
			get
			{
				int num = base.__offset(52);
				if (num == 0)
				{
					return 4;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public int MaxIntensityTessIterations
		{
			get
			{
				int num = base.__offset(54);
				if (num == 0)
				{
					return -1;
				}
				return base.bb.GetInt(num + base.bb_pos);
			}
		}

		public float IntesityThreshold
		{
			get
			{
				int num = base.__offset(56);
				if (num == 0)
				{
					return 0.35f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float AvgIntensityThreshold
		{
			get
			{
				int num = base.__offset(58);
				if (num == 0)
				{
					return 0.1f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float SurfaceLightThresholdMin
		{
			get
			{
				int num = base.__offset(60);
				if (num == 0)
				{
					return 0.23f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float SurfaceLightThresholdMax
		{
			get
			{
				int num = base.__offset(62);
				if (num == 0)
				{
					return 0.85f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public float AccessabilityThreshold
		{
			get
			{
				int num = base.__offset(64);
				if (num == 0)
				{
					return 0.65f;
				}
				return base.bb.GetFloat(num + base.bb_pos);
			}
		}

		public static fbs_BakeSettings GetRootAsfbs_BakeSettings(ByteBuffer _bb)
		{
			return GetRootAsfbs_BakeSettings(_bb, new fbs_BakeSettings());
		}

		public static fbs_BakeSettings GetRootAsfbs_BakeSettings(ByteBuffer _bb, fbs_BakeSettings obj)
		{
			return obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		public fbs_BakeSettings __init(int _i, ByteBuffer _bb)
		{
			base.bb_pos = _i;
			base.bb = _bb;
			return this;
		}

		public float GetColorCube(int j)
		{
			int num = base.__offset(22);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetColorCubeBytes()
		{
			return base.__vector_as_arraysegment(22);
		}

		public float GetColorGradient(int j)
		{
			int num = base.__offset(24);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetColorGradientBytes()
		{
			return base.__vector_as_arraysegment(24);
		}

		public float GetColorSolid(int j)
		{
			int num = base.__offset(26);
			if (num == 0)
			{
				return 0f;
			}
			return base.bb.GetFloat(base.__vector(num) + j * 4);
		}

		public ArraySegment<byte>? GetColorSolidBytes()
		{
			return base.__vector_as_arraysegment(26);
		}

		public static Offset<fbs_BakeSettings> Createfbs_BakeSettings(FlatBufferBuilder builder, int version = 1, bool shadowsEnabled = false, float rayStartOffset = 0.1f, int lightBlockerSamples = 64, bool ambientOcclusion = false, float normalBend = 0.16f, int occluderSearchSamples = 64, float occluderStartOffset = 0.1f, float occluderRayLength = 0.5f, VectorOffset colorCubeOffset = default(VectorOffset), VectorOffset colorGradientOffset = default(VectorOffset), VectorOffset colorSolidOffset = default(VectorOffset), float ambientMin = 0.2f, float ambientMax = 0.625f, float diffuseEnergyConservation = 0.25f, float debugSlider = 0f, int colorMode = 1, bool aoForceDoubleSidedGeo = false, bool tessEnabled = true, int maxTessIterations = -1, int maxTessVertices = -1, int minTessIterations = 0, int maxAOTessIterations = -1, int maxShadowSoftTessIterations = 2, int maxShadowHardTessIterations = 4, int maxIntensityTessIterations = -1, float intesityThreshold = 0.35f, float avgIntensityThreshold = 0.1f, float surfaceLightThresholdMin = 0.23f, float surfaceLightThresholdMax = 0.85f, float accessabilityThreshold = 0.65f)
		{
			builder.StartObject(31);
			AddAccessabilityThreshold(builder, accessabilityThreshold);
			AddSurfaceLightThresholdMax(builder, surfaceLightThresholdMax);
			AddSurfaceLightThresholdMin(builder, surfaceLightThresholdMin);
			AddAvgIntensityThreshold(builder, avgIntensityThreshold);
			AddIntesityThreshold(builder, intesityThreshold);
			AddMaxIntensityTessIterations(builder, maxIntensityTessIterations);
			AddMaxShadowHardTessIterations(builder, maxShadowHardTessIterations);
			AddMaxShadowSoftTessIterations(builder, maxShadowSoftTessIterations);
			AddMaxAOTessIterations(builder, maxAOTessIterations);
			AddMinTessIterations(builder, minTessIterations);
			AddMaxTessVertices(builder, maxTessVertices);
			AddMaxTessIterations(builder, maxTessIterations);
			AddColorMode(builder, colorMode);
			AddDebugSlider(builder, debugSlider);
			AddDiffuseEnergyConservation(builder, diffuseEnergyConservation);
			AddAmbientMax(builder, ambientMax);
			AddAmbientMin(builder, ambientMin);
			AddColorSolid(builder, colorSolidOffset);
			AddColorGradient(builder, colorGradientOffset);
			AddColorCube(builder, colorCubeOffset);
			AddOccluderRayLength(builder, occluderRayLength);
			AddOccluderStartOffset(builder, occluderStartOffset);
			AddOccluderSearchSamples(builder, occluderSearchSamples);
			AddNormalBend(builder, normalBend);
			AddLightBlockerSamples(builder, lightBlockerSamples);
			AddRayStartOffset(builder, rayStartOffset);
			AddVersion(builder, version);
			AddTessEnabled(builder, tessEnabled);
			AddAoForceDoubleSidedGeo(builder, aoForceDoubleSidedGeo);
			AddAmbientOcclusion(builder, ambientOcclusion);
			AddShadowsEnabled(builder, shadowsEnabled);
			return Endfbs_BakeSettings(builder);
		}

		public static void Startfbs_BakeSettings(FlatBufferBuilder builder)
		{
			builder.StartObject(31);
		}

		public static void AddVersion(FlatBufferBuilder builder, int version)
		{
			builder.AddInt(0, version, 1);
		}

		public static void AddShadowsEnabled(FlatBufferBuilder builder, bool shadowsEnabled)
		{
			builder.AddBool(1, shadowsEnabled, false);
		}

		public static void AddRayStartOffset(FlatBufferBuilder builder, float rayStartOffset)
		{
			builder.AddFloat(2, rayStartOffset, 0.10000000149011612);
		}

		public static void AddLightBlockerSamples(FlatBufferBuilder builder, int lightBlockerSamples)
		{
			builder.AddInt(3, lightBlockerSamples, 64);
		}

		public static void AddAmbientOcclusion(FlatBufferBuilder builder, bool ambientOcclusion)
		{
			builder.AddBool(4, ambientOcclusion, false);
		}

		public static void AddNormalBend(FlatBufferBuilder builder, float normalBend)
		{
			builder.AddFloat(5, normalBend, 0.15999999642372131);
		}

		public static void AddOccluderSearchSamples(FlatBufferBuilder builder, int occluderSearchSamples)
		{
			builder.AddInt(6, occluderSearchSamples, 64);
		}

		public static void AddOccluderStartOffset(FlatBufferBuilder builder, float occluderStartOffset)
		{
			builder.AddFloat(7, occluderStartOffset, 0.10000000149011612);
		}

		public static void AddOccluderRayLength(FlatBufferBuilder builder, float occluderRayLength)
		{
			builder.AddFloat(8, occluderRayLength, 0.5);
		}

		public static void AddColorCube(FlatBufferBuilder builder, VectorOffset colorCubeOffset)
		{
			builder.AddOffset(9, colorCubeOffset.Value, 0);
		}

		public static VectorOffset CreateColorCubeVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartColorCubeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddColorGradient(FlatBufferBuilder builder, VectorOffset colorGradientOffset)
		{
			builder.AddOffset(10, colorGradientOffset.Value, 0);
		}

		public static VectorOffset CreateColorGradientVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartColorGradientVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddColorSolid(FlatBufferBuilder builder, VectorOffset colorSolidOffset)
		{
			builder.AddOffset(11, colorSolidOffset.Value, 0);
		}

		public static VectorOffset CreateColorSolidVector(FlatBufferBuilder builder, float[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int num = data.Length - 1; num >= 0; num--)
			{
				builder.AddFloat(data[num]);
			}
			return builder.EndVector();
		}

		public static void StartColorSolidVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		public static void AddAmbientMin(FlatBufferBuilder builder, float ambientMin)
		{
			builder.AddFloat(12, ambientMin, 0.20000000298023224);
		}

		public static void AddAmbientMax(FlatBufferBuilder builder, float ambientMax)
		{
			builder.AddFloat(13, ambientMax, 0.625);
		}

		public static void AddDiffuseEnergyConservation(FlatBufferBuilder builder, float diffuseEnergyConservation)
		{
			builder.AddFloat(14, diffuseEnergyConservation, 0.25);
		}

		public static void AddDebugSlider(FlatBufferBuilder builder, float debugSlider)
		{
			builder.AddFloat(15, debugSlider, 0.0);
		}

		public static void AddColorMode(FlatBufferBuilder builder, int colorMode)
		{
			builder.AddInt(16, colorMode, 1);
		}

		public static void AddAoForceDoubleSidedGeo(FlatBufferBuilder builder, bool aoForceDoubleSidedGeo)
		{
			builder.AddBool(17, aoForceDoubleSidedGeo, false);
		}

		public static void AddTessEnabled(FlatBufferBuilder builder, bool tessEnabled)
		{
			builder.AddBool(18, tessEnabled, true);
		}

		public static void AddMaxTessIterations(FlatBufferBuilder builder, int maxTessIterations)
		{
			builder.AddInt(19, maxTessIterations, -1);
		}

		public static void AddMaxTessVertices(FlatBufferBuilder builder, int maxTessVertices)
		{
			builder.AddInt(20, maxTessVertices, -1);
		}

		public static void AddMinTessIterations(FlatBufferBuilder builder, int minTessIterations)
		{
			builder.AddInt(21, minTessIterations, 0);
		}

		public static void AddMaxAOTessIterations(FlatBufferBuilder builder, int maxAOTessIterations)
		{
			builder.AddInt(22, maxAOTessIterations, -1);
		}

		public static void AddMaxShadowSoftTessIterations(FlatBufferBuilder builder, int maxShadowSoftTessIterations)
		{
			builder.AddInt(23, maxShadowSoftTessIterations, 2);
		}

		public static void AddMaxShadowHardTessIterations(FlatBufferBuilder builder, int maxShadowHardTessIterations)
		{
			builder.AddInt(24, maxShadowHardTessIterations, 4);
		}

		public static void AddMaxIntensityTessIterations(FlatBufferBuilder builder, int maxIntensityTessIterations)
		{
			builder.AddInt(25, maxIntensityTessIterations, -1);
		}

		public static void AddIntesityThreshold(FlatBufferBuilder builder, float intesityThreshold)
		{
			builder.AddFloat(26, intesityThreshold, 0.34999999403953552);
		}

		public static void AddAvgIntensityThreshold(FlatBufferBuilder builder, float avgIntensityThreshold)
		{
			builder.AddFloat(27, avgIntensityThreshold, 0.10000000149011612);
		}

		public static void AddSurfaceLightThresholdMin(FlatBufferBuilder builder, float surfaceLightThresholdMin)
		{
			builder.AddFloat(28, surfaceLightThresholdMin, 0.23000000417232513);
		}

		public static void AddSurfaceLightThresholdMax(FlatBufferBuilder builder, float surfaceLightThresholdMax)
		{
			builder.AddFloat(29, surfaceLightThresholdMax, 0.85000002384185791);
		}

		public static void AddAccessabilityThreshold(FlatBufferBuilder builder, float accessabilityThreshold)
		{
			builder.AddFloat(30, accessabilityThreshold, 0.64999997615814209);
		}

		public static Offset<fbs_BakeSettings> Endfbs_BakeSettings(FlatBufferBuilder builder)
		{
			return new Offset<fbs_BakeSettings>(builder.EndObject());
		}

		public static void Finishfbs_BakeSettingsBuffer(FlatBufferBuilder builder, Offset<fbs_BakeSettings> offset)
		{
			builder.Finish(offset.Value);
		}
	}
}
