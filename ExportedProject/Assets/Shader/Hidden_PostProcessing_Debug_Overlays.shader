Shader "Hidden/PostProcessing/Debug/Overlays" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 53588
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
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
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
                tmp0.x = 1.0 - unity_OrthoParams.w;
                tmp1 = tex2Dlod(_CameraDepthTexture, float4(inp.texcoord1.xy, 0, 0.0));
                tmp0.y = tmp1.x * _ZBufferParams.x;
                tmp0.x = tmp0.x * tmp0.y + _ZBufferParams.y;
                tmp0.y = -unity_OrthoParams.w * tmp0.y + 1.0;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x - tmp1.x;
                o.sv_target.xyz = _Params.xxx * tmp0.xxx + tmp1.xxx;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 91834
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
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _CameraDepthNormalsTexture;
			
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
                tmp0 = tex2D(_CameraDepthNormalsTexture, inp.texcoord1.xy);
                tmp0.xyz = tmp0.xyz * float3(3.5554, 3.5554, 0.0) + float3(-1.7777, -1.7777, 1.0);
                tmp0.z = dot(tmp0.xyz, tmp0.xyz);
                tmp0.z = 2.0 / tmp0.z;
                tmp1.xy = tmp0.xy * tmp0.zz;
                tmp1.z = tmp0.z - 1.0;
                tmp0.xyz = tmp1.xyz * float3(1.0, 1.0, -1.0);
                tmp1.xyz = tmp1.xyz * float3(12.92, 12.92, -12.92);
                tmp2.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                tmp2.xyz = log(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp2.xyz = exp(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                o.sv_target.xyz = tmp0.xyz ? tmp1.xyz : tmp2.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 163915
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
			float4 _MainTex_TexelSize;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
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
                tmp0.xy = saturate(inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp0 = tex2D(_CameraMotionVectorsTexture, tmp0.xy);
                tmp0.z = abs(tmp0.y);
                tmp0.w = max(tmp0.z, abs(tmp0.x));
                tmp0.w = 1.0 / tmp0.w;
                tmp1.x = min(tmp0.z, abs(tmp0.x));
                tmp0.z = tmp0.z < abs(tmp0.x);
                tmp0.w = tmp0.w * tmp1.x;
                tmp1.x = tmp0.w * tmp0.w;
                tmp1.y = tmp1.x * 0.0208351 + -0.085133;
                tmp1.y = tmp1.x * tmp1.y + 0.180141;
                tmp1.y = tmp1.x * tmp1.y + -0.3302995;
                tmp1.x = tmp1.x * tmp1.y + 0.999866;
                tmp1.y = tmp0.w * tmp1.x;
                tmp1.y = tmp1.y * -2.0 + 1.570796;
                tmp0.z = tmp0.z ? tmp1.y : 0.0;
                tmp0.z = tmp0.w * tmp1.x + tmp0.z;
                tmp0.w = -tmp0.y < tmp0.y;
                tmp0.w = tmp0.w ? -3.141593 : 0.0;
                tmp0.z = tmp0.w + tmp0.z;
                tmp0.w = min(-tmp0.y, tmp0.x);
                tmp0.w = tmp0.w < -tmp0.w;
                tmp1.x = max(-tmp0.y, tmp0.x);
                tmp0.xy = tmp0.xy * float2(1.0, -1.0);
                tmp2 = tmp0.xyxy * _Params;
                tmp0.x = tmp1.x >= -tmp1.x;
                tmp0.x = tmp0.x ? tmp0.w : 0.0;
                tmp0.x = tmp0.x ? -tmp0.z : tmp0.z;
                tmp0.x = tmp0.x * 0.3183099 + 1.0;
                tmp0.xyz = tmp0.xxx * float3(3.0, 3.0, 3.0) + float3(-3.0, -2.0, -4.0);
                tmp0.xyz = saturate(abs(tmp0.xyz) * float3(1.0, -1.0, -1.0) + float3(-1.0, 2.0, 2.0));
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.xyz = tmp0.xyz - tmp1.xyz;
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp2.xy = tmp2.zw * float2(0.25, 0.25);
                tmp1.w = dot(tmp2.xy, tmp2.xy);
                tmp1.w = sqrt(tmp1.w);
                tmp1.w = min(tmp1.w, 1.0);
                tmp0.w = sqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz + tmp1.xyz;
                tmp0.w = _MainTex_TexelSize.w * _Params.y;
                tmp0.w = tmp0.w / _MainTex_TexelSize.z;
                tmp1.y = floor(tmp0.w);
                tmp1.x = _Params.y;
                tmp1.xy = _MainTex_TexelSize.zw / tmp1.xy;
                tmp2.xy = inp.position.xy / tmp1.xy;
                tmp2.xy = floor(tmp2.xy);
                tmp2.xy = tmp2.xy + float2(0.5, 0.5);
                tmp2.zw = tmp1.xy * tmp2.xy;
                tmp2.xy = -tmp2.xy * tmp1.xy + inp.position.xy;
                tmp0.w = min(tmp1.y, tmp1.x);
                tmp0.w = tmp0.w * 0.7071068;
                tmp1.xy = saturate(tmp2.zw / _MainTex_TexelSize.zw);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp3 = tex2D(_CameraMotionVectorsTexture, tmp1.xy);
                tmp1.xy = tmp3.xy * float2(1.0, -1.0);
                tmp1.z = dot(tmp1.xy, tmp1.xy);
                tmp2.z = rsqrt(tmp1.z);
                tmp1.z = tmp1.z != 0.0;
                tmp3.xy = tmp1.xy * tmp2.zz;
                tmp3.z = -tmp3.y;
                tmp1.x = dot(tmp3.xy, tmp2.xy);
                tmp1.y = dot(tmp3.xy, tmp2.xy);
                tmp2.x = tmp1.w * tmp0.w;
                tmp0.w = tmp0.w * tmp1.w + -2.0;
                tmp2.yz = -tmp2.xx * float2(0.375, -0.0625) + tmp1.xy;
                tmp3.xyz = tmp2.xxx * float3(0.5, 0.25, -0.125);
                tmp4.x = tmp3.x;
                tmp4.y = 0.0;
                tmp3.xw = -tmp2.xx * float2(0.25, 0.125) + tmp4.xy;
                tmp3.xw = tmp4.xy - tmp3.xw;
                tmp1.w = dot(tmp3.xy, tmp3.xy);
                tmp1.w = sqrt(tmp1.w);
                tmp4.xy = tmp3.xw / tmp1.ww;
                tmp4.z = -tmp4.x;
                tmp1.w = dot(tmp2.xy, tmp4.xy);
                tmp2.yz = -tmp2.xx * float2(0.375, 0.0625) + tmp1.xy;
                tmp3.xw = tmp1.xy + float2(1.0, -0.0);
                tmp1.x = tmp2.x * -0.25 + tmp1.x;
                tmp1.y = dot(-tmp3.xy, -tmp3.xy);
                tmp1.y = sqrt(tmp1.y);
                tmp4.xy = -tmp3.yz / tmp1.yy;
                tmp4.z = -tmp4.x;
                tmp1.y = dot(tmp2.xy, tmp4.xy);
                tmp1.y = max(tmp1.w, tmp1.y);
                tmp1.x = max(-tmp1.x, tmp1.y);
                tmp1.y = tmp0.w / abs(tmp0.w);
                tmp1.w = tmp1.y * tmp3.x;
                tmp1.y = -tmp1.y * tmp3.w;
                tmp0.w = -abs(tmp0.w) * 0.5 + abs(tmp1.w);
                tmp0.w = max(tmp0.w, abs(tmp1.y));
                tmp0.w = min(tmp0.w, tmp1.x);
                tmp0.w = 1.0 - tmp0.w;
                tmp0.w = tmp0.w ? tmp1.z : 0.0;
                o.sv_target.xyz = tmp0.www + tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 229093
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
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp1 = tmp0 < float4(0.0, 0.0, 0.0, 0.0);
                tmp2 = tmp0 > float4(0.0, 0.0, 0.0, 0.0);
                tmp1 = uint4(tmp1) | uint4(tmp2);
                tmp2 = tmp0 == float4(0.0, 0.0, 0.0, 0.0);
                tmp1 = uint4(tmp1) | uint4(tmp2);
                tmp1 = tmp1 == int4(0, 0, 0, 0);
                tmp1.x = uint1(tmp1.y) | uint1(tmp1.x);
                tmp1.x = uint1(tmp1.z) | uint1(tmp1.x);
                tmp1.x = uint1(tmp1.w) | uint1(tmp1.x);
                tmp0.xyz = saturate(tmp0.xyz);
                tmp0.xyz = tmp0.xyz * float3(0.25, 0.25, 0.25);
                o.sv_target = tmp1.xxxx ? float4(1.0, 0.0, 1.0, 1.0) : tmp0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 300156
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
			float4 _Params;
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
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.xyz = saturate(tmp0.xyz);
                tmp1.xyz = tmp0.xyz + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp1.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(2.4, 2.4, 2.4);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp0.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp0.xyz = tmp0.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                tmp0.w = tmp0.y * -367.8571;
                tmp0.w = tmp0.x * -367.8571 + -tmp0.w;
                tmp0.w = tmp0.z * 16511.74 + tmp0.w;
                tmp1.z = saturate(tmp0.w * 0.0000608);
                tmp0.w = dot(tmp0.xy, float2(4833.038, 11677.2));
                tmp0.w = tmp0.w * 0.0000608;
                tmp1.xy = min(tmp0.ww, float2(1.0, 1.0));
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                tmp0.xyz = _Params.xxx * tmp1.xyz + tmp0.xyz;
                tmp1.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp1.xyz = exp(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp2.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 364523
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
			float4 _Params;
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
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.xyz = saturate(tmp0.xyz);
                tmp1.xyz = tmp0.xyz + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp1.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(2.4, 2.4, 2.4);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp0.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp0.xyz = tmp0.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                tmp0.w = tmp0.y * 66.01265;
                tmp0.w = tmp0.x * 66.01265 + -tmp0.w;
                tmp0.w = tmp0.z * 16511.74 + tmp0.w;
                tmp1.z = saturate(tmp0.w * 0.0000608);
                tmp0.w = dot(tmp0.xy, float2(1855.915, 14655.83));
                tmp0.w = tmp0.w * 0.0000608;
                tmp1.xy = min(tmp0.ww, float2(1.0, 1.0));
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                tmp0.xyz = _Params.xxx * tmp1.xyz + tmp0.xyz;
                tmp1.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp1.xyz = exp(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp2.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 452096
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
			float4 _Params;
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
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.xyz = saturate(tmp0.xyz);
                tmp1.xyz = tmp0.xyz + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp1.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(2.4, 2.4, 2.4);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp0.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp0.xyz = tmp0.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                tmp0.w = dot(tmp0.xyz, float3(2.43251, 11.46885, 1.760492));
                tmp1 = tmp0.wwww * float4(0.0077822, 0.0000598, -0.000329, 0.2321643);
                tmp2.xy = tmp0.ww * float2(0.1378665, 0.0093314);
                tmp0.w = dot(tmp0.xyz, float3(6.501978, 11.03203, 1.223841));
                tmp2.z = tmp0.w * 0.0077822;
                tmp1.x = tmp1.x / tmp2.z;
                tmp1.x = tmp1.x < 0.834949;
                tmp1.yz = tmp0.ww * float2(-0.0000046, 0.0001984) + tmp1.yz;
                tmp1.w = tmp0.w * 0.2399325 + -tmp1.w;
                tmp1.yz = tmp1.yz * float2(98.84319, -58.80514);
                tmp1.x = tmp1.x ? tmp1.y : tmp1.z;
                tmp3.x = saturate(tmp1.x * 1.610474 + tmp1.w);
                tmp1.y = tmp0.w * -0.0504402 + tmp2.x;
                tmp0.w = tmp0.w * -0.0029237 + -tmp2.y;
                tmp3.z = saturate(tmp1.x * 14.27385 + tmp0.w);
                tmp3.y = saturate(-tmp1.x * 2.532642 + tmp1.y);
                tmp1.xyz = tmp3.xyz - tmp0.xyz;
                tmp0.xyz = _Params.xxx * tmp1.xyz + tmp0.xyz;
                tmp1.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp1.xyz = exp(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp2.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}