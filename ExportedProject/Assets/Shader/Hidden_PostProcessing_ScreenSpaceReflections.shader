Shader "Hidden/PostProcessing/ScreenSpaceReflections" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 60921
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
			// $Globals ConstantBuffers for Fragment Shader
			float4x4 _ViewMatrix;
			float4x4 _InverseProjectionMatrix;
			float4x4 _ScreenSpaceProjectionMatrix;
			float4 _Test_TexelSize;
			float4 _Params;
			float4 _Params2;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _CameraDepthTexture;
			sampler2D _CameraGBufferTexture2;
			sampler2D _Noise;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                o.texcoord1 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
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
                tmp0 = tex2D(_CameraGBufferTexture2, inp.texcoord1.xy);
                tmp0.w = dot(tmp0, float4(1.0, 1.0, 1.0, 1.0));
                tmp0.w = tmp0.w == 0.0;
                if (tmp0.w) {
                    o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                    return o;
                }
                tmp0.w = tex2Dlod(_CameraDepthTexture, float4(inp.texcoord.xy, 0, 0.0));
                tmp1.xy = inp.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp2 = tmp1.yyyy * _InverseProjectionMatrix._m01_m11_m21_m31;
                tmp1 = _InverseProjectionMatrix._m00_m10_m20_m30 * tmp1.xxxx + tmp2;
                tmp1 = _InverseProjectionMatrix._m02_m12_m22_m32 * tmp0.wwww + tmp1;
                tmp1 = tmp1 + _InverseProjectionMatrix._m03_m13_m23_m33;
                tmp1.xyz = tmp1.xyz / tmp1.www;
                tmp0.w = tmp1.z < -_Params.z;
                if (tmp0.w) {
                    o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                    return o;
                }
                tmp0.xyz = tmp0.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.xyz = tmp0.yyy * _ViewMatrix._m01_m11_m21;
                tmp0.xyw = _ViewMatrix._m00_m10_m20 * tmp0.xxx + tmp2.xyz;
                tmp0.xyz = _ViewMatrix._m02_m12_m22 * tmp0.zzz + tmp0.xyw;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp1.xyz;
                tmp0.w = dot(tmp2.xyz, tmp0.xyz);
                tmp0.w = tmp0.w + tmp0.w;
                tmp0.xyz = tmp0.xyz * -tmp0.www + tmp2.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp0.w = tmp0.z > 0.0;
                if (tmp0.w) {
                    o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                    return o;
                }
                tmp0.w = tmp0.z * _Params.z + tmp1.z;
                tmp0.w = -_ProjectionParams.y < tmp0.w;
                tmp1.w = -tmp1.z - _ProjectionParams.y;
                tmp1.w = tmp1.w / tmp0.z;
                tmp0.w = tmp0.w ? tmp1.w : _Params.z;
                tmp0.xyz = tmp0.xyz * tmp0.www + tmp1.xyz;
                tmp2.xyz = tmp1.zzz * _ScreenSpaceProjectionMatrix._m02_m12_m32;
                tmp3.z = _ScreenSpaceProjectionMatrix._m00 * tmp1.x + tmp2.x;
                tmp3.w = _ScreenSpaceProjectionMatrix._m11 * tmp1.y + tmp2.y;
                tmp1.xyw = tmp0.zzz * _ScreenSpaceProjectionMatrix._m02_m12_m32;
                tmp3.x = _ScreenSpaceProjectionMatrix._m00 * tmp0.x + tmp1.x;
                tmp3.y = _ScreenSpaceProjectionMatrix._m11 * tmp0.y + tmp1.y;
                tmp2.zw = rcp(tmp2.zz);
                tmp2.xy = rcp(tmp1.ww);
                tmp4.w = tmp1.z * tmp2.w;
                tmp5 = tmp2.wzxy * tmp3.wzxy;
                tmp0.xy = tmp3.zw * tmp2.zw + -tmp5.zw;
                tmp0.x = dot(tmp0.xy, tmp0.xy);
                tmp0.x = tmp0.x <= 0.0001;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.y = max(_Test_TexelSize.y, _Test_TexelSize.x);
                tmp0.xy = tmp0.xx * tmp0.yy + tmp5.wz;
                tmp5.zw = -tmp3.wz * tmp2.wz + tmp0.xy;
                tmp0.x = abs(tmp5.w) < abs(tmp5.z);
                tmp3 = tmp0.xxxx ? tmp5 : tmp5.yxwz;
                tmp0.y = tmp3.z > 0.0;
                tmp0.w = tmp3.z < 0.0;
                tmp0.y = tmp0.w - tmp0.y;
                tmp5.x = floor(tmp0.y);
                tmp0.y = tmp5.x / tmp3.z;
                tmp0.z = tmp0.z * tmp2.y + -tmp4.w;
                tmp5.w = tmp0.y * tmp0.z;
                tmp5.y = tmp0.y * tmp3.w;
                tmp0.z = tmp2.y - tmp2.w;
                tmp5.z = tmp0.y * tmp0.z;
                tmp0.y = tmp1.z * -0.01;
                tmp0.y = min(tmp0.y, 1.0);
                tmp0.y = 1.0 - tmp0.y;
                tmp1.xy = inp.texcoord.xy * _Params2.yy;
                tmp1.z = tmp1.y * _Params2.x;
                tmp0.zw = tmp1.xz + _WorldSpaceCameraPos.xz;
                tmp0.z = tex2Dlod(_Noise, float4(tmp0.zw, 0, 0.0));
                tmp0.y = tmp0.y * _Params2.z;
                tmp1 = tmp0.yyyy * tmp5;
                tmp4.xy = tmp3.xy;
                tmp4.z = tmp2.w;
                tmp2 = tmp1 * tmp0.zzzz + tmp4;
                tmp3.x = NaN;
                tmp4 = float4(0.0, 0.0, 0.0, 0.0);
                tmp6 = tmp2;
                tmp7 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.zw = float2(0.0, 0.0);
                tmp8.x = 0.0;
                while (true) {
                    tmp1.x = floor(tmp0.w);
                    tmp1.x = tmp1.x >= _Params2.w;
                    tmp8.x = 0.0;
                    if (tmp1.x) {
                        break;
                    }
                    tmp6 = tmp5 * tmp0.yyyy + tmp6;
                    tmp1.xy = tmp1.wz * float2(0.5, 0.5) + tmp6.wz;
                    tmp1.x = tmp1.x / tmp1.y;
                    tmp1.y = tmp0.z < tmp1.x;
                    tmp0.z = tmp1.y ? tmp0.z : tmp1.x;
                    tmp1.xy = tmp0.xx ? tmp6.yx : tmp6.xy;
                    tmp3.yz = tmp1.xy * _Test_TexelSize.xy;
                    tmp1.x = tex2Dlod(_CameraDepthTexture, float4(tmp3.yz, 0, 0.0));
                    tmp1.x = _ZBufferParams.z * tmp1.x + _ZBufferParams.w;
                    tmp1.x = 1.0 / tmp1.x;
                    tmp1.x = tmp0.z < -tmp1.x;
                    tmp3.w = tmp0.w + 1;
                    tmp8 = tmp1.xxxx ? tmp3 : 0.0;
                    tmp4 = tmp8;
                    tmp7 = tmp8;
                    if (tmp1.x) {
                        break;
                    }
                    tmp8.x = tmp1.x;
                    tmp0.w = tmp0.w + 1;
                    tmp4 = float4(0.0, 0.0, 0.0, 0.0);
                    tmp7 = float4(0.0, 0.0, 0.0, 0.0);
                }
                tmp0 = tmp8.xxxx ? tmp4 : tmp7;
                tmp0.w = floor(tmp0.w);
                o.sv_target.z = tmp0.w / _Params2.w;
                o.sv_target.w = tmp0.x ? 1.0 : 0.0;
                o.sv_target.xy = tmp0.yz;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 110939
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
			// $Globals ConstantBuffers for Fragment Shader
			float4 _MainTex_TexelSize;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _Test;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                o.texcoord1 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0.xy = asint(inp.position.xy);
                tmp0.zw = float2(0.0, 0.0);
                tmp0 = Load(_Test, tmp0.xyz);
                tmp1.x = tmp0.w == 0.0;
                if (tmp1.x) {
                    o.sv_target = tex2D(_MainTex, inp.texcoord1.xy);
                    return o;
                }
                tmp1.xyz = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                tmp1.w = max(tmp0.y, tmp0.x);
                tmp1.w = 1.0 - tmp1.w;
                tmp2.x = min(tmp0.y, tmp0.x);
                tmp1.w = min(tmp1.w, tmp2.x);
                tmp1.w = saturate(tmp1.w * 2.191781);
                tmp1.w = rsqrt(tmp1.w);
                tmp1.w = 1.0 / tmp1.w;
                tmp0.w = tmp0.w * tmp1.w;
                tmp0.xy = tmp0.xy - float2(0.5, 0.5);
                tmp2.yz = abs(tmp0.xy) * _Params.xx;
                tmp0.x = _MainTex_TexelSize.z * _MainTex_TexelSize.y;
                tmp2.x = tmp0.x * tmp2.y;
                tmp0.x = dot(tmp2.xy, tmp2.xy);
                tmp0.x = 1.0 - tmp0.x;
                tmp0.x = max(tmp0.x, 0.0);
                tmp0.y = tmp0.x * tmp0.x;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.x = tmp0.y * tmp0.x;
                tmp0.x = tmp0.x * tmp0.w;
                o.sv_target.xyz = tmp0.xxx * tmp1.xyz;
                o.sv_target.w = tmp0.z;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 190959
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
			// $Globals ConstantBuffers for Fragment Shader
			float4 _MainTex_TexelSize;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _History;
			sampler2D _CameraMotionVectorsTexture;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                o.texcoord1 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
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
                tmp0.z = 0.0;
                tmp0.xyw = -_MainTex_TexelSize.xyy;
                tmp0 = tmp0 + inp.texcoord.xyxy;
                tmp1 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                tmp0 = tex2Dlod(_MainTex, float4(tmp0.zw, 0, 0.0));
                tmp2 = min(tmp0, tmp1);
                tmp0 = max(tmp0, tmp1);
                tmp1 = _MainTex_TexelSize * float4(1.0, -1.0, -1.0, 1.0) + inp.texcoord.xyxy;
                tmp3 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                tmp1 = tex2Dlod(_MainTex, float4(tmp1.zw, 0, 0.0));
                tmp2 = min(tmp2, tmp3);
                tmp0 = max(tmp0, tmp3);
                tmp3.x = -_MainTex_TexelSize.x;
                tmp3.yw = float2(0.0, 0.0);
                tmp3.xy = tmp3.xy + inp.texcoord.xy;
                tmp4 = tex2Dlod(_MainTex, float4(tmp3.xy, 0, 0.0));
                tmp2 = min(tmp2, tmp4);
                tmp0 = max(tmp0, tmp4);
                tmp3.z = _MainTex_TexelSize.x;
                tmp3.xy = tmp3.zw + inp.texcoord.xy;
                tmp3 = tex2Dlod(_MainTex, float4(tmp3.xy, 0, 0.0));
                tmp2 = min(tmp2, tmp3);
                tmp0 = max(tmp0, tmp3);
                tmp0 = max(tmp1, tmp0);
                tmp1 = min(tmp1, tmp2);
                tmp2.x = 0.0;
                tmp2.y = _MainTex_TexelSize.y;
                tmp2.xy = tmp2.xy + inp.texcoord.xy;
                tmp2 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                tmp1 = min(tmp1, tmp2);
                tmp0 = max(tmp0, tmp2);
                tmp2.xy = inp.texcoord.xy + _MainTex_TexelSize.xy;
                tmp2 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                tmp1 = min(tmp1, tmp2);
                tmp0 = max(tmp0, tmp2);
                tmp2 = tex2Dlod(_MainTex, float4(inp.texcoord1.xy, 0, 0.0));
                tmp1 = min(tmp1, tmp2);
                tmp3.xy = tex2Dlod(_CameraMotionVectorsTexture, float4(inp.texcoord1.xy, 0, 0.0));
                tmp3.zw = inp.texcoord.xy - tmp3.xy;
                tmp3.x = dot(tmp3.xy, tmp3.xy);
                tmp3.x = sqrt(tmp3.x);
                tmp3.x = -_MainTex_TexelSize.z * 0.002 + tmp3.x;
                tmp4 = tex2Dlod(_History, float4(tmp3.zw, 0, 0.0));
                tmp1 = max(tmp1, tmp4);
                tmp0 = max(tmp0, tmp2);
                tmp0 = min(tmp0, tmp1);
                tmp1.x = _MainTex_TexelSize.z * 0.0015;
                tmp1.x = 1.0 / tmp1.x;
                tmp1.x = saturate(tmp1.x * tmp3.x);
                tmp1.y = tmp1.x * -2.0 + 3.0;
                tmp1.x = tmp1.x * tmp1.x;
                tmp1.x = tmp1.x * tmp1.y;
                tmp1.x = min(tmp1.x, 1.0);
                tmp2.w = tmp1.x * 0.85;
                tmp1 = tmp0 - tmp2;
                tmp0.x = tmp0.w * -25.0 + 0.95;
                tmp0.x = max(tmp0.x, 0.7);
                tmp0.x = min(tmp0.x, 0.95);
                o.sv_target = tmp0.xxxx * tmp1 + tmp2;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 236279
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
			// $Globals ConstantBuffers for Fragment Shader
			float4x4 _InverseViewMatrix;
			float4x4 _InverseProjectionMatrix;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraDepthTexture;
			sampler2D _CameraReflectionsTexture;
			sampler2D _CameraGBufferTexture0;
			sampler2D _CameraGBufferTexture1;
			sampler2D _CameraGBufferTexture2;
			sampler2D _Resolve;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                o.texcoord1 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
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
                tmp0.x = tex2Dlod(_CameraDepthTexture, float4(inp.texcoord1.xy, 0, 0.0));
                tmp0.x = _ZBufferParams.x * tmp0.x + _ZBufferParams.y;
                tmp0.x = 1.0 / tmp0.x;
                tmp0.x = tmp0.x > 0.999;
                if (tmp0.x) {
                    o.sv_target = tex2D(_MainTex, inp.texcoord1.xy);
                    return o;
                }
                tmp0.xy = asint(inp.position.xy);
                tmp0.zw = float2(0.0, 0.0);
                tmp1.x = Load(_CameraGBufferTexture0.w, tmp0.xyw);
                tmp2 = Load(_CameraGBufferTexture1, tmp0.xyw);
                tmp0.xyz = Load(_CameraGBufferTexture2.xyz, tmp0.xyz);
                tmp0.w = max(tmp2.y, tmp2.x);
                tmp0.w = max(tmp2.z, tmp0.w);
                tmp0.w = 1.0 - tmp0.w;
                tmp0.xyz = tmp0.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.y = tex2Dlod(_CameraDepthTexture, float4(inp.texcoord.xy, 0, 0.0));
                tmp1.zw = inp.texcoord.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp3 = tmp1.wwww * _InverseProjectionMatrix._m01_m11_m21_m31;
                tmp3 = _InverseProjectionMatrix._m00_m10_m20_m30 * tmp1.zzzz + tmp3;
                tmp3 = _InverseProjectionMatrix._m02_m12_m22_m32 * tmp1.yyyy + tmp3;
                tmp3 = tmp3 + _InverseProjectionMatrix._m03_m13_m23_m33;
                tmp1.yzw = tmp3.xyz / tmp3.www;
                tmp3.x = dot(tmp1.xyz, tmp1.xyz);
                tmp3.x = rsqrt(tmp3.x);
                tmp1.yzw = tmp1.yzw * tmp3.xxx;
                tmp3.xyz = tmp1.zzz * _InverseViewMatrix._m01_m11_m21;
                tmp3.xyz = _InverseViewMatrix._m00_m10_m20 * tmp1.yyy + tmp3.xyz;
                tmp1.yzw = _InverseViewMatrix._m02_m12_m22 * tmp1.www + tmp3.xyz;
                tmp3.x = 1.0 - tmp2.w;
                tmp3.y = tmp3.x * tmp3.x;
                tmp3.z = _Params.w - 1.0;
                tmp3.z = tmp3.y * tmp3.z + 1.0;
                tmp4 = tex2Dlod(_Resolve, float4(inp.texcoord1.xy, 0, tmp3.z));
                tmp3.z = dot(-tmp1.xyz, tmp0.xyz);
                tmp3.w = tmp3.z + tmp3.z;
                tmp0.xyz = tmp0.xyz * -tmp3.www + -tmp1.yzw;
                tmp3.w = dot(tmp0.xyz, tmp0.xyz);
                tmp3.w = rsqrt(tmp3.w);
                tmp0.xyz = tmp0.xyz * tmp3.www;
                tmp0.x = dot(-tmp1.xyz, tmp0.xyz);
                tmp0.x = saturate(tmp0.x + tmp0.x);
                tmp0.y = max(tmp3.y, 0.002);
                tmp0.y = tmp0.y * 0.28;
                tmp0.y = -tmp0.y * tmp3.x + 1.0;
                tmp0.z = tmp2.w - tmp0.w;
                tmp0.z = saturate(tmp0.z + 1.0);
                tmp1.yzw = tmp4.xyz * tmp0.yyy;
                tmp0.y = 1.0 - abs(tmp3.z);
                tmp0.w = tmp0.y * tmp0.y;
                tmp0.w = tmp0.w * tmp0.w;
                tmp0.y = tmp0.y * tmp0.w;
                tmp3.xyz = tmp0.zzz - tmp2.xyz;
                tmp0.yzw = tmp0.yyy * tmp3.xyz + tmp2.xyz;
                tmp2.xyz = tex2D(_CameraReflectionsTexture, inp.texcoord1.xy);
                tmp3 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp3.xyz = tmp3.xyz - tmp2.xyz;
                tmp3.xyz = max(tmp3.xyz, float3(0.0, 0.0, 0.0));
                tmp2.w = tmp4.w * tmp4.w;
                tmp4.x = tmp2.w * 3.0;
                tmp2.w = tmp2.w * 3.0 + -0.5;
                tmp2.w = saturate(tmp2.w + tmp2.w);
                tmp4.y = tmp2.w * -2.0 + 3.0;
                tmp2.w = tmp2.w * tmp2.w;
                tmp2.w = tmp2.w * tmp4.y;
                tmp2.w = tmp2.w * tmp4.x;
                tmp2.w = saturate(tmp2.w * _Params.y);
                tmp2.w = 1.0 - tmp2.w;
                tmp0.x = tmp0.x * tmp2.w;
                tmp0.yzw = tmp1.yzw * tmp0.yzw + -tmp2.xyz;
                tmp0.xyz = tmp0.xxx * tmp0.yzw + tmp2.xyz;
                o.sv_target.xyz = tmp0.xyz * tmp1.xxx + tmp3.xyz;
                o.sv_target.w = tmp3.w;
                return o;
			}
			ENDCG
		}
	}
}