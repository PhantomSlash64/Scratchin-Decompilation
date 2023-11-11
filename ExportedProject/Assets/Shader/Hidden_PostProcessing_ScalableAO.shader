Shader "Hidden/PostProcessing/ScalableAO" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 8321
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
			float4x4 unity_CameraProjection;
			float4 unity_OrthoParams;
			float4 _AOParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _CameraDepthTexture;
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
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                float4 tmp6;
                float4 tmp7;
                float4 tmp8;
                tmp0.xy = saturate(inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_CameraDepthNormalsTexture, tmp0.xy);
                tmp1.xyz = tmp1.xyz * float3(3.5554, 3.5554, 0.0) + float3(-1.7777, -1.7777, 1.0);
                tmp0.z = dot(tmp1.xyz, tmp1.xyz);
                tmp0.z = 2.0 / tmp0.z;
                tmp1.yz = tmp1.xy * tmp0.zz;
                tmp1.w = tmp0.z - 1.0;
                tmp2.xyz = tmp1.yzw * float3(1.0, 1.0, -1.0);
                tmp0 = tex2Dlod(_CameraDepthTexture, float4(tmp0.xy, 0, 0.0));
                tmp0.y = 1.0 - unity_OrthoParams.w;
                tmp0.x = tmp0.x * _ZBufferParams.x;
                tmp0.z = -unity_OrthoParams.w * tmp0.x + 1.0;
                tmp0.x = tmp0.y * tmp0.x + _ZBufferParams.y;
                tmp0.x = tmp0.z / tmp0.x;
                tmp0.zw = inp.texcoord.xy < float2(0.0, 0.0);
                tmp0.z = uint1(tmp0.w) | uint1(tmp0.z);
                tmp3.xy = inp.texcoord.xy > float2(1.0, 1.0);
                tmp0.w = uint1(tmp3.y) | uint1(tmp3.x);
                tmp0.zw = tmp0.zw ? float2(0.0, 0.0) : 0.0;
                tmp0.z = tmp0.w + tmp0.z;
                tmp0.z = floor(tmp0.z);
                tmp0.w = tmp0.x <= 0.00001;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.z = tmp0.w + tmp0.z;
                tmp0.z = tmp0.z * 100000000.0;
                tmp3.z = tmp0.x * _ProjectionParams.z + tmp0.z;
                tmp0.xz = inp.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp0.xz = tmp0.xz - unity_CameraProjection._m02_m12;
                tmp4.x = unity_CameraProjection._m00;
                tmp4.y = unity_CameraProjection._m11;
                tmp0.xz = tmp0.xz / tmp4.xy;
                tmp0.w = 1.0 - tmp3.z;
                tmp0.w = unity_OrthoParams.w * tmp0.w + tmp3.z;
                tmp3.xy = tmp0.ww * tmp0.xz;
                tmp0.x = asint(_AOParams.w);
                tmp0.zw = inp.texcoord.xy * _AOParams.zz;
                tmp0.zw = tmp0.zw * _ScreenParams.xy;
                tmp0.zw = floor(tmp0.zw);
                tmp0.z = dot(float2(0.0671106, 0.0058372), tmp0.xy);
                tmp0.z = frac(tmp0.z);
                tmp0.z = tmp0.z * 52.98292;
                tmp0.z = frac(tmp0.z);
                tmp5.x = 12.9898;
                tmp0.w = 0.0;
                tmp1.x = 0.0;
                for (int i = tmp1.x; i < tmp0.x; i += 1) {
                    tmp2.w = floor(i);
                    tmp2.w = tmp2.w * 1.0001;
                    tmp2.w = floor(tmp2.w);
                    tmp5.y = inp.texcoord.x * 0.0 + tmp2.w;
                    tmp3.w = tmp5.y * 78.233;
                    tmp3.w = sin(tmp3.w);
                    tmp3.w = tmp3.w * 43758.55;
                    tmp3.w = frac(tmp3.w);
                    tmp3.w = tmp0.z + tmp3.w;
                    tmp3.w = frac(tmp3.w);
                    tmp6.z = tmp3.w * 2.0 + -1.0;
                    tmp3.w = dot(tmp5.xy, float2(1.0, 78.233));
                    tmp3.w = sin(tmp3.w);
                    tmp3.w = tmp3.w * 43758.55;
                    tmp3.w = frac(tmp3.w);
                    tmp3.w = tmp0.z + tmp3.w;
                    tmp3.w = tmp3.w * 6.283185;
                    tmp7.x = sin(tmp3.w);
                    tmp8.x = cos(tmp3.w);
                    tmp3.w = -tmp6.z * tmp6.z + 1.0;
                    tmp3.w = sqrt(tmp3.w);
                    tmp8.y = tmp7.x;
                    tmp6.xy = tmp3.ww * tmp8.xy;
                    tmp2.w = tmp2.w + 1.0;
                    tmp2.w = tmp2.w / _AOParams.w;
                    tmp2.w = sqrt(tmp2.w);
                    tmp2.w = tmp2.w * _AOParams.y;
                    tmp5.yzw = tmp2.www * tmp6.xyz;
                    tmp2.w = dot(-tmp2.xyz, tmp5.xyz);
                    tmp2.w = tmp2.w >= 0.0;
                    tmp5.yzw = tmp2.www ? -tmp5.yzw : tmp5.yzw;
                    tmp5.yzw = tmp3.xyz + tmp5.yzw;
                    tmp4.zw = tmp5.zz * unity_CameraProjection._m01_m11;
                    tmp4.zw = unity_CameraProjection._m00_m10 * tmp5.yy + tmp4.zw;
                    tmp4.zw = unity_CameraProjection._m02_m12 * tmp5.ww + tmp4.zw;
                    tmp2.w = 1.0 - tmp5.w;
                    tmp2.w = unity_OrthoParams.w * tmp2.w + tmp5.w;
                    tmp4.zw = tmp4.zw / tmp2.ww;
                    tmp4.zw = tmp4.zw + float2(1.0, 1.0);
                    tmp5.yz = saturate(tmp4.zw * float2(0.5, 0.5));
                    tmp5.yz = tmp5.yz * _RenderViewportScaleFactor.xx;
                    tmp6 = tex2Dlod(_CameraDepthTexture, float4(tmp5.yz, 0, 0.0));
                    tmp2.w = tmp6.x * _ZBufferParams.x;
                    tmp3.w = -unity_OrthoParams.w * tmp2.w + 1.0;
                    tmp2.w = tmp0.y * tmp2.w + _ZBufferParams.y;
                    tmp2.w = tmp3.w / tmp2.w;
                    tmp5.yz = tmp4.zw < float2(0.0, 0.0);
                    tmp3.w = uint1(tmp5.z) | uint1(tmp5.y);
                    tmp3.w = uint1(tmp3.w) & uint1(0.0);
                    tmp5.yz = tmp4.zw > float2(2.0, 2.0);
                    tmp5.y = uint1(tmp5.z) | uint1(tmp5.y);
                    tmp5.y = tmp5.y ? 0.0 : 0.0;
                    tmp3.w = tmp3.w + tmp5.y;
                    tmp3.w = floor(tmp3.w);
                    tmp5.y = tmp2.w <= 0.00001;
                    tmp5.y = tmp5.y ? 1.0 : 0.0;
                    tmp3.w = tmp3.w + tmp5.y;
                    tmp3.w = tmp3.w * 100000000.0;
                    tmp6.z = tmp2.w * _ProjectionParams.z + tmp3.w;
                    tmp4.zw = tmp4.zw - unity_CameraProjection._m02_m12;
                    tmp4.zw = tmp4.zw - float2(1.0, 1.0);
                    tmp4.zw = tmp4.zw / tmp4.xy;
                    tmp2.w = 1.0 - tmp6.z;
                    tmp2.w = unity_OrthoParams.w * tmp2.w + tmp6.z;
                    tmp6.xy = tmp2.ww * tmp4.zw;
                    tmp5.yzw = tmp6.xyz - tmp3.xyz;
                    tmp2.w = dot(tmp5.xyz, tmp2.xyz);
                    tmp2.w = -tmp3.z * 0.002 + tmp2.w;
                    tmp2.w = max(tmp2.w, 0.0);
                    tmp3.w = dot(tmp5.xyz, tmp5.xyz);
                    tmp3.w = tmp3.w + 0.0001;
                    tmp2.w = tmp2.w / tmp3.w;
                    tmp0.w = tmp0.w + tmp2.w;
                }
                tmp0.x = tmp0.w * _AOParams.y;
                tmp0.x = tmp0.x * _AOParams.x;
                tmp0.x = tmp0.x / _AOParams.w;
                tmp0.x = max(abs(tmp0.x), 0.0000001);
                tmp0.x = log(tmp0.x);
                tmp0.x = tmp0.x * 0.6;
                o.sv_target.x = exp(tmp0.x);
                o.sv_target.yzw = tmp1.yzw * float3(0.5, 0.5, -0.5) + float3(0.5, 0.5, 0.5);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 130050
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
			float4x4 unity_CameraProjection;
			float4x4 unity_WorldToCamera;
			float4 unity_OrthoParams;
			float4 _AOParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _CameraGBufferTexture2;
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
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                float4 tmp6;
                float4 tmp7;
                tmp0.xy = saturate(inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_CameraGBufferTexture2, tmp0.xy);
                tmp0.z = dot(tmp1.xyz, tmp1.xyz);
                tmp0.z = tmp0.z != 0.0;
                tmp0.z = tmp0.z ? -1.0 : -0.0;
                tmp1.xyz = tmp1.xyz * float3(2.0, 2.0, 2.0) + tmp0.zzz;
                tmp2.xyz = tmp1.yyy * unity_WorldToCamera._m01_m11_m21;
                tmp1.xyw = unity_WorldToCamera._m00_m10_m20 * tmp1.xxx + tmp2.xyz;
                tmp1.xyz = unity_WorldToCamera._m02_m12_m22 * tmp1.zzz + tmp1.xyw;
                tmp0 = tex2Dlod(_CameraDepthTexture, float4(tmp0.xy, 0, 0.0));
                tmp0.y = 1.0 - unity_OrthoParams.w;
                tmp0.x = tmp0.x * _ZBufferParams.x;
                tmp0.z = -unity_OrthoParams.w * tmp0.x + 1.0;
                tmp0.x = tmp0.y * tmp0.x + _ZBufferParams.y;
                tmp0.x = tmp0.z / tmp0.x;
                tmp0.zw = inp.texcoord.xy < float2(0.0, 0.0);
                tmp0.z = uint1(tmp0.w) | uint1(tmp0.z);
                tmp2.xy = inp.texcoord.xy > float2(1.0, 1.0);
                tmp0.w = uint1(tmp2.y) | uint1(tmp2.x);
                tmp0.zw = tmp0.zw ? float2(0.0, 0.0) : 0.0;
                tmp0.z = tmp0.w + tmp0.z;
                tmp0.z = floor(tmp0.z);
                tmp0.w = tmp0.x <= 0.00001;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.z = tmp0.w + tmp0.z;
                tmp0.z = tmp0.z * 100000000.0;
                tmp2.z = tmp0.x * _ProjectionParams.z + tmp0.z;
                tmp0.xz = inp.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp0.xz = tmp0.xz - unity_CameraProjection._m02_m12;
                tmp3.x = unity_CameraProjection._m00;
                tmp3.y = unity_CameraProjection._m11;
                tmp0.xz = tmp0.xz / tmp3.xy;
                tmp0.w = 1.0 - tmp2.z;
                tmp0.w = unity_OrthoParams.w * tmp0.w + tmp2.z;
                tmp2.xy = tmp0.ww * tmp0.xz;
                tmp0.x = asint(_AOParams.w);
                tmp0.zw = inp.texcoord.xy * _AOParams.zz;
                tmp0.zw = tmp0.zw * _ScreenParams.xy;
                tmp0.zw = floor(tmp0.zw);
                tmp0.z = dot(float2(0.0671106, 0.0058372), tmp0.xy);
                tmp0.z = frac(tmp0.z);
                tmp0.z = tmp0.z * 52.98292;
                tmp0.z = frac(tmp0.z);
                tmp4.x = 12.9898;
                tmp0.w = 0.0;
                tmp1.w = 0.0;
                for (int i = tmp1.w; i < tmp0.x; i += 1) {
                    tmp2.w = floor(i);
                    tmp2.w = tmp2.w * 1.0001;
                    tmp2.w = floor(tmp2.w);
                    tmp4.y = inp.texcoord.x * 0.0 + tmp2.w;
                    tmp3.z = tmp4.y * 78.233;
                    tmp3.z = sin(tmp3.z);
                    tmp3.z = tmp3.z * 43758.55;
                    tmp3.z = frac(tmp3.z);
                    tmp3.z = tmp0.z + tmp3.z;
                    tmp3.z = frac(tmp3.z);
                    tmp5.z = tmp3.z * 2.0 + -1.0;
                    tmp3.z = dot(tmp4.xy, float2(1.0, 78.233));
                    tmp3.z = sin(tmp3.z);
                    tmp3.z = tmp3.z * 43758.55;
                    tmp3.z = frac(tmp3.z);
                    tmp3.z = tmp0.z + tmp3.z;
                    tmp3.z = tmp3.z * 6.283185;
                    tmp6.x = sin(tmp3.z);
                    tmp7.x = cos(tmp3.z);
                    tmp3.z = -tmp5.z * tmp5.z + 1.0;
                    tmp3.z = sqrt(tmp3.z);
                    tmp7.y = tmp6.x;
                    tmp5.xy = tmp3.zz * tmp7.xy;
                    tmp2.w = tmp2.w + 1.0;
                    tmp2.w = tmp2.w / _AOParams.w;
                    tmp2.w = sqrt(tmp2.w);
                    tmp2.w = tmp2.w * _AOParams.y;
                    tmp4.yzw = tmp2.www * tmp5.xyz;
                    tmp2.w = dot(-tmp1.xyz, tmp4.xyz);
                    tmp2.w = tmp2.w >= 0.0;
                    tmp4.yzw = tmp2.www ? -tmp4.yzw : tmp4.yzw;
                    tmp4.yzw = tmp2.xyz + tmp4.yzw;
                    tmp3.zw = tmp4.zz * unity_CameraProjection._m01_m11;
                    tmp3.zw = unity_CameraProjection._m00_m10 * tmp4.yy + tmp3.zw;
                    tmp3.zw = unity_CameraProjection._m02_m12 * tmp4.ww + tmp3.zw;
                    tmp2.w = 1.0 - tmp4.w;
                    tmp2.w = unity_OrthoParams.w * tmp2.w + tmp4.w;
                    tmp3.zw = tmp3.zw / tmp2.ww;
                    tmp3.zw = tmp3.zw + float2(1.0, 1.0);
                    tmp4.yz = saturate(tmp3.zw * float2(0.5, 0.5));
                    tmp4.yz = tmp4.yz * _RenderViewportScaleFactor.xx;
                    tmp5 = tex2Dlod(_CameraDepthTexture, float4(tmp4.yz, 0, 0.0));
                    tmp2.w = tmp5.x * _ZBufferParams.x;
                    tmp4.y = -unity_OrthoParams.w * tmp2.w + 1.0;
                    tmp2.w = tmp0.y * tmp2.w + _ZBufferParams.y;
                    tmp2.w = tmp4.y / tmp2.w;
                    tmp4.yz = tmp3.zw < float2(0.0, 0.0);
                    tmp4.y = uint1(tmp4.z) | uint1(tmp4.y);
                    tmp4.zw = tmp3.zw > float2(2.0, 2.0);
                    tmp4.z = uint1(tmp4.w) | uint1(tmp4.z);
                    tmp4.yz = tmp4.yz ? float2(0.0, 0.0) : 0.0;
                    tmp4.y = tmp4.z + tmp4.y;
                    tmp4.y = floor(tmp4.y);
                    tmp4.z = tmp2.w <= 0.00001;
                    tmp4.z = tmp4.z ? 1.0 : 0.0;
                    tmp4.y = tmp4.z + tmp4.y;
                    tmp4.y = tmp4.y * 100000000.0;
                    tmp5.z = tmp2.w * _ProjectionParams.z + tmp4.y;
                    tmp3.zw = tmp3.zw - unity_CameraProjection._m02_m12;
                    tmp3.zw = tmp3.zw - float2(1.0, 1.0);
                    tmp3.zw = tmp3.zw / tmp3.xy;
                    tmp2.w = 1.0 - tmp5.z;
                    tmp2.w = unity_OrthoParams.w * tmp2.w + tmp5.z;
                    tmp5.xy = tmp2.ww * tmp3.zw;
                    tmp4.yzw = tmp5.xyz - tmp2.xyz;
                    tmp2.w = dot(tmp4.xyz, tmp1.xyz);
                    tmp2.w = -tmp2.z * 0.002 + tmp2.w;
                    tmp2.w = max(tmp2.w, 0.0);
                    tmp3.z = dot(tmp4.xyz, tmp4.xyz);
                    tmp3.z = tmp3.z + 0.0001;
                    tmp2.w = tmp2.w / tmp3.z;
                    tmp0.w = tmp0.w + tmp2.w;
                }
                tmp0.x = tmp0.w * _AOParams.y;
                tmp0.x = tmp0.x * _AOParams.x;
                tmp0.x = tmp0.x / _AOParams.w;
                tmp0.x = max(abs(tmp0.x), 0.0000001);
                tmp0.x = log(tmp0.x);
                tmp0.x = tmp0.x * 0.6;
                o.sv_target.x = exp(tmp0.x);
                o.sv_target.yzw = tmp1.xyz * float3(0.5, 0.5, 0.5) + float3(0.5, 0.5, 0.5);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 186726
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
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
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
                float4 tmp3;
                float4 tmp4;
                tmp0.x = _MainTex_TexelSize.x;
                tmp0.y = 0.0;
                tmp1 = saturate(-tmp0.xyxy * float4(2.769231, 1.384615, 6.461538, 3.230769) + inp.texcoord.xyxy);
                tmp0 = saturate(tmp0.xyxy * float4(2.769231, 1.384615, 6.461538, 3.230769) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp3 = tex2D(_CameraDepthNormalsTexture, inp.texcoord1.xy);
                tmp3.xyz = tmp3.xyz * float3(3.5554, 3.5554, 0.0) + float3(-1.7777, -1.7777, 1.0);
                tmp3.z = dot(tmp3.xyz, tmp3.xyz);
                tmp3.z = 2.0 / tmp3.z;
                tmp4.yz = tmp3.xy * tmp3.zz;
                tmp4.w = tmp3.z - 1.0;
                tmp3.xyz = tmp4.yzw * float3(1.0, 1.0, -1.0);
                o.sv_target.yzw = tmp4.yzw * float3(0.5, 0.5, -0.5) + float3(0.5, 0.5, 0.5);
                tmp2.y = dot(tmp3.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.y = tmp2.y * tmp2.z;
                tmp2.y = tmp2.y * 0.3162162;
                tmp2.x = tmp2.y * tmp2.x;
                tmp4 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2.x = tmp4.x * 0.227027 + tmp2.x;
                tmp4 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp4.yzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.z = dot(tmp3.xyz, tmp4.xyz);
                tmp2.z = tmp2.z - 0.8;
                tmp2.z = saturate(tmp2.z * 5.0);
                tmp2.w = tmp2.z * -2.0 + 3.0;
                tmp2.z = tmp2.z * tmp2.z;
                tmp2.z = tmp2.z * tmp2.w;
                tmp2.w = tmp2.z * 0.3162162;
                tmp2.y = tmp2.z * 0.3162162 + tmp2.y;
                tmp2.x = tmp4.x * tmp2.w + tmp2.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.y = dot(tmp3.xyz, tmp1.xyz);
                tmp1.y = tmp1.y - 0.8;
                tmp1.y = saturate(tmp1.y * 5.0);
                tmp1.z = tmp1.y * -2.0 + 3.0;
                tmp1.y = tmp1.y * tmp1.y;
                tmp1.y = tmp1.y * tmp1.z;
                tmp1.z = tmp1.y * 0.0702703;
                tmp1.y = tmp1.y * 0.0702703 + tmp2.y;
                tmp1.x = tmp1.x * tmp1.z + tmp2.x;
                tmp0.yzw = tmp0.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.y = dot(tmp3.xyz, tmp0.xyz);
                tmp0.y = tmp0.y - 0.8;
                tmp0.y = saturate(tmp0.y * 5.0);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.z = tmp0.y * 0.0702703;
                tmp0.y = tmp0.y * 0.0702703 + tmp1.y;
                tmp0.y = tmp0.y + 0.227027;
                tmp0.x = tmp0.x * tmp0.z + tmp1.x;
                o.sv_target.x = tmp0.x / tmp0.y;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 202765
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
			float4x4 unity_WorldToCamera;
			float4 _MainTex_TexelSize;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraGBufferTexture2;
			
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
                tmp0 = tex2D(_CameraGBufferTexture2, inp.texcoord1.xy);
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = tmp0.w != 0.0;
                tmp0.w = tmp0.w ? -1.0 : -0.0;
                tmp0.xyz = tmp0.xyz * float3(2.0, 2.0, 2.0) + tmp0.www;
                tmp1.xyz = tmp0.yyy * unity_WorldToCamera._m01_m11_m21;
                tmp0.xyw = unity_WorldToCamera._m00_m10_m20 * tmp0.xxx + tmp1.xyz;
                tmp0.xyz = unity_WorldToCamera._m02_m12_m22 * tmp0.zzz + tmp0.xyw;
                tmp1.x = _MainTex_TexelSize.x;
                tmp1.y = 0.0;
                tmp2 = saturate(-tmp1.xyxy * float4(2.769231, 1.384615, 6.461538, 3.230769) + inp.texcoord.xyxy);
                tmp1 = saturate(tmp1.xyxy * float4(2.769231, 1.384615, 6.461538, 3.230769) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp2 = tex2D(_MainTex, tmp2.zw);
                tmp3.yzw = tmp3.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.w = dot(tmp0.xyz, tmp3.xyz);
                tmp0.w = tmp0.w - 0.8;
                tmp0.w = saturate(tmp0.w * 5.0);
                tmp3.y = tmp0.w * -2.0 + 3.0;
                tmp0.w = tmp0.w * tmp0.w;
                tmp0.w = tmp0.w * tmp3.y;
                tmp0.w = tmp0.w * 0.3162162;
                tmp3.x = tmp0.w * tmp3.x;
                tmp4 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp3.x = tmp4.x * 0.227027 + tmp3.x;
                tmp4 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp3.yzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp3.y = dot(tmp0.xyz, tmp3.xyz);
                tmp3.y = tmp3.y - 0.8;
                tmp3.y = saturate(tmp3.y * 5.0);
                tmp3.z = tmp3.y * -2.0 + 3.0;
                tmp3.y = tmp3.y * tmp3.y;
                tmp3.y = tmp3.y * tmp3.z;
                tmp3.z = tmp3.y * 0.3162162;
                tmp0.w = tmp3.y * 0.3162162 + tmp0.w;
                tmp3.x = tmp4.x * tmp3.z + tmp3.x;
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.y = tmp2.y * tmp2.z;
                tmp2.z = tmp2.y * 0.0702703;
                tmp0.w = tmp2.y * 0.0702703 + tmp0.w;
                tmp2.x = tmp2.x * tmp2.z + tmp3.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.y = dot(tmp0.xyz, tmp1.xyz);
                o.sv_target.yzw = tmp0.xyz * float3(0.5, 0.5, 0.5) + float3(0.5, 0.5, 0.5);
                tmp0.x = tmp1.y - 0.8;
                tmp0.x = saturate(tmp0.x * 5.0);
                tmp0.y = tmp0.x * -2.0 + 3.0;
                tmp0.x = tmp0.x * tmp0.x;
                tmp0.x = tmp0.x * tmp0.y;
                tmp0.y = tmp0.x * 0.0702703;
                tmp0.x = tmp0.x * 0.0702703 + tmp0.w;
                tmp0.x = tmp0.x + 0.227027;
                tmp0.y = tmp1.x * tmp0.y + tmp2.x;
                o.sv_target.x = tmp0.y / tmp0.x;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 311286
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
			float4 _AOParams;
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
                float4 tmp4;
                tmp0.x = _MainTex_TexelSize.y / _AOParams.z;
                tmp0.yz = float2(1.384615, 3.230769);
                tmp1 = saturate(float4(-0.0, -2.769231, -0.0, -6.461538) * tmp0.yxzx + inp.texcoord.xyxy);
                tmp0 = saturate(float4(0.0, 2.769231, 0.0, 6.461538) * tmp0.yxzx + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp3 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp3.yzw = tmp3.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp3.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.y = tmp2.y * tmp2.z;
                tmp2.y = tmp2.y * 0.3162162;
                tmp2.x = tmp2.y * tmp2.x;
                tmp2.x = tmp3.x * 0.227027 + tmp2.x;
                tmp4 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp4.yzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.z = dot(tmp3.xyz, tmp4.xyz);
                tmp2.z = tmp2.z - 0.8;
                tmp2.z = saturate(tmp2.z * 5.0);
                tmp2.w = tmp2.z * -2.0 + 3.0;
                tmp2.z = tmp2.z * tmp2.z;
                tmp2.z = tmp2.z * tmp2.w;
                tmp2.w = tmp2.z * 0.3162162;
                tmp2.y = tmp2.z * 0.3162162 + tmp2.y;
                tmp2.x = tmp4.x * tmp2.w + tmp2.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.y = dot(tmp3.xyz, tmp1.xyz);
                tmp1.y = tmp1.y - 0.8;
                tmp1.y = saturate(tmp1.y * 5.0);
                tmp1.z = tmp1.y * -2.0 + 3.0;
                tmp1.y = tmp1.y * tmp1.y;
                tmp1.y = tmp1.y * tmp1.z;
                tmp1.z = tmp1.y * 0.0702703;
                tmp1.y = tmp1.y * 0.0702703 + tmp2.y;
                tmp1.x = tmp1.x * tmp1.z + tmp2.x;
                tmp0.yzw = tmp0.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.y = dot(tmp3.xyz, tmp0.xyz);
                o.sv_target.yzw = tmp3.yzw * float3(0.5, 0.5, 0.5) + float3(0.5, 0.5, 0.5);
                tmp0.y = tmp0.y - 0.8;
                tmp0.y = saturate(tmp0.y * 5.0);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.z = tmp0.y * 0.0702703;
                tmp0.y = tmp0.y * 0.0702703 + tmp1.y;
                tmp0.y = tmp0.y + 0.227027;
                tmp0.x = tmp0.x * tmp0.z + tmp1.x;
                o.sv_target.x = tmp0.x / tmp0.y;
                return o;
			}
			ENDCG
		}
		Pass {
			Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 356579
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
			float4 _AOParams;
			float3 _AOColor;
			float4 _SAOcclusionTexture_TexelSize;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _SAOcclusionTexture;
			
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
                tmp0 = tex2D(_SAOcclusionTexture, tmp0.xy);
                tmp0.yzw = tmp0.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.xy = _SAOcclusionTexture_TexelSize.xy / _AOParams.zz;
                tmp2.xy = saturate(inp.texcoord.xy - tmp1.xy);
                tmp2.xy = tmp2.xy * _RenderViewportScaleFactor.xx;
                tmp2 = tex2D(_SAOcclusionTexture, tmp2.xy);
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.y = tmp2.y * tmp2.z;
                tmp0.x = tmp2.x * tmp2.y + tmp0.x;
                tmp1.zw = -tmp1.yx;
                tmp3 = saturate(tmp1.xzwy + inp.texcoord.xyxy);
                tmp1.xy = saturate(tmp1.xy + inp.texcoord.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_SAOcclusionTexture, tmp1.xy);
                tmp3 = tmp3 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_SAOcclusionTexture, tmp3.xy);
                tmp3 = tex2D(_SAOcclusionTexture, tmp3.zw);
                tmp2.xzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.x = dot(tmp0.xyz, tmp2.xyz);
                tmp2.x = tmp2.x - 0.8;
                tmp2.x = saturate(tmp2.x * 5.0);
                tmp2.z = tmp2.x * -2.0 + 3.0;
                tmp2.x = tmp2.x * tmp2.x;
                tmp2.w = tmp2.x * tmp2.z;
                tmp2.x = tmp2.z * tmp2.x + tmp2.y;
                tmp0.x = tmp4.x * tmp2.w + tmp0.x;
                tmp2.yzw = tmp3.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.w = tmp2.y * tmp2.z;
                tmp2.x = tmp2.z * tmp2.y + tmp2.x;
                tmp0.x = tmp3.x * tmp2.w + tmp0.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.y = dot(tmp0.xyz, tmp1.xyz);
                tmp0.y = tmp0.y - 0.8;
                tmp0.y = saturate(tmp0.y * 5.0);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.w = tmp0.y * tmp0.z;
                tmp0.y = tmp0.z * tmp0.y + tmp2.x;
                tmp0.y = tmp0.y + 1.0;
                tmp0.x = tmp1.x * tmp0.w + tmp0.x;
                tmp0.x = saturate(tmp0.x / tmp0.y);
                tmp0.x = 1.0 - tmp0.x;
                tmp0.y = max(tmp0.x, 0.0000001);
                tmp0.y = log(tmp0.y);
                tmp0.yz = tmp0.yx * float2(0.4166667, 12.92);
                tmp0.y = exp(tmp0.y);
                tmp0.y = tmp0.y * 1.055 + -0.055;
                tmp0.x = tmp0.x <= 0.0031308;
                tmp0.x = tmp0.x ? tmp0.z : tmp0.y;
                tmp0.x = max(tmp0.x, 0.0);
                tmp0.x = 1.0 - tmp0.x;
                o.sv_target.xyz = tmp0.xxx * _AOColor;
                o.sv_target.w = tmp0.x;
                return o;
			}
			ENDCG
		}
		Pass {
			Blend Zero OneMinusSrcColor, Zero OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 448316
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
			float4 _AOParams;
			float3 _AOColor;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _SAOcclusionTexture;
			
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
                tmp0 = tex2D(_SAOcclusionTexture, tmp0.xy);
                tmp1.xy = _ScreenParams.zw - float2(1.0, 1.0);
                tmp1.xy = tmp1.xy / _AOParams.zz;
                tmp2.xy = saturate(inp.texcoord.xy - tmp1.xy);
                tmp2.xy = tmp2.xy * _RenderViewportScaleFactor.xx;
                tmp2 = tex2D(_SAOcclusionTexture, tmp2.xy);
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.yzw = tmp0.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.y = tmp2.y * tmp2.z;
                tmp0.x = tmp2.x * tmp2.y + tmp0.x;
                tmp1.zw = -tmp1.yx;
                tmp3 = saturate(tmp1.xzwy + inp.texcoord.xyxy);
                tmp1.xy = saturate(tmp1.xy + inp.texcoord.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_SAOcclusionTexture, tmp1.xy);
                tmp3 = tmp3 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_SAOcclusionTexture, tmp3.xy);
                tmp3 = tex2D(_SAOcclusionTexture, tmp3.zw);
                tmp2.xzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.x = dot(tmp0.xyz, tmp2.xyz);
                tmp2.x = tmp2.x - 0.8;
                tmp2.x = saturate(tmp2.x * 5.0);
                tmp2.z = tmp2.x * -2.0 + 3.0;
                tmp2.x = tmp2.x * tmp2.x;
                tmp2.w = tmp2.x * tmp2.z;
                tmp2.x = tmp2.z * tmp2.x + tmp2.y;
                tmp0.x = tmp4.x * tmp2.w + tmp0.x;
                tmp2.yzw = tmp3.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.w = tmp2.y * tmp2.z;
                tmp2.x = tmp2.z * tmp2.y + tmp2.x;
                tmp0.x = tmp3.x * tmp2.w + tmp0.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.y = dot(tmp0.xyz, tmp1.xyz);
                tmp0.y = tmp0.y - 0.8;
                tmp0.y = saturate(tmp0.y * 5.0);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.w = tmp0.y * tmp0.z;
                tmp0.y = tmp0.z * tmp0.y + tmp2.x;
                tmp0.y = tmp0.y + 1.0;
                tmp0.x = tmp1.x * tmp0.w + tmp0.x;
                tmp0.x = tmp0.x / tmp0.y;
                o.sv_target.w = tmp0.x;
                tmp0.x = saturate(tmp0.x);
                tmp0.x = 1.0 - tmp0.x;
                o.sv_target.xyz = float3(0.0, 0.0, 0.0);
                tmp0.y = max(tmp0.x, 0.0000001);
                tmp0.y = log(tmp0.y);
                tmp0.yz = tmp0.yx * float2(0.4166667, 12.92);
                tmp0.y = exp(tmp0.y);
                tmp0.y = tmp0.y * 1.055 + -0.055;
                tmp0.x = tmp0.x <= 0.0031308;
                tmp0.x = tmp0.x ? tmp0.z : tmp0.y;
                tmp0.x = max(tmp0.x, 0.0);
                tmp0.x = 1.0 - tmp0.x;
                o.sv_target1.xyz = tmp0.xxx * _AOColor;
                o.sv_target1.w = 0.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 519670
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
			float4 _AOParams;
			float4 _SAOcclusionTexture_TexelSize;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _SAOcclusionTexture;
			
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
                tmp0 = tex2D(_SAOcclusionTexture, tmp0.xy);
                tmp0.yzw = tmp0.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.xy = _SAOcclusionTexture_TexelSize.xy / _AOParams.zz;
                tmp2.xy = saturate(inp.texcoord.xy - tmp1.xy);
                tmp2.xy = tmp2.xy * _RenderViewportScaleFactor.xx;
                tmp2 = tex2D(_SAOcclusionTexture, tmp2.xy);
                tmp2.yzw = tmp2.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.w = tmp2.y * tmp2.z;
                tmp2.y = tmp2.z * tmp2.y + 1.0;
                tmp0.x = tmp2.x * tmp2.w + tmp0.x;
                tmp1.zw = -tmp1.yx;
                tmp3 = saturate(tmp1.xzwy + inp.texcoord.xyxy);
                tmp1.xy = saturate(tmp1.xy + inp.texcoord.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_SAOcclusionTexture, tmp1.xy);
                tmp3 = tmp3 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_SAOcclusionTexture, tmp3.xy);
                tmp3 = tex2D(_SAOcclusionTexture, tmp3.zw);
                tmp2.xzw = tmp4.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.x = dot(tmp0.xyz, tmp2.xyz);
                tmp2.x = tmp2.x - 0.8;
                tmp2.x = saturate(tmp2.x * 5.0);
                tmp2.z = tmp2.x * -2.0 + 3.0;
                tmp2.x = tmp2.x * tmp2.x;
                tmp2.w = tmp2.x * tmp2.z;
                tmp2.x = tmp2.z * tmp2.x + tmp2.y;
                tmp0.x = tmp4.x * tmp2.w + tmp0.x;
                tmp2.yzw = tmp3.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.y = dot(tmp0.xyz, tmp2.xyz);
                tmp2.y = tmp2.y - 0.8;
                tmp2.y = saturate(tmp2.y * 5.0);
                tmp2.z = tmp2.y * -2.0 + 3.0;
                tmp2.y = tmp2.y * tmp2.y;
                tmp2.w = tmp2.y * tmp2.z;
                tmp2.x = tmp2.z * tmp2.y + tmp2.x;
                tmp0.x = tmp3.x * tmp2.w + tmp0.x;
                tmp1.yzw = tmp1.yzw * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp0.y = dot(tmp0.xyz, tmp1.xyz);
                tmp0.y = tmp0.y - 0.8;
                tmp0.y = saturate(tmp0.y * 5.0);
                tmp0.z = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.w = tmp0.y * tmp0.z;
                tmp0.y = tmp0.z * tmp0.y + tmp2.x;
                tmp0.x = tmp1.x * tmp0.w + tmp0.x;
                tmp0.x = saturate(tmp0.x / tmp0.y);
                tmp0.x = 1.0 - tmp0.x;
                tmp0.y = max(tmp0.x, 0.0000001);
                tmp0.y = log(tmp0.y);
                tmp0.yz = tmp0.yx * float2(0.4166667, 12.92);
                tmp0.y = exp(tmp0.y);
                tmp0.y = tmp0.y * 1.055 + -0.055;
                tmp0.x = tmp0.x <= 0.0031308;
                tmp0.x = tmp0.x ? tmp0.z : tmp0.y;
                tmp0.x = max(tmp0.x, 0.0);
                tmp0.x = 1.0 - tmp0.x;
                o.sv_target.xyz = float3(1.0, 1.0, 1.0) - tmp0.xxx;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}