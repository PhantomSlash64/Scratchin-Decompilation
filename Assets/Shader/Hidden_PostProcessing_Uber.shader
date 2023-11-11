Shader "Hidden/PostProcessing/Uber" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 34743
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
			float4 _UVTransform;
			// $Globals ConstantBuffers for Fragment Shader
			float _LumaInAlpha;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AutoExposureTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * _UVTransform.xy;
                tmp0.xy = tmp0.xy * float2(0.5, 0.5) + _UVTransform.zw;
                o.texcoord1.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                o.texcoord.xy = tmp0.xy;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0 = tex2D(_AutoExposureTex, inp.texcoord.xy);
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.yzw = tmp1.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp2.xyz = tmp1.xyz + float3(0.055, 0.055, 0.055);
                tmp2.xyz = tmp2.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp2.xyz = max(abs(tmp2.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp2.xyz = log(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(2.4, 2.4, 2.4);
                tmp2.xyz = exp(tmp2.xyz);
                tmp1.xyz = tmp1.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.yzw = tmp1.xyz ? tmp0.yzw : tmp2.xyz;
                tmp0.xyz = tmp0.xxx * tmp0.yzw;
                tmp0.w = _LumaInAlpha > 0.5;
                if (tmp0.w) {
                    tmp1.xyz = saturate(tmp0.xyz);
                    o.sv_target.w = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                } else {
                    o.sv_target.w = tmp1.w;
                }
                tmp1.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp2.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp2.xyz = log(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp2.xyz = exp(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.xyz = tmp0.xyz ? tmp1.xyz : tmp2.xyz;
                return o;
			}
			ENDCG
		}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 125477
			// No subprograms found
		}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 180118
			// No subprograms found
		}
	}
}