Shader "Hidden/PostProcessing/FinalPass" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 26315
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
			float4 _Dithering_Coords;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _DitheringTex;
			sampler2D _MainTex;
			
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
                tmp0.xy = inp.texcoord.xy * _Dithering_Coords.xy + _Dithering_Coords.zw;
                tmp0.x = tex2D(_DitheringTex, tmp0.xy);
                tmp0.x = tmp0.x * 2.0 + -1.0;
                tmp0.y = 1.0 - abs(tmp0.x);
                tmp0.x = saturate(tmp0.x * 340282300000000000000000000000000000000.0 + 0.5);
                tmp0.x = tmp0.x * 2.0 + -1.0;
                tmp0.y = sqrt(tmp0.y);
                tmp0.y = 1.0 - tmp0.y;
                tmp0.x = tmp0.y * tmp0.x;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                o.sv_target.xyz = tmp0.xxx * float3(0.0039216, 0.0039216, 0.0039216) + tmp1.xyz;
                o.sv_target.w = tmp1.w;
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
			GpuProgramID 111372
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
			float4 _Dithering_Coords;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _DitheringTex;
			sampler2D _MainTex;
			
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
                tmp0.xy = inp.texcoord.xy * _Dithering_Coords.xy + _Dithering_Coords.zw;
                tmp0 = tex2D(_DitheringTex, tmp0.xy);
                tmp0.x = tmp0.w * 2.0 + -1.0;
                tmp0.y = 1.0 - abs(tmp0.x);
                tmp0.x = saturate(tmp0.x * 340282300000000000000000000000000000000.0 + 0.5);
                tmp0.x = tmp0.x * 2.0 + -1.0;
                tmp0.y = sqrt(tmp0.y);
                tmp0.y = 1.0 - tmp0.y;
                tmp0.x = tmp0.y * tmp0.x;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                o.sv_target.xyz = tmp0.xxx * float3(0.0039216, 0.0039216, 0.0039216) + tmp1.xyz;
                o.sv_target.w = tmp1.w;
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
			GpuProgramID 195519
			// No subprograms found
		}
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 209563
			// No subprograms found
		}
	}
}