Shader "PlayWay Water/Utilities/Water Mask"
{
	Properties
	{
		_IntensityInv("Intensity Invert", Float) = 0.0
		_WaterId ("", Float) = 128
	}

	CGINCLUDE
	
	#include "UnityCG.cginc"

	struct VertexInput
	{
		float4 vertex	: POSITION;
	};

	struct VertexOutput
	{
		float4 pos	: SV_POSITION;
	};

	half _IntensityInv;
	float _WaterId;

	VertexOutput vert (VertexInput vi)
	{
		VertexOutput vo;
		vo.pos = mul(UNITY_MATRIX_MVP, vi.vertex);

		return vo;
	}

	float4 frag(VertexOutput vo) : SV_Target
	{
		return float4(_WaterId, 1000000, 0, _IntensityInv);
	}

	ENDCG

	SubShader
	{
		Tags { "RenderType"="Transparent" "PerformanceChecks"="False" "Queue"="Transparent" }

		Pass
		{
			ZTest Always Cull Off ZWrite On
			Blend Off

			CGPROGRAM

			#pragma vertex vert
			#pragma fragment frag

			ENDCG
		}
	}
}