Shader "Cans" {
	Properties {
		[Header(Translucency)] _Translucency ("Strength", Range(0, 50)) = 1
		_TransNormalDistortion ("Normal Distortion", Range(0, 1)) = 0.1
		_TransScattering ("Scaterring Falloff", Range(1, 50)) = 2
		_TransDirect ("Direct", Range(0, 1)) = 1
		_TransAmbient ("Ambient", Range(0, 1)) = 0.2
		_TransShadow ("Shadow", Range(0, 1)) = 0.9
		[HideInInspector] __dirty ("", Float) = 1
	}
	SubShader {
		Tags { "QUEUE" = "Geometry+0" "RenderType" = "Opaque" }
		Pass {
			Name "FORWARD"
			Tags { "LIGHTMODE" = "FORWARDBASE" "QUEUE" = "Geometry+0" "RenderType" = "Opaque" "SHADOWSUPPORT" = "true" }
			GpuProgramID 32692
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
				float3 texcoord1 : TEXCOORD1;
				float4 texcoord4 : TEXCOORD4;
				float4 texcoord5 : TEXCOORD5;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float _Translucency;
			float _TransNormalDistortion;
			float _TransScattering;
			float _TransDirect;
			float _TransShadow;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: DIRECTIONAL
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp1 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                o.texcoord1.xyz = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp0.xyz;
                tmp0 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp0 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp0;
                tmp0 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp0;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp0;
                tmp0.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp0.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp0.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                o.texcoord.xyz = tmp0.www * tmp0.xyz;
                o.texcoord4 = float4(0.0, 0.0, 0.0, 0.0);
                o.texcoord5 = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			// Keywords: DIRECTIONAL
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
                float4 tmp9;
                float4 tmp10;
                tmp0.xyz = _WorldSpaceCameraPos - inp.texcoord1.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp0.xyz;
                tmp2.xyz = inp.texcoord.yyy * unity_WorldToObject._m01_m11_m21;
                tmp2.xyz = unity_WorldToObject._m00_m10_m20 * inp.texcoord.xxx + tmp2.xyz;
                tmp2.xyz = unity_WorldToObject._m02_m12_m22 * inp.texcoord.zzz + tmp2.xyz;
                tmp1.w = dot(tmp1.xyz, tmp2.xyz);
                tmp2 = tmp1.wwww - float4(0.1294118, 0.3088273, 0.402945, 0.4676432);
                tmp2 = saturate(tmp2 * float4(5.573344, 10.62387, 15.45399, 12.14137));
                tmp3.xyz = tmp2.xxx * float3(0.4433962, -0.5566038, 0.3117281) + float3(0.5566038, 0.5566038, 0.5566038);
                tmp4.xyz = float3(0.0980392, 0.9853407, 1.0) - tmp3.xyz;
                tmp3.xyz = tmp2.yyy * tmp4.xyz + tmp3.xyz;
                tmp4.xyz = float3(1.0, 1.0, 0.39) - tmp3.xyz;
                tmp2.xyz = tmp2.zzz * tmp4.xyz + tmp3.xyz;
                tmp3.xyz = float3(1.0, 0.0, 0.3315091) - tmp2.xyz;
                tmp2.xyz = tmp2.www * tmp3.xyz + tmp2.xyz;
                tmp3.xyz = tmp1.www - float3(0.5499962, 0.6911727, 0.8147097);
                tmp3.xyz = saturate(tmp3.xyz * float3(7.082829, 8.094086, 5.483801));
                tmp4.xyz = float3(0.0, 0.9201925, 1.0) - tmp2.xyz;
                tmp2.xyz = tmp3.xxx * tmp4.xyz + tmp2.xyz;
                tmp4.xyz = float3(1.0, 0.0, 0.8812718) - tmp2.xyz;
                tmp2.xyz = tmp3.yyy * tmp4.xyz + tmp2.xyz;
                tmp3.xyw = float3(0.6698113, 0.6698113, 0.6698113) - tmp2.xyz;
                tmp2.xyz = tmp3.zzz * tmp3.xyw + tmp2.xyz;
                tmp3.xyz = float3(0.7827414, 1.0, 0.3160377) - tmp2.xyz;
                tmp2.xyz = tmp3.xyz * float3(0.31, 0.31, 0.31) + tmp2.xyz;
                tmp1.w = unity_ProbeVolumeParams.x == 1.0;
                if (tmp1.w) {
                    tmp1.w = unity_ProbeVolumeParams.y == 1.0;
                    tmp3.xyz = inp.texcoord1.yyy * unity_ProbeVolumeWorldToObject._m01_m11_m21;
                    tmp3.xyz = unity_ProbeVolumeWorldToObject._m00_m10_m20 * inp.texcoord1.xxx + tmp3.xyz;
                    tmp3.xyz = unity_ProbeVolumeWorldToObject._m02_m12_m22 * inp.texcoord1.zzz + tmp3.xyz;
                    tmp3.xyz = tmp3.xyz + unity_ProbeVolumeWorldToObject._m03_m13_m23;
                    tmp3.xyz = tmp1.www ? tmp3.xyz : inp.texcoord1.xyz;
                    tmp3.xyz = tmp3.xyz - unity_ProbeVolumeMin;
                    tmp3.yzw = tmp3.xyz * unity_ProbeVolumeSizeInv;
                    tmp1.w = tmp3.y * 0.25 + 0.75;
                    tmp2.w = unity_ProbeVolumeParams.z * 0.5 + 0.75;
                    tmp3.x = max(tmp1.w, tmp2.w);
                    tmp3 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp3.xzw);
                } else {
                    tmp3 = float4(1.0, 1.0, 1.0, 1.0);
                }
                tmp1.w = saturate(dot(tmp3, unity_OcclusionMaskSelector));
                tmp2.w = dot(-tmp1.xyz, inp.texcoord.xyz);
                tmp2.w = tmp2.w + tmp2.w;
                tmp3.xyz = inp.texcoord.xyz * -tmp2.www + -tmp1.xyz;
                tmp4.xyz = tmp1.www * _LightColor0.xyz;
                tmp2.w = unity_SpecCube0_ProbePosition.w > 0.0;
                if (tmp2.w) {
                    tmp2.w = dot(tmp3.xyz, tmp3.xyz);
                    tmp2.w = rsqrt(tmp2.w);
                    tmp5.xyz = tmp2.www * tmp3.xyz;
                    tmp6.xyz = unity_SpecCube0_BoxMax.xyz - inp.texcoord1.xyz;
                    tmp6.xyz = tmp6.xyz / tmp5.xyz;
                    tmp7.xyz = unity_SpecCube0_BoxMin.xyz - inp.texcoord1.xyz;
                    tmp7.xyz = tmp7.xyz / tmp5.xyz;
                    tmp8.xyz = tmp5.xyz > float3(0.0, 0.0, 0.0);
                    tmp6.xyz = tmp8.xyz ? tmp6.xyz : tmp7.xyz;
                    tmp2.w = min(tmp6.y, tmp6.x);
                    tmp2.w = min(tmp6.z, tmp2.w);
                    tmp6.xyz = inp.texcoord1.xyz - unity_SpecCube0_ProbePosition.xyz;
                    tmp5.xyz = tmp5.xyz * tmp2.www + tmp6.xyz;
                } else {
                    tmp5.xyz = tmp3.xyz;
                }
                tmp5 = UNITY_SAMPLE_TEXCUBE_SAMPLER(unity_SpecCube0, unity_SpecCube0, float4(tmp5.xyz, 3.12768));
                tmp2.w = tmp5.w - 1.0;
                tmp2.w = unity_SpecCube0_HDR.w * tmp2.w + 1.0;
                tmp2.w = tmp2.w * unity_SpecCube0_HDR.x;
                tmp6.xyz = tmp5.xyz * tmp2.www;
                tmp3.w = unity_SpecCube0_BoxMin.w < 0.99999;
                if (tmp3.w) {
                    tmp3.w = unity_SpecCube1_ProbePosition.w > 0.0;
                    if (tmp3.w) {
                        tmp3.w = dot(tmp3.xyz, tmp3.xyz);
                        tmp3.w = rsqrt(tmp3.w);
                        tmp7.xyz = tmp3.www * tmp3.xyz;
                        tmp8.xyz = unity_SpecCube1_BoxMax.xyz - inp.texcoord1.xyz;
                        tmp8.xyz = tmp8.xyz / tmp7.xyz;
                        tmp9.xyz = unity_SpecCube1_BoxMin.xyz - inp.texcoord1.xyz;
                        tmp9.xyz = tmp9.xyz / tmp7.xyz;
                        tmp10.xyz = tmp7.xyz > float3(0.0, 0.0, 0.0);
                        tmp8.xyz = tmp10.xyz ? tmp8.xyz : tmp9.xyz;
                        tmp3.w = min(tmp8.y, tmp8.x);
                        tmp3.w = min(tmp8.z, tmp3.w);
                        tmp8.xyz = inp.texcoord1.xyz - unity_SpecCube1_ProbePosition.xyz;
                        tmp3.xyz = tmp7.xyz * tmp3.www + tmp8.xyz;
                    }
                    tmp3 = UNITY_SAMPLE_TEXCUBE_SAMPLER(unity_SpecCube0, unity_SpecCube0, float4(tmp3.xyz, 3.12768));
                    tmp3.w = tmp3.w - 1.0;
                    tmp3.w = unity_SpecCube1_HDR.w * tmp3.w + 1.0;
                    tmp3.w = tmp3.w * unity_SpecCube1_HDR.x;
                    tmp3.xyz = tmp3.xyz * tmp3.www;
                    tmp5.xyz = tmp2.www * tmp5.xyz + -tmp3.xyz;
                    tmp6.xyz = unity_SpecCube0_BoxMin.www * tmp5.xyz + tmp3.xyz;
                }
                tmp3.xyz = _LightColor0.xyz * tmp1.www + -_LightColor0.xyz;
                tmp3.xyz = _TransShadow.xxx * tmp3.xyz + _LightColor0.xyz;
                tmp5.xyz = inp.texcoord.xyz * _TransNormalDistortion.xxx + _WorldSpaceLightPos0.xyz;
                tmp1.w = saturate(dot(tmp1.xyz, -tmp5.xyz));
                tmp1.w = log(tmp1.w);
                tmp1.w = tmp1.w * _TransScattering;
                tmp1.w = exp(tmp1.w);
                tmp1.w = tmp1.w * _TransDirect;
                tmp3.xyz = tmp1.www * tmp3.xyz;
                tmp3.xyz = tmp3.xyz * float3(0.64, 0.64, 0.64);
                tmp3.xyz = tmp2.xyz * tmp3.xyz;
                tmp1.w = dot(inp.texcoord.xyz, inp.texcoord.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp5.xyz = tmp1.www * inp.texcoord.xyz;
                tmp7.xyz = tmp2.xyz - float3(0.2209163, 0.2209163, 0.2209163);
                tmp7.xyz = tmp7.xyz * float3(1.01, 1.01, 1.01) + float3(0.2209163, 0.2209163, 0.2209163);
                tmp2.xyz = tmp2.xyz * float3(-0.0077908, -0.0077908, -0.0077908);
                tmp0.xyz = tmp0.xyz * tmp0.www + _WorldSpaceLightPos0.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = max(tmp0.w, 0.001);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp0.w = dot(tmp5.xyz, tmp1.xyz);
                tmp1.x = saturate(dot(tmp5.xyz, _WorldSpaceLightPos0.xyz));
                tmp1.y = saturate(dot(tmp5.xyz, tmp0.xyz));
                tmp0.x = saturate(dot(_WorldSpaceLightPos0.xyz, tmp0.xyz));
                tmp0.y = tmp0.x * tmp0.x;
                tmp0.y = tmp0.y * 0.72 + -0.5;
                tmp0.z = 1.0 - tmp1.x;
                tmp1.z = tmp0.z * tmp0.z;
                tmp1.z = tmp1.z * tmp1.z;
                tmp0.z = tmp0.z * tmp1.z;
                tmp0.z = tmp0.y * tmp0.z + 1.0;
                tmp1.z = 1.0 - abs(tmp0.w);
                tmp1.w = tmp1.z * tmp1.z;
                tmp1.w = tmp1.w * tmp1.w;
                tmp1.z = tmp1.z * tmp1.w;
                tmp0.y = tmp0.y * tmp1.z + 1.0;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.z = abs(tmp0.w) * 0.8704 + 0.1296;
                tmp1.w = tmp1.x * 0.8704 + 0.1296;
                tmp0.w = abs(tmp0.w) * tmp1.w;
                tmp0.z = tmp1.x * tmp0.z + tmp0.w;
                tmp0.z = tmp0.z + 0.00001;
                tmp0.w = tmp1.y * tmp1.y;
                tmp0.w = tmp0.w * -0.9832038 + 1.0;
                tmp0.w = tmp0.w * tmp0.w + 0.0000001;
                tmp0.zw = float2(0.5, 0.0053464) / tmp0.zw;
                tmp0.z = tmp0.w * tmp0.z;
                tmp0.z = tmp0.z * 3.141593;
                tmp0.z = max(tmp0.z, 0.0001);
                tmp0.z = sqrt(tmp0.z);
                tmp0.yz = tmp1.xx * tmp0.yz;
                tmp0.w = dot(tmp7.xyz, tmp7.xyz);
                tmp0.w = tmp0.w != 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.z = tmp0.w * tmp0.z;
                tmp1.xyw = tmp0.yyy * tmp4.xyz;
                tmp0.yzw = tmp4.xyz * tmp0.zzz;
                tmp0.x = 1.0 - tmp0.x;
                tmp2.w = tmp0.x * tmp0.x;
                tmp2.w = tmp2.w * tmp2.w;
                tmp0.x = tmp0.x * tmp2.w;
                tmp4.xyz = float3(1.0, 1.0, 1.0) - tmp7.xyz;
                tmp5.xyz = tmp4.xyz * tmp0.xxx + tmp7.xyz;
                tmp0.xyz = tmp0.yzw * tmp5.xyz;
                tmp0.xyz = tmp2.xyz * tmp1.xyw + tmp0.xyz;
                tmp1.xyw = tmp6.xyz * float3(0.9869363, 0.9869363, 0.9869363);
                tmp2.xyz = tmp1.zzz * tmp4.xyz + tmp7.xyz;
                tmp0.xyz = tmp1.xyw * tmp2.xyz + tmp0.xyz;
                o.sv_target.xyz = tmp3.xyz * _Translucency.xxx + tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "FORWARD"
			Tags { "LIGHTMODE" = "FORWARDADD" "QUEUE" = "Geometry+0" "RenderType" = "Opaque" "SHADOWSUPPORT" = "true" }
			Blend One One, One One
			ZWrite Off
			GpuProgramID 103516
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord : TEXCOORD0;
				float3 texcoord1 : TEXCOORD1;
				float3 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4x4 unity_WorldToLight;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float _Translucency;
			float _TransNormalDistortion;
			float _TransScattering;
			float _TransDirect;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _LightTexture0;
			
			// Keywords: POINT
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp1 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp2 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp2 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp2;
                tmp2 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp2;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp2;
                tmp1.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp1.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp1.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp1.w = dot(tmp1.xyz, tmp1.xyz);
                tmp1.w = rsqrt(tmp1.w);
                o.texcoord.xyz = tmp1.www * tmp1.xyz;
                o.texcoord1.xyz = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp0.xyz;
                tmp0 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp0;
                tmp1.xyz = tmp0.yyy * unity_WorldToLight._m01_m11_m21;
                tmp1.xyz = unity_WorldToLight._m00_m10_m20 * tmp0.xxx + tmp1.xyz;
                tmp0.xyz = unity_WorldToLight._m02_m12_m22 * tmp0.zzz + tmp1.xyz;
                o.texcoord2.xyz = unity_WorldToLight._m03_m13_m23 * tmp0.www + tmp0.xyz;
                o.texcoord3 = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			// Keywords: POINT
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
                tmp0.xyz = _WorldSpaceLightPos0.xyz - inp.texcoord1.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp0.xyz;
                tmp2.xyz = _WorldSpaceCameraPos - inp.texcoord1.xyz;
                tmp1.w = dot(tmp2.xyz, tmp2.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp2.xyz = tmp1.www * tmp2.xyz;
                tmp3.xyz = inp.texcoord.yyy * unity_WorldToObject._m01_m11_m21;
                tmp3.xyz = unity_WorldToObject._m00_m10_m20 * inp.texcoord.xxx + tmp3.xyz;
                tmp3.xyz = unity_WorldToObject._m02_m12_m22 * inp.texcoord.zzz + tmp3.xyz;
                tmp1.w = dot(tmp2.xyz, tmp3.xyz);
                tmp3 = tmp1.wwww - float4(0.1294118, 0.3088273, 0.402945, 0.4676432);
                tmp3 = saturate(tmp3 * float4(5.573344, 10.62387, 15.45399, 12.14137));
                tmp4.xyz = tmp3.xxx * float3(0.4433962, -0.5566038, 0.3117281) + float3(0.5566038, 0.5566038, 0.5566038);
                tmp5.xyz = float3(0.0980392, 0.9853407, 1.0) - tmp4.xyz;
                tmp4.xyz = tmp3.yyy * tmp5.xyz + tmp4.xyz;
                tmp5.xyz = float3(1.0, 1.0, 0.39) - tmp4.xyz;
                tmp3.xyz = tmp3.zzz * tmp5.xyz + tmp4.xyz;
                tmp4.xyz = float3(1.0, 0.0, 0.3315091) - tmp3.xyz;
                tmp3.xyz = tmp3.www * tmp4.xyz + tmp3.xyz;
                tmp4.xyz = tmp1.www - float3(0.5499962, 0.6911727, 0.8147097);
                tmp4.xyz = saturate(tmp4.xyz * float3(7.082829, 8.094086, 5.483801));
                tmp5.xyz = float3(0.0, 0.9201925, 1.0) - tmp3.xyz;
                tmp3.xyz = tmp4.xxx * tmp5.xyz + tmp3.xyz;
                tmp5.xyz = float3(1.0, 0.0, 0.8812718) - tmp3.xyz;
                tmp3.xyz = tmp4.yyy * tmp5.xyz + tmp3.xyz;
                tmp4.xyw = float3(0.6698113, 0.6698113, 0.6698113) - tmp3.xyz;
                tmp3.xyz = tmp4.zzz * tmp4.xyw + tmp3.xyz;
                tmp4.xyz = float3(0.7827414, 1.0, 0.3160377) - tmp3.xyz;
                tmp3.xyz = tmp4.xyz * float3(0.31, 0.31, 0.31) + tmp3.xyz;
                tmp4.xyz = inp.texcoord1.yyy * unity_WorldToLight._m01_m11_m21;
                tmp4.xyz = unity_WorldToLight._m00_m10_m20 * inp.texcoord1.xxx + tmp4.xyz;
                tmp4.xyz = unity_WorldToLight._m02_m12_m22 * inp.texcoord1.zzz + tmp4.xyz;
                tmp4.xyz = tmp4.xyz + unity_WorldToLight._m03_m13_m23;
                tmp1.w = unity_ProbeVolumeParams.x == 1.0;
                if (tmp1.w) {
                    tmp1.w = unity_ProbeVolumeParams.y == 1.0;
                    tmp5.xyz = inp.texcoord1.yyy * unity_ProbeVolumeWorldToObject._m01_m11_m21;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m00_m10_m20 * inp.texcoord1.xxx + tmp5.xyz;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m02_m12_m22 * inp.texcoord1.zzz + tmp5.xyz;
                    tmp5.xyz = tmp5.xyz + unity_ProbeVolumeWorldToObject._m03_m13_m23;
                    tmp5.xyz = tmp1.www ? tmp5.xyz : inp.texcoord1.xyz;
                    tmp5.xyz = tmp5.xyz - unity_ProbeVolumeMin;
                    tmp5.yzw = tmp5.xyz * unity_ProbeVolumeSizeInv;
                    tmp1.w = tmp5.y * 0.25 + 0.75;
                    tmp2.w = unity_ProbeVolumeParams.z * 0.5 + 0.75;
                    tmp5.x = max(tmp1.w, tmp2.w);
                    tmp5 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp5.xzw);
                } else {
                    tmp5 = float4(1.0, 1.0, 1.0, 1.0);
                }
                tmp1.w = saturate(dot(tmp5, unity_OcclusionMaskSelector));
                tmp2.w = dot(tmp4.xyz, tmp4.xyz);
                tmp4 = tex2D(_LightTexture0, tmp2.ww);
                tmp1.w = tmp1.w * tmp4.x;
                tmp4.xyz = tmp1.www * _LightColor0.xyz;
                tmp5.xyz = inp.texcoord.xyz * _TransNormalDistortion.xxx + tmp1.xyz;
                tmp1.w = saturate(dot(tmp2.xyz, -tmp5.xyz));
                tmp1.w = log(tmp1.w);
                tmp1.w = tmp1.w * _TransScattering;
                tmp1.w = exp(tmp1.w);
                tmp1.w = tmp1.w * _TransDirect;
                tmp5.xyz = tmp1.www * tmp4.xyz;
                tmp5.xyz = tmp5.xyz * float3(0.64, 0.64, 0.64);
                tmp5.xyz = tmp3.xyz * tmp5.xyz;
                tmp1.w = dot(inp.texcoord.xyz, inp.texcoord.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp6.xyz = tmp1.www * inp.texcoord.xyz;
                tmp7.xyz = tmp3.xyz - float3(0.2209163, 0.2209163, 0.2209163);
                tmp7.xyz = tmp7.xyz * float3(1.01, 1.01, 1.01) + float3(0.2209163, 0.2209163, 0.2209163);
                tmp3.xyz = tmp3.xyz * float3(-0.0077908, -0.0077908, -0.0077908);
                tmp0.xyz = tmp0.xyz * tmp0.www + tmp2.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = max(tmp0.w, 0.001);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp0.w = dot(tmp6.xyz, tmp2.xyz);
                tmp1.w = saturate(dot(tmp6.xyz, tmp1.xyz));
                tmp2.x = saturate(dot(tmp6.xyz, tmp0.xyz));
                tmp0.x = saturate(dot(tmp1.xyz, tmp0.xyz));
                tmp0.y = tmp0.x * tmp0.x;
                tmp0.y = tmp0.y * 0.72 + -0.5;
                tmp0.z = 1.0 - tmp1.w;
                tmp1.x = tmp0.z * tmp0.z;
                tmp1.x = tmp1.x * tmp1.x;
                tmp0.z = tmp0.z * tmp1.x;
                tmp0.z = tmp0.y * tmp0.z + 1.0;
                tmp1.x = 1.0 - abs(tmp0.w);
                tmp1.y = tmp1.x * tmp1.x;
                tmp1.y = tmp1.y * tmp1.y;
                tmp1.x = tmp1.x * tmp1.y;
                tmp0.y = tmp0.y * tmp1.x + 1.0;
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.z = abs(tmp0.w) * 0.8704 + 0.1296;
                tmp1.x = tmp1.w * 0.8704 + 0.1296;
                tmp0.w = abs(tmp0.w) * tmp1.x;
                tmp0.z = tmp1.w * tmp0.z + tmp0.w;
                tmp0.z = tmp0.z + 0.00001;
                tmp0.w = tmp2.x * tmp2.x;
                tmp0.w = tmp0.w * -0.9832038 + 1.0;
                tmp0.w = tmp0.w * tmp0.w + 0.0000001;
                tmp0.zw = float2(0.5, 0.0053464) / tmp0.zw;
                tmp0.z = tmp0.w * tmp0.z;
                tmp0.z = tmp0.z * 3.141593;
                tmp0.z = max(tmp0.z, 0.0001);
                tmp0.z = sqrt(tmp0.z);
                tmp0.yz = tmp1.ww * tmp0.yz;
                tmp0.w = dot(tmp7.xyz, tmp7.xyz);
                tmp0.w = tmp0.w != 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.z = tmp0.w * tmp0.z;
                tmp1.xyz = tmp0.yyy * tmp4.xyz;
                tmp0.yzw = tmp4.xyz * tmp0.zzz;
                tmp0.x = 1.0 - tmp0.x;
                tmp1.w = tmp0.x * tmp0.x;
                tmp1.w = tmp1.w * tmp1.w;
                tmp0.x = tmp0.x * tmp1.w;
                tmp2.xyz = float3(1.0, 1.0, 1.0) - tmp7.xyz;
                tmp2.xyz = tmp2.xyz * tmp0.xxx + tmp7.xyz;
                tmp0.xyz = tmp0.yzw * tmp2.xyz;
                tmp0.xyz = tmp3.xyz * tmp1.xyz + tmp0.xyz;
                o.sv_target.xyz = tmp5.xyz * _Translucency.xxx + tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "ShadowCaster"
			Tags { "LIGHTMODE" = "SHADOWCASTER" "QUEUE" = "Geometry+0" "RenderType" = "Opaque" "SHADOWSUPPORT" = "true" }
			GpuProgramID 233863
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float3 texcoord1 : TEXCOORD1;
				float3 texcoord2 : TEXCOORD2;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			
			// Keywords: SHADOWS_DEPTH UNITY_PASS_SHADOWCASTER
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp0.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp0.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp1 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp1 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp1;
                tmp1 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp1;
                tmp1 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp1;
                tmp2.xyz = -tmp1.xyz * _WorldSpaceLightPos0.www + _WorldSpaceLightPos0.xyz;
                tmp0.w = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp2.xyz;
                tmp0.w = dot(tmp0.xyz, tmp2.xyz);
                tmp0.w = -tmp0.w * tmp0.w + 1.0;
                tmp0.w = sqrt(tmp0.w);
                tmp0.w = tmp0.w * unity_LightShadowBias.z;
                tmp2.xyz = -tmp0.xyz * tmp0.www + tmp1.xyz;
                o.texcoord2.xyz = tmp0.xyz;
                tmp0.x = unity_LightShadowBias.z != 0.0;
                tmp0.xyz = tmp0.xxx ? tmp2.xyz : tmp1.xyz;
                tmp2 = tmp0.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp2 = unity_MatrixVP._m00_m10_m20_m30 * tmp0.xxxx + tmp2;
                tmp0 = unity_MatrixVP._m02_m12_m22_m32 * tmp0.zzzz + tmp2;
                tmp0 = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp0;
                tmp1.x = unity_LightShadowBias.x / tmp0.w;
                tmp1.x = min(tmp1.x, 0.0);
                tmp1.x = max(tmp1.x, -1.0);
                tmp0.z = tmp0.z + tmp1.x;
                tmp1.x = min(tmp0.w, tmp0.z);
                o.position.xyw = tmp0.xyw;
                tmp0.x = tmp1.x - tmp0.z;
                o.position.z = unity_LightShadowBias.y * tmp0.x + tmp0.z;
                tmp0.xyz = v.vertex.yyy * unity_ObjectToWorld._m01_m11_m21;
                tmp0.xyz = unity_ObjectToWorld._m00_m10_m20 * v.vertex.xxx + tmp0.xyz;
                tmp0.xyz = unity_ObjectToWorld._m02_m12_m22 * v.vertex.zzz + tmp0.xyz;
                o.texcoord1.xyz = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp0.xyz;
                return o;
			}
			// Keywords: SHADOWS_DEPTH UNITY_PASS_SHADOWCASTER
			fout frag(v2f inp)
			{
                fout o;
                o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			ENDCG
		}
	}
	Fallback "Diffuse"
	CustomEditor "ASEMaterialInspector"
}