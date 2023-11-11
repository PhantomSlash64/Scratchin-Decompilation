Shader "Hidden/PostProcessing/TemporalAntialiasing" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 63221
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
				float4 sv_target1 : SV_Target1;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float _RenderViewportScaleFactor;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _MainTex_TexelSize;
			float4 _CameraDepthTexture_TexelSize;
			float2 _Jitter;
			float4 _FinalBlendParameters;
			float _Sharpness;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _HistoryTex;
			sampler2D _CameraDepthTexture;
			sampler2D _CameraMotionVectorsTexture;
			
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
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                float4 tmp6;
                tmp0.xy = inp.texcoord1.xy - _CameraDepthTexture_TexelSize.xy;
                tmp0.xy = max(tmp0.xy, float2(0.0, 0.0));
                tmp0.xy = min(tmp0.xy, _RenderViewportScaleFactor.xx);
                tmp0 = tex2D(_CameraDepthTexture, tmp0.xy);
                tmp1 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.w = tmp0.z >= tmp1.z;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.xy = float2(-1.0, -1.0);
                tmp1.xy = float2(0.0, 0.0);
                tmp0.xyz = tmp0.xyz - tmp1.yyz;
                tmp0.xyz = tmp0.www * tmp0.xyz + tmp1.xyz;
                tmp1.xy = float2(1.0, -1.0);
                tmp2 = _CameraDepthTexture_TexelSize * float4(1.0, -1.0, -1.0, 1.0) + inp.texcoord1.xyxy;
                tmp2 = max(tmp2, float4(0.0, 0.0, 0.0, 0.0));
                tmp2 = min(tmp2, _RenderViewportScaleFactor.xxxx);
                tmp3 = tex2D(_CameraDepthTexture, tmp2.xy);
                tmp2 = tex2D(_CameraDepthTexture, tmp2.zw);
                tmp1.z = tmp3.x;
                tmp0.w = tmp3.x >= tmp0.z;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp1.xyz = tmp1.xyz - tmp0.yyz;
                tmp0.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                tmp2.xy = float2(-1.0, 1.0);
                tmp0.w = tmp2.z >= tmp0.z;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp1.xyz = tmp2.xyz - tmp0.xyz;
                tmp0.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                tmp1.xy = inp.texcoord1.xy + _CameraDepthTexture_TexelSize.xy;
                tmp1.xy = max(tmp1.xy, float2(0.0, 0.0));
                tmp1.xy = min(tmp1.xy, _RenderViewportScaleFactor.xx);
                tmp1 = tex2D(_CameraDepthTexture, tmp1.xy);
                tmp0.z = tmp1.x >= tmp0.z;
                tmp0.z = tmp0.z ? 1.0 : 0.0;
                tmp1.xy = float2(1.0, 1.0) - tmp0.xy;
                tmp0.xy = tmp0.zz * tmp1.xy + tmp0.xy;
                tmp0.xy = tmp0.xy * _CameraDepthTexture_TexelSize.xy + inp.texcoord1.xy;
                tmp0 = tex2D(_CameraMotionVectorsTexture, tmp0.xy);
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.xy = inp.texcoord1.xy - tmp0.xy;
                tmp0.xy = max(tmp0.xy, float2(0.0, 0.0));
                tmp0.xy = min(tmp0.xy, _RenderViewportScaleFactor.xx);
                tmp1 = tex2D(_HistoryTex, tmp0.xy);
                tmp0.x = sqrt(tmp0.z);
                tmp0.y = tmp0.x * 100.0;
                tmp0.x = tmp0.x * _FinalBlendParameters.z;
                tmp0.y = min(tmp0.y, 1.0);
                tmp0.y = tmp0.y * -3.75 + 4.0;
                tmp0.zw = inp.texcoord1.xy - _Jitter;
                tmp0.zw = max(tmp0.zw, float2(0.0, 0.0));
                tmp0.zw = min(tmp0.zw, _RenderViewportScaleFactor.xx);
                tmp2.xy = -_MainTex_TexelSize.xy * float2(0.5, 0.5) + tmp0.zw;
                tmp2.xy = max(tmp2.xy, float2(0.0, 0.0));
                tmp2.xy = min(tmp2.xy, _RenderViewportScaleFactor.xx);
                tmp2 = tex2D(0, tmp2.xy);
                tmp3.xy = _MainTex_TexelSize.xy * float2(0.5, 0.5) + tmp0.zw;
                tmp4 = tex2D(0, tmp0.zw);
                tmp0.zw = max(tmp3.xy, float2(0.0, 0.0));
                tmp0.zw = min(tmp0.zw, _RenderViewportScaleFactor.xx);
                tmp3 = tex2D(0, tmp0.zw);
                tmp5 = tmp2 + tmp3;
                tmp6 = tmp4 + tmp4;
                tmp5 = tmp5 * float4(4.0, 4.0, 4.0, 4.0) + -tmp6;
                tmp6 = -tmp5 * float4(0.166667, 0.166667, 0.166667, 0.166667) + tmp4;
                tmp6 = tmp6 * _Sharpness.xxxx;
                tmp4 = tmp6 * float4(2.718282, 2.718282, 2.718282, 2.718282) + tmp4;
                tmp4 = max(tmp4, float4(0.0, 0.0, 0.0, 0.0));
                tmp4 = min(tmp4, float4(65472.0, 65472.0, 65472.0, 65472.0));
                tmp5.xyz = tmp4.xyz + tmp5.xyz;
                tmp5.xyz = tmp5.xyz * float3(0.142857, 0.142857, 0.142857);
                tmp0.z = dot(tmp5.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.w = dot(tmp4.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.z = tmp0.z - tmp0.w;
                tmp5.xyz = min(tmp2.xyz, tmp3.xyz);
                tmp2.xyz = max(tmp2.xyz, tmp3.xyz);
                tmp2.xyz = tmp0.yyy * abs(tmp0.zzz) + tmp2.xyz;
                tmp0.yzw = -tmp0.yyy * abs(tmp0.zzz) + tmp5.xyz;
                tmp3.xyz = tmp2.xyz - tmp0.yzw;
                tmp0.yzw = tmp0.yzw + tmp2.xyz;
                tmp2.xyz = tmp3.xyz * float3(0.5, 0.5, 0.5);
                tmp3.xyz = -tmp0.yzw * float3(0.5, 0.5, 0.5) + tmp1.xyz;
                tmp0.yzw = tmp0.yzw * float3(0.5, 0.5, 0.5);
                tmp5.xyz = tmp3.xyz + float3(0.0001, 0.0001, 0.0001);
                tmp2.xyz = tmp2.xyz / tmp5.xyz;
                tmp2.x = min(abs(tmp2.y), abs(tmp2.x));
                tmp2.x = min(abs(tmp2.z), tmp2.x);
                tmp2.x = min(tmp2.x, 1.0);
                tmp1.xyz = tmp3.xyz * tmp2.xxx + tmp0.yzw;
                tmp1 = tmp1 - tmp4;
                tmp0.y = _FinalBlendParameters.y - _FinalBlendParameters.x;
                tmp0.x = tmp0.x * tmp0.y + _FinalBlendParameters.x;
                tmp0.x = max(tmp0.x, _FinalBlendParameters.y);
                tmp0.x = min(tmp0.x, _FinalBlendParameters.x);
                tmp0 = tmp0.xxxx * tmp1 + tmp4;
                tmp0 = max(tmp0, float4(0.0, 0.0, 0.0, 0.0));
                tmp0 = min(tmp0, float4(65472.0, 65472.0, 65472.0, 65472.0));
                o.sv_target = tmp0;
                o.sv_target1 = tmp0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 92432
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
				float4 sv_target1 : SV_Target1;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float _RenderViewportScaleFactor;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _MainTex_TexelSize;
			float2 _Jitter;
			float4 _FinalBlendParameters;
			float _Sharpness;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _HistoryTex;
			sampler2D _CameraMotionVectorsTexture;
			
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
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0.xy = inp.texcoord1.xy - _Jitter;
                tmp0.xy = max(tmp0.xy, float2(0.0, 0.0));
                tmp0.xy = min(tmp0.xy, _RenderViewportScaleFactor.xx);
                tmp0.zw = -_MainTex_TexelSize.xy * float2(0.5, 0.5) + tmp0.xy;
                tmp0.zw = max(tmp0.zw, float2(0.0, 0.0));
                tmp0.zw = min(tmp0.zw, _RenderViewportScaleFactor.xx);
                tmp1 = tex2D(0, tmp0.zw);
                tmp0.zw = _MainTex_TexelSize.xy * float2(0.5, 0.5) + tmp0.xy;
                tmp2 = tex2D(0, tmp0.xy);
                tmp0.xy = max(tmp0.zw, float2(0.0, 0.0));
                tmp0.xy = min(tmp0.xy, _RenderViewportScaleFactor.xx);
                tmp0 = tex2D(0, tmp0.xy);
                tmp3 = tmp0 + tmp1;
                tmp4 = tmp2 + tmp2;
                tmp3 = tmp3 * float4(4.0, 4.0, 4.0, 4.0) + -tmp4;
                tmp4 = -tmp3 * float4(0.166667, 0.166667, 0.166667, 0.166667) + tmp2;
                tmp4 = tmp4 * _Sharpness.xxxx;
                tmp2 = tmp4 * float4(2.718282, 2.718282, 2.718282, 2.718282) + tmp2;
                tmp2 = max(tmp2, float4(0.0, 0.0, 0.0, 0.0));
                tmp2 = min(tmp2, float4(65472.0, 65472.0, 65472.0, 65472.0));
                tmp3.xyz = tmp2.xyz + tmp3.xyz;
                tmp3.xyz = tmp3.xyz * float3(0.142857, 0.142857, 0.142857);
                tmp0.w = dot(tmp3.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp1.w = dot(tmp2.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.w = tmp0.w - tmp1.w;
                tmp3.xyz = min(tmp1.xyz, tmp0.xyz);
                tmp0.xyz = max(tmp0.xyz, tmp1.xyz);
                tmp1 = tex2D(_CameraMotionVectorsTexture, inp.texcoord1.xy);
                tmp1.z = dot(tmp1.xy, tmp1.xy);
                tmp1.xy = inp.texcoord1.xy - tmp1.xy;
                tmp1.xy = max(tmp1.xy, float2(0.0, 0.0));
                tmp1.xy = min(tmp1.xy, _RenderViewportScaleFactor.xx);
                tmp4 = tex2D(_HistoryTex, tmp1.xy);
                tmp1.x = sqrt(tmp1.z);
                tmp1.y = tmp1.x * 100.0;
                tmp1.x = tmp1.x * _FinalBlendParameters.z;
                tmp1.y = min(tmp1.y, 1.0);
                tmp1.y = tmp1.y * -3.75 + 4.0;
                tmp3.xyz = -tmp1.yyy * abs(tmp0.www) + tmp3.xyz;
                tmp0.xyz = tmp1.yyy * abs(tmp0.www) + tmp0.xyz;
                tmp1.yzw = tmp0.xyz - tmp3.xyz;
                tmp0.xyz = tmp3.xyz + tmp0.xyz;
                tmp1.yzw = tmp1.yzw * float3(0.5, 0.5, 0.5);
                tmp3.xyz = -tmp0.xyz * float3(0.5, 0.5, 0.5) + tmp4.xyz;
                tmp0.xyz = tmp0.xyz * float3(0.5, 0.5, 0.5);
                tmp5.xyz = tmp3.xyz + float3(0.0001, 0.0001, 0.0001);
                tmp1.yzw = tmp1.yzw / tmp5.xyz;
                tmp0.w = min(abs(tmp1.z), abs(tmp1.y));
                tmp0.w = min(abs(tmp1.w), tmp0.w);
                tmp0.w = min(tmp0.w, 1.0);
                tmp4.xyz = tmp3.xyz * tmp0.www + tmp0.xyz;
                tmp0 = tmp4 - tmp2;
                tmp1.y = _FinalBlendParameters.y - _FinalBlendParameters.x;
                tmp1.x = tmp1.x * tmp1.y + _FinalBlendParameters.x;
                tmp1.x = max(tmp1.x, _FinalBlendParameters.y);
                tmp1.x = min(tmp1.x, _FinalBlendParameters.x);
                tmp0 = tmp1.xxxx * tmp0 + tmp2;
                tmp0 = max(tmp0, float4(0.0, 0.0, 0.0, 0.0));
                tmp0 = min(tmp0, float4(65472.0, 65472.0, 65472.0, 65472.0));
                o.sv_target = tmp0;
                o.sv_target1 = tmp0;
                return o;
			}
			ENDCG
		}
	}
}