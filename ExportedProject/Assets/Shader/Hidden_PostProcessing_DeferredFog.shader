Shader "Hidden/PostProcessing/DeferredFog" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 46045
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
			float4 unity_OrthoParams;
			float4 _FogColor;
			float3 _FogParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraDepthTexture;
			
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
                tmp0.x = 1.0 - unity_OrthoParams.w;
                tmp1 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.y = tmp1.x * _ZBufferParams.x;
                tmp0.x = tmp0.x * tmp0.y + _ZBufferParams.y;
                tmp0.y = -unity_OrthoParams.w * tmp0.y + 1.0;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x * _ProjectionParams.z + -_ProjectionParams.y;
                tmp0.x = tmp0.x * _FogParams.x;
                tmp0.x = tmp0.x * -tmp0.x;
                tmp0.x = exp(tmp0.x);
                tmp0.x = 1.0 - tmp0.x;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2 = _FogColor - tmp1;
                o.sv_target = tmp0.xxxx * tmp2 + tmp1;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 125586
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
			float4 unity_OrthoParams;
			float4 _FogColor;
			float3 _FogParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraDepthTexture;
			
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
                tmp0.x = 1.0 - unity_OrthoParams.w;
                tmp1 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.y = tmp1.x * _ZBufferParams.x;
                tmp0.x = tmp0.x * tmp0.y + _ZBufferParams.y;
                tmp0.y = -unity_OrthoParams.w * tmp0.y + 1.0;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.y = tmp0.x * _ProjectionParams.z + -_ProjectionParams.y;
                tmp0.x = tmp0.x < 0.9999;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.y = tmp0.y * _FogParams.x;
                tmp0.y = tmp0.y * -tmp0.y;
                tmp0.y = exp(tmp0.y);
                tmp0.y = 1.0 - tmp0.y;
                tmp0.x = tmp0.x * tmp0.y;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2 = _FogColor - tmp1;
                o.sv_target = tmp0.xxxx * tmp2 + tmp1;
                return o;
			}
			ENDCG
		}
	}
}