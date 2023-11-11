Shader "Hidden/PostProcessing/CopyStdFromTexArray" {
	Properties {
		_MainTex ("", 2DArray) = "white" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 42606
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float _DepthSlice;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			UNITY_DECLARE_TEX2DARRAY(_MainTex);
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                o.texcoord.z = _DepthSlice;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                o.sv_target = UNITY_SAMPLE_TEX2DARRAY(_MainTex, inp.texcoord.xyz);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 92485
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float _DepthSlice;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			UNITY_DECLARE_TEX2DARRAY(_MainTex);
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                o.texcoord.z = _DepthSlice;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0 = UNITY_SAMPLE_TEX2DARRAY(_MainTex, inp.texcoord.xyz);
                tmp1 = tmp0 < float4(0.0, 0.0, 0.0, 0.0);
                tmp2 = tmp0 > float4(0.0, 0.0, 0.0, 0.0);
                tmp1 = uint4(tmp1) | uint4(tmp2);
                tmp2 = tmp0 == float4(0.0, 0.0, 0.0, 0.0);
                tmp1 = uint4(tmp1) | uint4(tmp2);
                tmp1 = tmp1 == int4(0, 0, 0, 0);
                tmp1.x = uint1(tmp1.y) | uint1(tmp1.x);
                tmp1.x = uint1(tmp1.z) | uint1(tmp1.x);
                tmp1.x = uint1(tmp1.w) | uint1(tmp1.x);
                o.sv_target = tmp1.xxxx ? float4(0.0, 0.0, 0.0, 0.0) : tmp0;
                return o;
			}
			ENDCG
		}
	}
}