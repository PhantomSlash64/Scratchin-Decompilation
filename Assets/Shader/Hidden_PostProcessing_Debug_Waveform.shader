Shader "Hidden/PostProcessing/Debug/Waveform" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 54601
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float _RenderViewportScaleFactor;
			// $Globals ConstantBuffers for Fragment Shader
			float3 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * float2(0.5, -0.5) + float2(0.0, 1.0);
                o.texcoord1.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0.x = tmp0.x * _Params.y + tmp0.y;
                tmp0.xyz = ((float4[1])rsc0.xyzx.Load(tmp0.x))[0];
                tmp1.xyz = tmp0.yyy * float3(0.02, 1.1, 0.05);
                tmp0.xyw = tmp0.xxx * float3(1.4, 0.03, 0.02) + tmp1.xyz;
                tmp0.xyz = tmp0.zzz * float3(0.0, 0.25, 1.5) + tmp0.xyw;
                tmp0.xyz = tmp0.xyz * _Params + float3(-0.004, -0.004, -0.004);
                tmp0.xyz = max(tmp0.xyz, float3(0.0, 0.0, 0.0));
                tmp1.xyz = tmp0.xyz * float3(6.2, 6.2, 6.2) + float3(0.5, 0.5, 0.5);
                tmp1.xyz = tmp0.xyz * tmp1.xyz;
                tmp2.xyz = tmp0.xyz * float3(6.2, 6.2, 6.2) + float3(1.7, 1.7, 1.7);
                tmp0.xyz = tmp0.xyz * tmp2.xyz + float3(0.06, 0.06, 0.06);
                tmp0.xyz = tmp1.xyz / tmp0.xyz;
                tmp0.xyz = tmp0.xyz * tmp0.xyz;
                o.sv_target.xyz = min(tmp0.xyz, float3(1.0, 1.0, 1.0));
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}