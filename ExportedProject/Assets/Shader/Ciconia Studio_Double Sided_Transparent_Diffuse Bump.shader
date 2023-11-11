Shader "Ciconia Studio/Double Sided/Transparent/Diffuse Bump" {
	Properties {
		_Diffusecolor ("Diffuse color", Vector) = (1,1,1,1)
		_MainTex ("Diffuse Map (Trans A)", 2D) = "white" {}
		_Speccolor ("Spec color", Vector) = (1,1,1,1)
		_SpecGlossMap ("Specular Map", 2D) = "white" {}
		_SpecIntensity ("Spec Intensity", Range(0, 2)) = 0.2
		_Gloss ("Gloss", Range(0, 1)) = 0.5
		_BumpMap ("Normal Map", 2D) = "bump" {}
		_NormalIntensity ("Normal Intensity", Range(0, 2)) = 1
		_Transparency ("Transparency", Range(0, 1)) = 0.5
		[HideInInspector] _Cutoff ("Alpha cutoff", Range(0, 1)) = 0.5
	}
	SubShader {
		Tags { "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			Name "FORWARD"
			Tags { "LIGHTMODE" = "FORWARDBASE" "QUEUE" = "Transparent" "RenderType" = "Transparent" "SHADOWSUPPORT" = "true" }
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			Cull Off
			GpuProgramID 54143
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float3 texcoord4 : TEXCOORD4;
				float3 texcoord5 : TEXCOORD5;
				float3 texcoord6 : TEXCOORD6;
				float4 texcoord10 : TEXCOORD10;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float4 _MainTex_ST;
			float4 _Diffusecolor;
			float4 _BumpMap_ST;
			float _NormalIntensity;
			float4 _SpecGlossMap_ST;
			float4 _Speccolor;
			float _SpecIntensity;
			float _Gloss;
			float _Transparency;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _BumpMap;
			sampler2D _SpecGlossMap;
			sampler2D _MainTex;
			
			// Keywords: DIRECTIONAL DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF
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
                o.texcoord3 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp0;
                tmp0 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp0 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp0;
                tmp0 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp0;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp0;
                o.texcoord.xy = v.texcoord.xy;
                o.texcoord1.xy = v.texcoord1.xy;
                o.texcoord2.xy = v.texcoord2.xy;
                tmp0.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp0.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp0.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                o.texcoord4.xyz = tmp0.xyz;
                tmp1.xyz = v.tangent.yyy * unity_ObjectToWorld._m01_m11_m21;
                tmp1.xyz = unity_ObjectToWorld._m00_m10_m20 * v.tangent.xxx + tmp1.xyz;
                tmp1.xyz = unity_ObjectToWorld._m02_m12_m22 * v.tangent.zzz + tmp1.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp1.xyz;
                o.texcoord5.xyz = tmp1.xyz;
                tmp2.xyz = tmp0.zxy * tmp1.yzx;
                tmp0.xyz = tmp0.yzx * tmp1.zxy + -tmp2.xyz;
                tmp0.xyz = tmp0.xyz * v.tangent.www;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                o.texcoord6.xyz = tmp0.www * tmp0.xyz;
                o.texcoord10 = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			// Keywords: DIRECTIONAL DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF
			fout frag(v2f inp, float facing: VFACE)
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
                tmp0.x = facing.x ? 1.0 : -1.0;
                tmp0.y = dot(inp.texcoord4.xyz, inp.texcoord4.xyz);
                tmp0.y = rsqrt(tmp0.y);
                tmp0.yzw = tmp0.yyy * inp.texcoord4.xyz;
                tmp0.xyz = tmp0.xxx * tmp0.yzw;
                tmp1.xyz = _WorldSpaceCameraPos - inp.texcoord3.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp1.xyz;
                tmp3.xy = inp.texcoord.xy * _BumpMap_ST.xy + _BumpMap_ST.zw;
                tmp3 = tex2D(_BumpMap, tmp3.xy);
                tmp3.x = tmp3.w * tmp3.x;
                tmp4.xy = tmp3.xy + tmp3.xy;
                tmp3.xy = tmp3.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp1.w = dot(tmp3.xy, tmp3.xy);
                tmp1.w = min(tmp1.w, 1.0);
                tmp1.w = 1.0 - tmp1.w;
                tmp4.z = sqrt(tmp1.w);
                tmp3.xyz = tmp4.xyz - float3(1.0, 1.0, 1.0);
                tmp3.xyz = _NormalIntensity.xxx * tmp3.xyz + float3(0.0, 0.0, 1.0);
                tmp4.xyz = tmp3.yyy * inp.texcoord6.xyz;
                tmp3.xyw = tmp3.xxx * inp.texcoord5.xyz + tmp4.xyz;
                tmp0.xyz = tmp3.zzz * tmp0.xyz + tmp3.xyw;
                tmp1.w = dot(tmp0.xyz, tmp0.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp0.xyz = tmp0.xyz * tmp1.www;
                tmp1.w = dot(-tmp2.xyz, tmp0.xyz);
                tmp1.w = tmp1.w + tmp1.w;
                tmp2.xyz = tmp0.xyz * -tmp1.www + -tmp2.xyz;
                tmp1.w = dot(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp3.xyz = tmp1.www * _WorldSpaceLightPos0.xyz;
                tmp1.xyz = tmp1.xyz * tmp0.www + tmp3.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp1.xyz;
                tmp0.w = _Gloss * 10.0 + 1.0;
                tmp0.w = exp(tmp0.w);
                tmp4.xy = -float2(_Gloss.x, _Transparency.x) + float2(1.0, 1.0);
                tmp1.w = unity_SpecCube0_ProbePosition.w > 0.0;
                if (tmp1.w) {
                    tmp1.w = dot(tmp2.xyz, tmp2.xyz);
                    tmp1.w = rsqrt(tmp1.w);
                    tmp5.xyz = tmp1.www * tmp2.xyz;
                    tmp6.xyz = unity_SpecCube0_BoxMax.xyz - inp.texcoord3.xyz;
                    tmp6.xyz = tmp6.xyz / tmp5.xyz;
                    tmp7.xyz = unity_SpecCube0_BoxMin.xyz - inp.texcoord3.xyz;
                    tmp7.xyz = tmp7.xyz / tmp5.xyz;
                    tmp8.xyz = tmp5.xyz > float3(0.0, 0.0, 0.0);
                    tmp6.xyz = tmp8.xyz ? tmp6.xyz : tmp7.xyz;
                    tmp1.w = min(tmp6.y, tmp6.x);
                    tmp1.w = min(tmp6.z, tmp1.w);
                    tmp6.xyz = inp.texcoord3.xyz - unity_SpecCube0_ProbePosition.xyz;
                    tmp5.xyz = tmp5.xyz * tmp1.www + tmp6.xyz;
                } else {
                    tmp5.xyz = tmp2.xyz;
                }
                tmp1.w = -tmp4.x * 0.7 + 1.7;
                tmp1.w = tmp1.w * tmp4.x;
                tmp1.w = tmp1.w * 6.0;
                tmp5 = UNITY_SAMPLE_TEXCUBE_SAMPLER(unity_SpecCube0, unity_SpecCube0, float4(tmp5.xyz, tmp1.w));
                tmp2.w = tmp5.w - 1.0;
                tmp2.w = unity_SpecCube0_HDR.w * tmp2.w + 1.0;
                tmp2.w = tmp2.w * unity_SpecCube0_HDR.x;
                tmp4.xzw = tmp5.xyz * tmp2.www;
                tmp3.w = unity_SpecCube0_BoxMin.w < 0.99999;
                if (tmp3.w) {
                    tmp3.w = unity_SpecCube1_ProbePosition.w > 0.0;
                    if (tmp3.w) {
                        tmp3.w = dot(tmp2.xyz, tmp2.xyz);
                        tmp3.w = rsqrt(tmp3.w);
                        tmp6.xyz = tmp2.xyz * tmp3.www;
                        tmp7.xyz = unity_SpecCube1_BoxMax.xyz - inp.texcoord3.xyz;
                        tmp7.xyz = tmp7.xyz / tmp6.xyz;
                        tmp8.xyz = unity_SpecCube1_BoxMin.xyz - inp.texcoord3.xyz;
                        tmp8.xyz = tmp8.xyz / tmp6.xyz;
                        tmp9.xyz = tmp6.xyz > float3(0.0, 0.0, 0.0);
                        tmp7.xyz = tmp9.xyz ? tmp7.xyz : tmp8.xyz;
                        tmp3.w = min(tmp7.y, tmp7.x);
                        tmp3.w = min(tmp7.z, tmp3.w);
                        tmp7.xyz = inp.texcoord3.xyz - unity_SpecCube1_ProbePosition.xyz;
                        tmp2.xyz = tmp6.xyz * tmp3.www + tmp7.xyz;
                    }
                    tmp6 = UNITY_SAMPLE_TEXCUBE_SAMPLER(unity_SpecCube0, unity_SpecCube0, float4(tmp2.xyz, tmp1.w));
                    tmp1.w = tmp6.w - 1.0;
                    tmp1.w = unity_SpecCube1_HDR.w * tmp1.w + 1.0;
                    tmp1.w = tmp1.w * unity_SpecCube1_HDR.x;
                    tmp2.xyz = tmp6.xyz * tmp1.www;
                    tmp5.xyz = tmp2.www * tmp5.xyz + -tmp2.xyz;
                    tmp4.xzw = unity_SpecCube0_BoxMin.www * tmp5.xyz + tmp2.xyz;
                }
                tmp2.xy = inp.texcoord.xy * _SpecGlossMap_ST.xy + _SpecGlossMap_ST.zw;
                tmp2 = tex2D(_SpecGlossMap, tmp2.xy);
                tmp2.xyz = tmp2.xyz * _SpecIntensity.xxx;
                tmp2.xyz = tmp2.xyz * _Speccolor.xyz;
                tmp1.w = max(tmp2.y, tmp2.x);
                tmp1.w = max(tmp2.z, tmp1.w);
                tmp2.w = tmp0.w + 8.0;
                tmp2.w = tmp2.w * 0.0397887;
                tmp1.x = dot(tmp1.xyz, tmp0.xyz);
                tmp1.x = max(tmp1.x, 0.0);
                tmp1.x = log(tmp1.x);
                tmp0.w = tmp0.w * tmp1.x;
                tmp0.w = exp(tmp0.w);
                tmp1.xyz = tmp0.www * _LightColor0.xyz;
                tmp1.xyz = tmp2.www * tmp1.xyz;
                tmp4.xzw = tmp2.xyz * tmp4.xzw;
                tmp1.xyz = tmp1.xyz * tmp2.xyz + tmp4.xzw;
                tmp0.x = dot(tmp0.xyz, tmp3.xyz);
                tmp0.x = max(tmp0.x, 0.0);
                tmp0.xyz = tmp0.xxx * _LightColor0.xyz;
                tmp2.xy = inp.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp2 = tex2D(_MainTex, tmp2.xy);
                tmp2.xyz = tmp2.xyz * _Diffusecolor.xyz;
                tmp0.w = 1.0 - tmp1.w;
                tmp2.xyz = tmp0.www * tmp2.xyz;
                o.sv_target.xyz = tmp0.xyz * tmp2.xyz + tmp1.xyz;
                o.sv_target.w = tmp4.y * tmp2.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "FORWARD_DELTA"
			Tags { "LIGHTMODE" = "FORWARDADD" "QUEUE" = "Transparent" "RenderType" = "Transparent" "SHADOWSUPPORT" = "true" }
			Blend One One, One One
			Cull Off
			GpuProgramID 75167
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float3 texcoord4 : TEXCOORD4;
				float3 texcoord5 : TEXCOORD5;
				float3 texcoord6 : TEXCOORD6;
				float3 texcoord7 : TEXCOORD7;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4x4 unity_WorldToLight;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float4 _MainTex_ST;
			float4 _Diffusecolor;
			float4 _BumpMap_ST;
			float _NormalIntensity;
			float4 _SpecGlossMap_ST;
			float4 _Speccolor;
			float _SpecIntensity;
			float _Gloss;
			float _Transparency;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _BumpMap;
			sampler2D _LightTexture0;
			sampler2D _SpecGlossMap;
			sampler2D _MainTex;
			
			// Keywords: DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF POINT
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp1 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp0 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp0;
                tmp2 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp2 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp2;
                tmp2 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp2;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp2;
                o.texcoord.xy = v.texcoord.xy;
                o.texcoord1.xy = v.texcoord1.xy;
                o.texcoord2.xy = v.texcoord2.xy;
                o.texcoord3 = tmp0;
                tmp1.x = dot(v.normal.xyz, unity_WorldToObject._m00_m10_m20);
                tmp1.y = dot(v.normal.xyz, unity_WorldToObject._m01_m11_m21);
                tmp1.z = dot(v.normal.xyz, unity_WorldToObject._m02_m12_m22);
                tmp1.w = dot(tmp1.xyz, tmp1.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp1.xyz = tmp1.www * tmp1.xyz;
                o.texcoord4.xyz = tmp1.xyz;
                tmp2.xyz = v.tangent.yyy * unity_ObjectToWorld._m01_m11_m21;
                tmp2.xyz = unity_ObjectToWorld._m00_m10_m20 * v.tangent.xxx + tmp2.xyz;
                tmp2.xyz = unity_ObjectToWorld._m02_m12_m22 * v.tangent.zzz + tmp2.xyz;
                tmp1.w = dot(tmp2.xyz, tmp2.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp2.xyz = tmp1.www * tmp2.xyz;
                o.texcoord5.xyz = tmp2.xyz;
                tmp3.xyz = tmp1.zxy * tmp2.yzx;
                tmp1.xyz = tmp1.yzx * tmp2.zxy + -tmp3.xyz;
                tmp1.xyz = tmp1.xyz * v.tangent.www;
                tmp1.w = dot(tmp1.xyz, tmp1.xyz);
                tmp1.w = rsqrt(tmp1.w);
                o.texcoord6.xyz = tmp1.www * tmp1.xyz;
                tmp1.xyz = tmp0.yyy * unity_WorldToLight._m01_m11_m21;
                tmp1.xyz = unity_WorldToLight._m00_m10_m20 * tmp0.xxx + tmp1.xyz;
                tmp0.xyz = unity_WorldToLight._m02_m12_m22 * tmp0.zzz + tmp1.xyz;
                o.texcoord7.xyz = unity_WorldToLight._m03_m13_m23 * tmp0.www + tmp0.xyz;
                return o;
			}
			// Keywords: DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF POINT
			fout frag(v2f inp, float facing: VFACE)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0.xy = inp.texcoord.xy * _BumpMap_ST.xy + _BumpMap_ST.zw;
                tmp0 = tex2D(_BumpMap, tmp0.xy);
                tmp0.x = tmp0.w * tmp0.x;
                tmp0.zw = tmp0.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp1.xy = tmp0.xy + tmp0.xy;
                tmp0.x = dot(tmp0.xy, tmp0.xy);
                tmp0.x = min(tmp0.x, 1.0);
                tmp0.x = 1.0 - tmp0.x;
                tmp1.z = sqrt(tmp0.x);
                tmp0.xyz = tmp1.xyz - float3(1.0, 1.0, 1.0);
                tmp0.xyz = _NormalIntensity.xxx * tmp0.xyz + float3(0.0, 0.0, 1.0);
                tmp1.xyz = tmp0.yyy * inp.texcoord6.xyz;
                tmp0.xyw = tmp0.xxx * inp.texcoord5.xyz + tmp1.xyz;
                tmp1.x = dot(inp.texcoord4.xyz, inp.texcoord4.xyz);
                tmp1.x = rsqrt(tmp1.x);
                tmp1.xyz = tmp1.xxx * inp.texcoord4.xyz;
                tmp1.w = facing.x ? 1.0 : -1.0;
                tmp1.xyz = tmp1.www * tmp1.xyz;
                tmp0.xyz = tmp0.zzz * tmp1.xyz + tmp0.xyw;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp1.xyz = _WorldSpaceLightPos0.www * -inp.texcoord3.xyz + _WorldSpaceLightPos0.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp1.xyz;
                tmp2.xyz = _WorldSpaceCameraPos - inp.texcoord3.xyz;
                tmp0.w = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp2.xyz * tmp0.www + tmp1.xyz;
                tmp0.w = dot(tmp0.xyz, tmp1.xyz);
                tmp1.x = dot(tmp2.xyz, tmp2.xyz);
                tmp1.x = rsqrt(tmp1.x);
                tmp1.xyz = tmp1.xxx * tmp2.xyz;
                tmp0.x = dot(tmp1.xyz, tmp0.xyz);
                tmp0.xw = max(tmp0.xw, float2(0.0, 0.0));
                tmp0.x = log(tmp0.x);
                tmp0.y = _Gloss * 10.0 + 1.0;
                tmp0.y = exp(tmp0.y);
                tmp0.x = tmp0.x * tmp0.y;
                tmp0.y = tmp0.y + 8.0;
                tmp0.y = tmp0.y * 0.0397887;
                tmp0.x = exp(tmp0.x);
                tmp0.z = dot(inp.texcoord7.xyz, inp.texcoord7.xyz);
                tmp1 = tex2D(_LightTexture0, tmp0.zz);
                tmp1.xyz = tmp1.xxx * _LightColor0.xyz;
                tmp2.xyz = tmp0.xxx * tmp1.xyz;
                tmp0.xzw = tmp0.www * tmp1.xyz;
                tmp1.xyz = tmp0.yyy * tmp2.xyz;
                tmp2.xy = inp.texcoord.xy * _SpecGlossMap_ST.xy + _SpecGlossMap_ST.zw;
                tmp2 = tex2D(_SpecGlossMap, tmp2.xy);
                tmp2.xyz = tmp2.xyz * _SpecIntensity.xxx;
                tmp2.xyz = tmp2.xyz * _Speccolor.xyz;
                tmp1.xyz = tmp1.xyz * tmp2.xyz;
                tmp0.y = max(tmp2.y, tmp2.x);
                tmp0.y = max(tmp2.z, tmp0.y);
                tmp0.y = 1.0 - tmp0.y;
                tmp2.xy = inp.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp2 = tex2D(_MainTex, tmp2.xy);
                tmp2.xyz = tmp2.xyz * _Diffusecolor.xyz;
                tmp2.xyz = tmp0.yyy * tmp2.xyz;
                tmp0.xyz = tmp0.xzw * tmp2.xyz + tmp1.xyz;
                tmp0.w = 1.0 - _Transparency;
                tmp0.w = tmp0.w * tmp2.w;
                o.sv_target.xyz = tmp0.www * tmp0.xyz;
                o.sv_target.w = 0.0;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "ShadowCaster"
			Tags { "LIGHTMODE" = "SHADOWCASTER" "QUEUE" = "Transparent" "RenderType" = "Transparent" "SHADOWSUPPORT" = "true" }
			Cull Off
			Offset 1, 1
			GpuProgramID 193926
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
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
			
			// Keywords: DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF SHADOWS_DEPTH
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp1 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                o.texcoord3 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp0;
                tmp0 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp0 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp0;
                tmp0 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp0;
                tmp0 = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp0;
                tmp1.x = unity_LightShadowBias.x / tmp0.w;
                tmp1.x = min(tmp1.x, 0.0);
                tmp1.x = max(tmp1.x, -1.0);
                tmp0.z = tmp0.z + tmp1.x;
                tmp1.x = min(tmp0.w, tmp0.z);
                o.position.xyw = tmp0.xyw;
                tmp0.x = tmp1.x - tmp0.z;
                o.position.z = unity_LightShadowBias.y * tmp0.x + tmp0.z;
                o.texcoord1.xy = v.texcoord1.xy;
                o.texcoord2.xy = v.texcoord2.xy;
                return o;
			}
			// Keywords: DIRLIGHTMAP_OFF DYNAMICLIGHTMAP_OFF LIGHTMAP_OFF SHADOWS_DEPTH
			fout frag(v2f inp, float facing: VFACE)
			{
                fout o;
                o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			ENDCG
		}
	}
	Fallback "Diffuse"
}