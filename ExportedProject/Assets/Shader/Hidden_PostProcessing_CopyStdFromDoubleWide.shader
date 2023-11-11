Shader "Hidden/PostProcessing/CopyStdFromDoubleWide" {
	Properties {
		_MainTex ("", 2D) = "white" {}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 12684
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _UVScaleOffset;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.texcoord.xy * float2(1.0, -1.0) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy * _UVScaleOffset.xy + _UVScaleOffset.zw;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                o.sv_target = tex2D(_MainTex, inp.texcoord.xy);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 125565
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _UVScaleOffset;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.texcoord.xy * float2(1.0, -1.0) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy * _UVScaleOffset.xy + _UVScaleOffset.zw;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
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