Shader "TextMeshPro/Distance Field (Surface)" {
	Properties {
		_FaceTex ("Fill Texture", 2D) = "white" {}
		_FaceUVSpeedX ("Face UV Speed X", Range(-5, 5)) = 0
		_FaceUVSpeedY ("Face UV Speed Y", Range(-5, 5)) = 0
		[HDR] _FaceColor ("Fill Color", Vector) = (1,1,1,1)
		_FaceDilate ("Face Dilate", Range(-1, 1)) = 0
		[HDR] _OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_OutlineTex ("Outline Texture", 2D) = "white" {}
		_OutlineUVSpeedX ("Outline UV Speed X", Range(-5, 5)) = 0
		_OutlineUVSpeedY ("Outline UV Speed Y", Range(-5, 5)) = 0
		_OutlineWidth ("Outline Thickness", Range(0, 1)) = 0
		_OutlineSoftness ("Outline Softness", Range(0, 1)) = 0
		_Bevel ("Bevel", Range(0, 1)) = 0.5
		_BevelOffset ("Bevel Offset", Range(-0.5, 0.5)) = 0
		_BevelWidth ("Bevel Width", Range(-0.5, 0.5)) = 0
		_BevelClamp ("Bevel Clamp", Range(0, 1)) = 0
		_BevelRoundness ("Bevel Roundness", Range(0, 1)) = 0
		_BumpMap ("Normalmap", 2D) = "bump" {}
		_BumpOutline ("Bump Outline", Range(0, 1)) = 0.5
		_BumpFace ("Bump Face", Range(0, 1)) = 0.5
		_ReflectFaceColor ("Face Color", Vector) = (0,0,0,1)
		_ReflectOutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_Cube ("Reflection Cubemap", Cube) = "black" {}
		_EnvMatrixRotation ("Texture Rotation", Vector) = (0,0,0,0)
		[HDR] _SpecColor ("Specular Color", Vector) = (0,0,0,1)
		_FaceShininess ("Face Shininess", Range(0, 1)) = 0
		_OutlineShininess ("Outline Shininess", Range(0, 1)) = 0
		[HDR] _GlowColor ("Color", Vector) = (0,1,0,0.5)
		_GlowOffset ("Offset", Range(-1, 1)) = 0
		_GlowInner ("Inner", Range(0, 1)) = 0.05
		_GlowOuter ("Outer", Range(0, 1)) = 0.05
		_GlowPower ("Falloff", Range(1, 0)) = 0.75
		_WeightNormal ("Weight Normal", Float) = 0
		_WeightBold ("Weight Bold", Float) = 0.5
		_ShaderFlags ("Flags", Float) = 0
		_ScaleRatioA ("Scale RatioA", Float) = 1
		_ScaleRatioB ("Scale RatioB", Float) = 1
		_ScaleRatioC ("Scale RatioC", Float) = 1
		_MainTex ("Font Atlas", 2D) = "white" {}
		_TextureWidth ("Texture Width", Float) = 512
		_TextureHeight ("Texture Height", Float) = 512
		_GradientScale ("Gradient Scale", Float) = 5
		_ScaleX ("Scale X", Float) = 1
		_ScaleY ("Scale Y", Float) = 1
		_PerspectiveFilter ("Perspective Correction", Range(0, 1)) = 0.875
		_Sharpness ("Sharpness", Range(-1, 1)) = 0
		_VertexOffsetX ("Vertex OffsetX", Float) = 0
		_VertexOffsetY ("Vertex OffsetY", Float) = 0
		_CullMode ("Cull Mode", Float) = 0
	}
	SubShader {
		LOD 300
		Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			Name "FORWARD"
			LOD 300
			Tags { "IGNOREPROJECTOR" = "true" "LIGHTMODE" = "FORWARDBASE" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			ColorMask RGB -1
			ZWrite Off
			Cull Off
			GpuProgramID 35615
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float4 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord5 : TEXCOORD5;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float4 texcoord4 : TEXCOORD4;
				float4 color : COLOR0;
				float3 texcoord6 : TEXCOORD6;
				float3 texcoord7 : TEXCOORD7;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4x4 _EnvMatrix;
			float _FaceDilate;
			float _WeightNormal;
			float _WeightBold;
			float _ScaleRatioA;
			float _VertexOffsetX;
			float _VertexOffsetY;
			float _GradientScale;
			float _ScaleX;
			float _ScaleY;
			float _PerspectiveFilter;
			float _Sharpness;
			float4 _MainTex_ST;
			float4 _FaceTex_ST;
			float4 _OutlineTex_ST;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float4 _SpecColor;
			float _FaceUVSpeedX;
			float _FaceUVSpeedY;
			float4 _FaceColor;
			float _OutlineSoftness;
			float _OutlineUVSpeedX;
			float _OutlineUVSpeedY;
			float4 _OutlineColor;
			float _OutlineWidth;
			float _Bevel;
			float _BevelOffset;
			float _BevelWidth;
			float _BevelClamp;
			float _BevelRoundness;
			float _BumpOutline;
			float _BumpFace;
			float4 _ReflectFaceColor;
			float4 _ReflectOutlineColor;
			float _ShaderFlags;
			float _TextureWidth;
			float _TextureHeight;
			float _FaceShininess;
			float _OutlineShininess;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _FaceTex;
			sampler2D _OutlineTex;
			sampler2D _BumpMap;
			samplerCUBE _Cube;
			
			// Keywords: DIRECTIONAL
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                tmp0.xy = v.vertex.xy + float2(_VertexOffsetX.x, _VertexOffsetY.x);
                tmp1 = tmp0.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp1 = unity_ObjectToWorld._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp1;
                tmp2 = tmp1 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp1.xyz = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp1.xyz;
                tmp3 = tmp2.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp3 = unity_MatrixVP._m00_m10_m20_m30 * tmp2.xxxx + tmp3;
                tmp3 = unity_MatrixVP._m02_m12_m22_m32 * tmp2.zzzz + tmp3;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp2.wwww + tmp3;
                tmp0.w = v.texcoord1.x * 0.0002441;
                tmp3.x = floor(tmp0.w);
                tmp3.y = -tmp3.x * 4096.0 + v.texcoord1.x;
                tmp3.xy = tmp3.xy * float2(0.0019531, 0.0019531);
                o.texcoord.zw = tmp3.xy * _FaceTex_ST.xy + _FaceTex_ST.zw;
                o.texcoord1.xy = tmp3.xy * _OutlineTex_ST.xy + _OutlineTex_ST.zw;
                o.texcoord.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp0.w = v.texcoord1.y <= 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp1.w = _WeightBold - _WeightNormal;
                tmp0.w = tmp0.w * tmp1.w + _WeightNormal;
                tmp0.w = tmp0.w * 0.25 + _FaceDilate;
                tmp0.w = tmp0.w * _ScaleRatioA;
                o.texcoord5.x = tmp0.w * 0.5;
                tmp0.w = tmp2.y * unity_MatrixVP._m31;
                tmp0.w = unity_MatrixVP._m30 * tmp2.x + tmp0.w;
                tmp0.w = unity_MatrixVP._m32 * tmp2.z + tmp0.w;
                tmp0.w = unity_MatrixVP._m33 * tmp2.w + tmp0.w;
                tmp2.xy = _ScreenParams.yy * glstate_matrix_projection._m01_m11;
                tmp2.xy = glstate_matrix_projection._m00_m10 * _ScreenParams.xx + tmp2.xy;
                tmp2.xy = tmp2.xy * float2(_ScaleX.x, _ScaleY.x);
                tmp2.xy = tmp0.ww / tmp2.xy;
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.w = abs(v.texcoord1.y) * _GradientScale;
                tmp2.x = _Sharpness + 1.0;
                tmp1.w = tmp1.w * tmp2.x;
                tmp2.x = tmp0.w * tmp1.w;
                tmp2.y = 1.0 - _PerspectiveFilter;
                tmp2.x = tmp2.y * tmp2.x;
                tmp0.w = tmp0.w * tmp1.w + -tmp2.x;
                tmp2.yzw = _WorldSpaceCameraPos * unity_WorldToObject._m01_m11_m21;
                tmp2.yzw = unity_WorldToObject._m00_m10_m20 * _WorldSpaceCameraPos + tmp2.yzw;
                tmp2.yzw = unity_WorldToObject._m02_m12_m22 * _WorldSpaceCameraPos + tmp2.yzw;
                tmp2.yzw = tmp2.yzw + unity_WorldToObject._m03_m13_m23;
                tmp0.z = v.vertex.z;
                tmp0.xyz = tmp2.yzw - tmp0.xyz;
                tmp0.x = dot(v.normal.xyz, tmp0.xyz);
                tmp0.y = tmp0.x > 0.0;
                tmp0.x = tmp0.x < 0.0;
                tmp0.x = tmp0.x - tmp0.y;
                tmp0.x = floor(tmp0.x);
                tmp0.xyz = tmp0.xxx * v.normal.xyz;
                tmp3.x = dot(tmp0.xyz, unity_WorldToObject._m00_m10_m20);
                tmp3.y = dot(tmp0.xyz, unity_WorldToObject._m01_m11_m21);
                tmp3.z = dot(tmp0.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.x = dot(tmp3.xyz, tmp3.xyz);
                tmp0.x = rsqrt(tmp0.x);
                tmp3 = tmp0.xxxx * tmp3.xyzz;
                tmp0.xyz = _WorldSpaceCameraPos - tmp1.xyz;
                tmp1.w = dot(tmp0.xyz, tmp0.xyz);
                tmp1.w = rsqrt(tmp1.w);
                tmp2.yzw = tmp0.xyz * tmp1.www;
                tmp1.w = dot(tmp3.xyz, tmp2.xyz);
                o.texcoord5.y = abs(tmp1.w) * tmp0.w + tmp2.x;
                o.texcoord2.w = tmp1.x;
                tmp2.xyz = v.tangent.yyy * unity_ObjectToWorld._m11_m21_m01;
                tmp2.xyz = unity_ObjectToWorld._m10_m20_m00 * v.tangent.xxx + tmp2.xyz;
                tmp2.xyz = unity_ObjectToWorld._m12_m22_m02 * v.tangent.zzz + tmp2.xyz;
                tmp0.w = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp2.xyz;
                tmp4.xyz = tmp2.xyz * tmp3.wxy;
                tmp4.xyz = tmp3.ywx * tmp2.yzx + -tmp4.xyz;
                tmp0.w = v.tangent.w * unity_WorldTransformParams.w;
                tmp4.xyz = tmp0.www * tmp4.xyz;
                o.texcoord2.y = tmp4.x;
                o.texcoord2.z = tmp3.x;
                o.texcoord2.x = tmp2.z;
                o.texcoord3.x = tmp2.x;
                o.texcoord4.x = tmp2.y;
                o.texcoord3.w = tmp1.y;
                o.texcoord4.w = tmp1.z;
                o.texcoord3.z = tmp3.y;
                o.texcoord3.y = tmp4.y;
                o.texcoord4.y = tmp4.z;
                o.texcoord4.z = tmp3.w;
                o.color = v.color;
                tmp1.xyz = tmp0.yyy * _EnvMatrix._m01_m11_m21;
                tmp0.xyw = _EnvMatrix._m00_m10_m20 * tmp0.xxx + tmp1.xyz;
                o.texcoord6.xyz = _EnvMatrix._m02_m12_m22 * tmp0.zzz + tmp0.xyw;
                tmp0.x = tmp3.y * tmp3.y;
                tmp0.x = tmp3.x * tmp3.x + -tmp0.x;
                tmp1 = tmp3.ywzx * tmp3;
                tmp2.x = dot(unity_SHBr, tmp1);
                tmp2.y = dot(unity_SHBg, tmp1);
                tmp2.z = dot(unity_SHBb, tmp1);
                o.texcoord7.xyz = unity_SHC.xyz * tmp0.xxx + tmp2.xyz;
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
                tmp0.y = inp.texcoord2.w;
                tmp0.z = inp.texcoord3.w;
                tmp0.w = inp.texcoord4.w;
                tmp1.xyz = _WorldSpaceCameraPos - tmp0.yzw;
                tmp0.x = dot(tmp1.xyz, tmp1.xyz);
                tmp0.x = rsqrt(tmp0.x);
                tmp2 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1.w = 0.5 - tmp2.w;
                tmp1.w = tmp1.w - inp.texcoord5.x;
                tmp1.w = tmp1.w * inp.texcoord5.y + 0.5;
                tmp2.x = _OutlineWidth * _ScaleRatioA;
                tmp2.y = _OutlineSoftness * _ScaleRatioA;
                tmp2.xz = tmp2.xy * inp.texcoord5.yy;
                tmp3 = inp.color * _FaceColor;
                tmp2.w = inp.color.w * _OutlineColor.w;
                tmp4.xy = float2(_FaceUVSpeedX.x, _FaceUVSpeedY.x) * _Time.yy + inp.texcoord.zw;
                tmp4 = tex2D(_FaceTex, tmp4.xy);
                tmp3 = tmp3 * tmp4;
                tmp4.xy = float2(_OutlineUVSpeedX.x, _OutlineUVSpeedY.x) * _Time.yy + inp.texcoord1.xy;
                tmp4 = tex2D(_OutlineTex, tmp4.xy);
                tmp4.xyz = tmp4.xyz * _OutlineColor.xyz;
                tmp5.w = tmp2.w * tmp4.w;
                tmp2.w = -tmp2.x * 0.5 + tmp1.w;
                tmp2.z = tmp2.z * 0.5 + tmp2.w;
                tmp2.y = tmp2.y * inp.texcoord5.y + 1.0;
                tmp2.y = saturate(tmp2.z / tmp2.y);
                tmp2.y = 1.0 - tmp2.y;
                tmp1.w = saturate(tmp2.x * 0.5 + tmp1.w);
                tmp2.x = min(tmp2.x, 1.0);
                tmp2.x = sqrt(tmp2.x);
                tmp2.x = tmp1.w * tmp2.x;
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp5.xyz = tmp4.xyz * tmp5.www;
                tmp4 = tmp5 - tmp3;
                tmp3 = tmp2.xxxx * tmp4 + tmp3;
                tmp2 = tmp2.yyyy * tmp3;
                tmp3.x = max(tmp2.w, 0.0001);
                tmp2.xyz = tmp2.xyz / tmp3.xxx;
                tmp3.xy = float2(1.0, 1.0) / float2(_TextureWidth.x, _TextureHeight.x);
                tmp3.z = 0.0;
                tmp4 = inp.texcoord.xyxy - tmp3.xzzy;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp3 = tmp3.xzzy + inp.texcoord.xyxy;
                tmp6 = tex2D(_MainTex, tmp3.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp3 = tex2D(_MainTex, tmp3.zw);
                tmp4.x = _ShaderFlags * 0.5;
                tmp4.y = tmp4.x >= -tmp4.x;
                tmp4.x = frac(abs(tmp4.x));
                tmp4.x = tmp4.y ? tmp4.x : -tmp4.x;
                tmp4.x = tmp4.x >= 0.5;
                tmp4.y = inp.texcoord5.x + _BevelOffset;
                tmp3.x = tmp5.w;
                tmp3.y = tmp6.w;
                tmp3.z = tmp4.w;
                tmp3 = tmp4.yyyy + tmp3;
                tmp4.y = _BevelWidth + _OutlineWidth;
                tmp4.y = max(tmp4.y, 0.01);
                tmp3 = tmp3 - float4(0.5, 0.5, 0.5, 0.5);
                tmp3 = tmp3 / tmp4.yyyy;
                tmp3 = saturate(tmp3 + float4(0.5, 0.5, 0.5, 0.5));
                tmp5 = tmp3 * float4(2.0, 2.0, 2.0, 2.0) + float4(-1.0, -1.0, -1.0, -1.0);
                tmp5 = float4(1.0, 1.0, 1.0, 1.0) - abs(tmp5);
                tmp3 = tmp4.xxxx ? tmp5 : tmp3;
                tmp5 = tmp3 * float4(1.570796, 1.570796, 1.570796, 1.570796);
                tmp5 = sin(tmp5);
                tmp5 = tmp5 - tmp3;
                tmp3 = _BevelRoundness.xxxx * tmp5 + tmp3;
                tmp4.x = 1.0 - _BevelClamp;
                tmp3 = min(tmp3, tmp4.xxxx);
                tmp4.x = tmp4.y * _Bevel;
                tmp4.x = tmp4.x * _GradientScale;
                tmp4.x = tmp4.x * -2.0;
                tmp3.xz = tmp3.xz * tmp4.xx;
                tmp3.yz = tmp3.wy * tmp4.xx + -tmp3.zx;
                tmp3.xw = float2(-1.0, 1.0);
                tmp3.w = dot(tmp3.xy, tmp3.xy);
                tmp3.w = rsqrt(tmp3.w);
                tmp4.yz = tmp3.ww * float2(1.0, 0.0);
                tmp4.x = tmp3.w * tmp3.z;
                tmp3.w = dot(tmp3.xy, tmp3.xy);
                tmp3.w = rsqrt(tmp3.w);
                tmp3.z = 0.0;
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp5.xyz = tmp3.xyz * tmp4.xyz;
                tmp3.xyz = tmp4.zxy * tmp3.yzx + -tmp5.xyz;
                tmp4 = tex2D(_BumpMap, inp.texcoord.zw);
                tmp4.x = tmp4.w * tmp4.x;
                tmp4.xy = tmp4.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp3.w = dot(tmp4.xy, tmp4.xy);
                tmp3.w = min(tmp3.w, 1.0);
                tmp3.w = 1.0 - tmp3.w;
                tmp4.z = sqrt(tmp3.w);
                tmp3.w = _BumpOutline - _BumpFace;
                tmp3.w = tmp1.w * tmp3.w + _BumpFace;
                tmp4.xyz = tmp4.xyz * tmp3.www + float3(-0.0, -0.0, -1.0);
                tmp4.xyz = tmp2.www * tmp4.xyz + float3(0.0, 0.0, 1.0);
                tmp3.xyz = tmp3.xyz - tmp4.xyz;
                tmp3.w = dot(tmp3.xyz, tmp3.xyz);
                tmp3.w = rsqrt(tmp3.w);
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp4.xyz = tmp3.yyy * unity_ObjectToWorld._m01_m11_m21;
                tmp4.xyz = unity_ObjectToWorld._m00_m10_m20 * tmp3.xxx + tmp4.xyz;
                tmp4.xyz = unity_ObjectToWorld._m02_m12_m22 * tmp3.zzz + tmp4.xyz;
                tmp3.w = dot(inp.texcoord6.xyz, tmp4.xyz);
                tmp3.w = tmp3.w + tmp3.w;
                tmp4.xyz = tmp4.xyz * -tmp3.www + inp.texcoord6.xyz;
                tmp4 = texCUBE(_Cube, tmp4.xyz);
                tmp5.xyz = _ReflectOutlineColor.xyz - _ReflectFaceColor.xyz;
                tmp5.xyz = tmp1.www * tmp5.xyz + _ReflectFaceColor.xyz;
                tmp4.xyz = tmp4.xyz * tmp5.xyz;
                tmp3.w = _OutlineShininess - _FaceShininess;
                tmp1.w = tmp1.w * tmp3.w + _FaceShininess;
                tmp3.w = unity_ProbeVolumeParams.x == 1.0;
                if (tmp3.w) {
                    tmp4.w = unity_ProbeVolumeParams.y == 1.0;
                    tmp5.xyz = inp.texcoord3.www * unity_ProbeVolumeWorldToObject._m01_m11_m21;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m00_m10_m20 * inp.texcoord2.www + tmp5.xyz;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m02_m12_m22 * inp.texcoord4.www + tmp5.xyz;
                    tmp5.xyz = tmp5.xyz + unity_ProbeVolumeWorldToObject._m03_m13_m23;
                    tmp5.xyz = tmp4.www ? tmp5.xyz : tmp0.yzw;
                    tmp5.xyz = tmp5.xyz - unity_ProbeVolumeMin;
                    tmp5.yzw = tmp5.xyz * unity_ProbeVolumeSizeInv;
                    tmp4.w = tmp5.y * 0.25 + 0.75;
                    tmp5.y = unity_ProbeVolumeParams.z * 0.5 + 0.75;
                    tmp5.x = max(tmp4.w, tmp5.y);
                    tmp5 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp5.xzw);
                } else {
                    tmp5 = float4(1.0, 1.0, 1.0, 1.0);
                }
                tmp4.w = saturate(dot(tmp5, unity_OcclusionMaskSelector));
                tmp5.x = dot(inp.texcoord2.xyz, -tmp3.xyz);
                tmp5.y = dot(inp.texcoord3.xyz, -tmp3.xyz);
                tmp5.z = dot(inp.texcoord4.xyz, -tmp3.xyz);
                tmp3.x = dot(tmp5.xyz, tmp5.xyz);
                tmp3.x = rsqrt(tmp3.x);
                tmp5.xyz = tmp3.xxx * tmp5.xyz;
                tmp3.xyz = tmp4.www * _LightColor0.xyz;
                if (tmp3.w) {
                    tmp3.w = unity_ProbeVolumeParams.y == 1.0;
                    tmp6.xyz = inp.texcoord3.www * unity_ProbeVolumeWorldToObject._m01_m11_m21;
                    tmp6.xyz = unity_ProbeVolumeWorldToObject._m00_m10_m20 * inp.texcoord2.www + tmp6.xyz;
                    tmp6.xyz = unity_ProbeVolumeWorldToObject._m02_m12_m22 * inp.texcoord4.www + tmp6.xyz;
                    tmp6.xyz = tmp6.xyz + unity_ProbeVolumeWorldToObject._m03_m13_m23;
                    tmp0.yzw = tmp3.www ? tmp6.xyz : tmp0.yzw;
                    tmp0.yzw = tmp0.yzw - unity_ProbeVolumeMin;
                    tmp6.yzw = tmp0.yzw * unity_ProbeVolumeSizeInv;
                    tmp0.y = tmp6.y * 0.25;
                    tmp0.z = unity_ProbeVolumeParams.z * 0.5;
                    tmp0.w = -unity_ProbeVolumeParams.z * 0.5 + 0.25;
                    tmp0.y = max(tmp0.z, tmp0.y);
                    tmp6.x = min(tmp0.w, tmp0.y);
                    tmp7 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp6.xzw);
                    tmp0.yzw = tmp6.xzw + float3(0.25, 0.0, 0.0);
                    tmp8 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp0.yzw);
                    tmp0.yzw = tmp6.xzw + float3(0.5, 0.0, 0.0);
                    tmp6 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp0.yzw);
                    tmp5.w = 1.0;
                    tmp7.x = dot(tmp7, tmp5);
                    tmp7.y = dot(tmp8, tmp5);
                    tmp7.z = dot(tmp6, tmp5);
                } else {
                    tmp5.w = 1.0;
                    tmp7.x = dot(unity_SHAr, tmp5);
                    tmp7.y = dot(unity_SHAg, tmp5);
                    tmp7.z = dot(unity_SHAb, tmp5);
                }
                tmp0.yzw = tmp7.xyz + inp.texcoord7.xyz;
                tmp0.yzw = max(tmp0.yzw, float3(0.0, 0.0, 0.0));
                tmp0.yzw = log(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(0.4166667, 0.4166667, 0.4166667);
                tmp0.yzw = exp(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp0.yzw = max(tmp0.yzw, float3(0.0, 0.0, 0.0));
                tmp1.xyz = tmp1.xyz * tmp0.xxx + _WorldSpaceLightPos0.xyz;
                tmp0.x = dot(tmp1.xyz, tmp1.xyz);
                tmp0.x = rsqrt(tmp0.x);
                tmp1.xyz = tmp0.xxx * tmp1.xyz;
                tmp0.x = dot(tmp5.xyz, _WorldSpaceLightPos0.xyz);
                tmp0.x = max(tmp0.x, 0.0);
                tmp1.x = dot(tmp5.xyz, tmp1.xyz);
                tmp1.x = max(tmp1.x, 0.0);
                tmp1.y = tmp1.w * 128.0;
                tmp1.x = log(tmp1.x);
                tmp1.x = tmp1.x * tmp1.y;
                tmp1.x = exp(tmp1.x);
                tmp1.yzw = tmp2.xyz * tmp3.xyz;
                tmp3.xyz = tmp3.xyz * _SpecColor.xyz;
                tmp3.xyz = tmp1.xxx * tmp3.xyz;
                tmp1.xyz = tmp1.yzw * tmp0.xxx + tmp3.xyz;
                tmp0.xyz = tmp2.xyz * tmp0.yzw + tmp1.xyz;
                o.sv_target.xyz = tmp4.xyz * tmp2.www + tmp0.xyz;
                o.sv_target.w = tmp2.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "FORWARD"
			LOD 300
			Tags { "IGNOREPROJECTOR" = "true" "LIGHTMODE" = "FORWARDADD" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend SrcAlpha One, SrcAlpha One
			ColorMask RGB -1
			ZWrite Off
			Cull Off
			GpuProgramID 119582
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float4 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord6 : TEXCOORD6;
				float3 texcoord2 : TEXCOORD2;
				float3 texcoord3 : TEXCOORD3;
				float3 texcoord4 : TEXCOORD4;
				float3 texcoord5 : TEXCOORD5;
				float4 color : COLOR0;
				float3 texcoord7 : TEXCOORD7;
				float3 texcoord8 : TEXCOORD8;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4x4 unity_WorldToLight;
			float4x4 _EnvMatrix;
			float _FaceDilate;
			float _WeightNormal;
			float _WeightBold;
			float _ScaleRatioA;
			float _VertexOffsetX;
			float _VertexOffsetY;
			float _GradientScale;
			float _ScaleX;
			float _ScaleY;
			float _PerspectiveFilter;
			float _Sharpness;
			float4 _MainTex_ST;
			float4 _FaceTex_ST;
			float4 _OutlineTex_ST;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _LightColor0;
			float4 _SpecColor;
			float _FaceUVSpeedX;
			float _FaceUVSpeedY;
			float4 _FaceColor;
			float _OutlineSoftness;
			float _OutlineUVSpeedX;
			float _OutlineUVSpeedY;
			float4 _OutlineColor;
			float _OutlineWidth;
			float _Bevel;
			float _BevelOffset;
			float _BevelWidth;
			float _BevelClamp;
			float _BevelRoundness;
			float _BumpOutline;
			float _BumpFace;
			float _ShaderFlags;
			float _TextureWidth;
			float _TextureHeight;
			float _FaceShininess;
			float _OutlineShininess;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _FaceTex;
			sampler2D _OutlineTex;
			sampler2D _BumpMap;
			sampler2D _LightTexture0;
			
			// Keywords: POINT
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                tmp0.xy = v.vertex.xy + float2(_VertexOffsetX.x, _VertexOffsetY.x);
                tmp1 = tmp0.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp1 = unity_ObjectToWorld._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp1;
                tmp2 = tmp1 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp3 = tmp2.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp3 = unity_MatrixVP._m00_m10_m20_m30 * tmp2.xxxx + tmp3;
                tmp3 = unity_MatrixVP._m02_m12_m22_m32 * tmp2.zzzz + tmp3;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp2.wwww + tmp3;
                tmp0.w = v.texcoord1.x * 0.0002441;
                tmp3.x = floor(tmp0.w);
                tmp3.y = -tmp3.x * 4096.0 + v.texcoord1.x;
                tmp3.xy = tmp3.xy * float2(0.0019531, 0.0019531);
                o.texcoord.zw = tmp3.xy * _FaceTex_ST.xy + _FaceTex_ST.zw;
                o.texcoord1.xy = tmp3.xy * _OutlineTex_ST.xy + _OutlineTex_ST.zw;
                o.texcoord.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp0.w = tmp2.y * unity_MatrixVP._m31;
                tmp0.w = unity_MatrixVP._m30 * tmp2.x + tmp0.w;
                tmp0.w = unity_MatrixVP._m32 * tmp2.z + tmp0.w;
                tmp0.w = unity_MatrixVP._m33 * tmp2.w + tmp0.w;
                tmp2.xy = _ScreenParams.yy * glstate_matrix_projection._m01_m11;
                tmp2.xy = glstate_matrix_projection._m00_m10 * _ScreenParams.xx + tmp2.xy;
                tmp2.xy = tmp2.xy * float2(_ScaleX.x, _ScaleY.x);
                tmp2.xy = tmp0.ww / tmp2.xy;
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.x = abs(v.texcoord1.y) * _GradientScale;
                tmp2.y = _Sharpness + 1.0;
                tmp2.x = tmp2.y * tmp2.x;
                tmp2.y = tmp0.w * tmp2.x;
                tmp2.z = 1.0 - _PerspectiveFilter;
                tmp2.y = tmp2.z * tmp2.y;
                tmp0.w = tmp0.w * tmp2.x + -tmp2.y;
                tmp2.xzw = _WorldSpaceCameraPos * unity_WorldToObject._m01_m11_m21;
                tmp2.xzw = unity_WorldToObject._m00_m10_m20 * _WorldSpaceCameraPos + tmp2.xzw;
                tmp2.xzw = unity_WorldToObject._m02_m12_m22 * _WorldSpaceCameraPos + tmp2.xzw;
                tmp2.xzw = tmp2.xzw + unity_WorldToObject._m03_m13_m23;
                tmp0.z = v.vertex.z;
                tmp0.xyz = tmp2.xzw - tmp0.xyz;
                tmp0.x = dot(v.normal.xyz, tmp0.xyz);
                tmp0.y = tmp0.x > 0.0;
                tmp0.x = tmp0.x < 0.0;
                tmp0.x = tmp0.x - tmp0.y;
                tmp0.x = floor(tmp0.x);
                tmp0.xyz = tmp0.xxx * v.normal.xyz;
                tmp3.y = dot(tmp0.xyz, unity_WorldToObject._m00_m10_m20);
                tmp3.z = dot(tmp0.xyz, unity_WorldToObject._m01_m11_m21);
                tmp3.x = dot(tmp0.xyz, unity_WorldToObject._m02_m12_m22);
                tmp0.x = dot(tmp3.xyz, tmp3.xyz);
                tmp0.x = rsqrt(tmp0.x);
                tmp0.xyz = tmp0.xxx * tmp3.xyz;
                tmp2.xzw = unity_ObjectToWorld._m03_m13_m23 * v.vertex.www + tmp1.xyz;
                tmp1 = unity_ObjectToWorld._m03_m13_m23_m33 * v.vertex.wwww + tmp1;
                tmp3.xyz = _WorldSpaceCameraPos - tmp2.xzw;
                o.texcoord5.xyz = tmp2.xzw;
                tmp2.x = dot(tmp3.xyz, tmp3.xyz);
                tmp2.x = rsqrt(tmp2.x);
                tmp2.xzw = tmp2.xxx * tmp3.xyz;
                tmp2.x = dot(tmp0.xyz, tmp2.xyz);
                o.texcoord6.y = abs(tmp2.x) * tmp0.w + tmp2.y;
                tmp0.w = v.texcoord1.y <= 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp2.x = _WeightBold - _WeightNormal;
                tmp0.w = tmp0.w * tmp2.x + _WeightNormal;
                tmp0.w = tmp0.w * 0.25 + _FaceDilate;
                tmp0.w = tmp0.w * _ScaleRatioA;
                o.texcoord6.x = tmp0.w * 0.5;
                o.texcoord2.z = tmp0.y;
                tmp2.xyz = v.tangent.yyy * unity_ObjectToWorld._m11_m21_m01;
                tmp2.xyz = unity_ObjectToWorld._m10_m20_m00 * v.tangent.xxx + tmp2.xyz;
                tmp2.xyz = unity_ObjectToWorld._m12_m22_m02 * v.tangent.zzz + tmp2.xyz;
                tmp0.w = dot(tmp2.xyz, tmp2.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2.xyz = tmp0.www * tmp2.xyz;
                tmp4.xyz = tmp0.xyz * tmp2.xyz;
                tmp4.xyz = tmp0.zxy * tmp2.yzx + -tmp4.xyz;
                tmp0.y = v.tangent.w * unity_WorldTransformParams.w;
                tmp4.xyz = tmp0.yyy * tmp4.xyz;
                o.texcoord2.y = tmp4.x;
                o.texcoord2.x = tmp2.z;
                o.texcoord3.z = tmp0.z;
                o.texcoord4.z = tmp0.x;
                o.texcoord3.x = tmp2.x;
                o.texcoord4.x = tmp2.y;
                o.texcoord3.y = tmp4.y;
                o.texcoord4.y = tmp4.z;
                o.color = v.color;
                tmp0.xyz = tmp3.yyy * _EnvMatrix._m01_m11_m21;
                tmp0.xyz = _EnvMatrix._m00_m10_m20 * tmp3.xxx + tmp0.xyz;
                o.texcoord7.xyz = _EnvMatrix._m02_m12_m22 * tmp3.zzz + tmp0.xyz;
                tmp0.xyz = tmp1.yyy * unity_WorldToLight._m01_m11_m21;
                tmp0.xyz = unity_WorldToLight._m00_m10_m20 * tmp1.xxx + tmp0.xyz;
                tmp0.xyz = unity_WorldToLight._m02_m12_m22 * tmp1.zzz + tmp0.xyz;
                o.texcoord8.xyz = unity_WorldToLight._m03_m13_m23 * tmp1.www + tmp0.xyz;
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
                tmp0.xyz = _WorldSpaceLightPos0.xyz - inp.texcoord5.xyz;
                tmp0.w = dot(tmp0.xyz, tmp0.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp0.xyz = tmp0.www * tmp0.xyz;
                tmp1.xyz = _WorldSpaceCameraPos - inp.texcoord5.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp2 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1.w = 0.5 - tmp2.w;
                tmp1.w = tmp1.w - inp.texcoord6.x;
                tmp1.w = tmp1.w * inp.texcoord6.y + 0.5;
                tmp2.x = _OutlineWidth * _ScaleRatioA;
                tmp2.y = _OutlineSoftness * _ScaleRatioA;
                tmp2.xz = tmp2.xy * inp.texcoord6.yy;
                tmp3 = inp.color * _FaceColor;
                tmp2.w = inp.color.w * _OutlineColor.w;
                tmp4.xy = float2(_FaceUVSpeedX.x, _FaceUVSpeedY.x) * _Time.yy + inp.texcoord.zw;
                tmp4 = tex2D(_FaceTex, tmp4.xy);
                tmp3 = tmp3 * tmp4;
                tmp4.xy = float2(_OutlineUVSpeedX.x, _OutlineUVSpeedY.x) * _Time.yy + inp.texcoord1.xy;
                tmp4 = tex2D(_OutlineTex, tmp4.xy);
                tmp4.xyz = tmp4.xyz * _OutlineColor.xyz;
                tmp5.w = tmp2.w * tmp4.w;
                tmp2.w = -tmp2.x * 0.5 + tmp1.w;
                tmp2.z = tmp2.z * 0.5 + tmp2.w;
                tmp2.y = tmp2.y * inp.texcoord6.y + 1.0;
                tmp2.y = saturate(tmp2.z / tmp2.y);
                tmp2.y = 1.0 - tmp2.y;
                tmp1.w = saturate(tmp2.x * 0.5 + tmp1.w);
                tmp2.x = min(tmp2.x, 1.0);
                tmp2.x = sqrt(tmp2.x);
                tmp2.x = tmp1.w * tmp2.x;
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp5.xyz = tmp4.xyz * tmp5.www;
                tmp4 = tmp5 - tmp3;
                tmp3 = tmp2.xxxx * tmp4 + tmp3;
                tmp2 = tmp2.yyyy * tmp3;
                tmp3.x = max(tmp2.w, 0.0001);
                tmp2.xyz = tmp2.xyz / tmp3.xxx;
                tmp3.xy = float2(1.0, 1.0) / float2(_TextureWidth.x, _TextureHeight.x);
                tmp3.z = 0.0;
                tmp4 = inp.texcoord.xyxy - tmp3.xzzy;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp3 = tmp3.xzzy + inp.texcoord.xyxy;
                tmp6 = tex2D(_MainTex, tmp3.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp3 = tex2D(_MainTex, tmp3.zw);
                tmp4.x = _ShaderFlags * 0.5;
                tmp4.y = tmp4.x >= -tmp4.x;
                tmp4.x = frac(abs(tmp4.x));
                tmp4.x = tmp4.y ? tmp4.x : -tmp4.x;
                tmp4.x = tmp4.x >= 0.5;
                tmp4.y = inp.texcoord6.x + _BevelOffset;
                tmp3.x = tmp5.w;
                tmp3.y = tmp6.w;
                tmp3.z = tmp4.w;
                tmp3 = tmp4.yyyy + tmp3;
                tmp4.y = _BevelWidth + _OutlineWidth;
                tmp4.y = max(tmp4.y, 0.01);
                tmp3 = tmp3 - float4(0.5, 0.5, 0.5, 0.5);
                tmp3 = tmp3 / tmp4.yyyy;
                tmp3 = saturate(tmp3 + float4(0.5, 0.5, 0.5, 0.5));
                tmp5 = tmp3 * float4(2.0, 2.0, 2.0, 2.0) + float4(-1.0, -1.0, -1.0, -1.0);
                tmp5 = float4(1.0, 1.0, 1.0, 1.0) - abs(tmp5);
                tmp3 = tmp4.xxxx ? tmp5 : tmp3;
                tmp5 = tmp3 * float4(1.570796, 1.570796, 1.570796, 1.570796);
                tmp5 = sin(tmp5);
                tmp5 = tmp5 - tmp3;
                tmp3 = _BevelRoundness.xxxx * tmp5 + tmp3;
                tmp4.x = 1.0 - _BevelClamp;
                tmp3 = min(tmp3, tmp4.xxxx);
                tmp4.x = tmp4.y * _Bevel;
                tmp4.x = tmp4.x * _GradientScale;
                tmp4.x = tmp4.x * -2.0;
                tmp3.xz = tmp3.xz * tmp4.xx;
                tmp3.yz = tmp3.wy * tmp4.xx + -tmp3.zx;
                tmp3.xw = float2(-1.0, 1.0);
                tmp3.w = dot(tmp3.xy, tmp3.xy);
                tmp3.w = rsqrt(tmp3.w);
                tmp4.yz = tmp3.ww * float2(1.0, 0.0);
                tmp4.x = tmp3.w * tmp3.z;
                tmp3.w = dot(tmp3.xy, tmp3.xy);
                tmp3.w = rsqrt(tmp3.w);
                tmp3.z = 0.0;
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp5.xyz = tmp3.xyz * tmp4.xyz;
                tmp3.xyz = tmp4.zxy * tmp3.yzx + -tmp5.xyz;
                tmp4 = tex2D(_BumpMap, inp.texcoord.zw);
                tmp4.x = tmp4.w * tmp4.x;
                tmp4.xy = tmp4.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp3.w = dot(tmp4.xy, tmp4.xy);
                tmp3.w = min(tmp3.w, 1.0);
                tmp3.w = 1.0 - tmp3.w;
                tmp4.z = sqrt(tmp3.w);
                tmp3.w = _BumpOutline - _BumpFace;
                tmp3.w = tmp1.w * tmp3.w + _BumpFace;
                tmp4.xyz = tmp4.xyz * tmp3.www + float3(-0.0, -0.0, -1.0);
                tmp4.xyz = tmp2.www * tmp4.xyz + float3(0.0, 0.0, 1.0);
                tmp3.xyz = tmp3.xyz - tmp4.xyz;
                tmp3.w = dot(tmp3.xyz, tmp3.xyz);
                tmp3.w = rsqrt(tmp3.w);
                tmp3.xyz = tmp3.www * tmp3.xyz;
                tmp3.w = _OutlineShininess - _FaceShininess;
                tmp1.w = tmp1.w * tmp3.w + _FaceShininess;
                tmp4.xyz = inp.texcoord5.yyy * unity_WorldToLight._m01_m11_m21;
                tmp4.xyz = unity_WorldToLight._m00_m10_m20 * inp.texcoord5.xxx + tmp4.xyz;
                tmp4.xyz = unity_WorldToLight._m02_m12_m22 * inp.texcoord5.zzz + tmp4.xyz;
                tmp4.xyz = tmp4.xyz + unity_WorldToLight._m03_m13_m23;
                tmp3.w = unity_ProbeVolumeParams.x == 1.0;
                if (tmp3.w) {
                    tmp3.w = unity_ProbeVolumeParams.y == 1.0;
                    tmp5.xyz = inp.texcoord5.yyy * unity_ProbeVolumeWorldToObject._m01_m11_m21;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m00_m10_m20 * inp.texcoord5.xxx + tmp5.xyz;
                    tmp5.xyz = unity_ProbeVolumeWorldToObject._m02_m12_m22 * inp.texcoord5.zzz + tmp5.xyz;
                    tmp5.xyz = tmp5.xyz + unity_ProbeVolumeWorldToObject._m03_m13_m23;
                    tmp5.xyz = tmp3.www ? tmp5.xyz : inp.texcoord5.xyz;
                    tmp5.xyz = tmp5.xyz - unity_ProbeVolumeMin;
                    tmp5.yzw = tmp5.xyz * unity_ProbeVolumeSizeInv;
                    tmp3.w = tmp5.y * 0.25 + 0.75;
                    tmp4.w = unity_ProbeVolumeParams.z * 0.5 + 0.75;
                    tmp5.x = max(tmp3.w, tmp4.w);
                    tmp5 = UNITY_SAMPLE_TEX3D_SAMPLER(unity_ProbeVolumeSH, unity_ProbeVolumeSH, tmp5.xzw);
                } else {
                    tmp5 = float4(1.0, 1.0, 1.0, 1.0);
                }
                tmp3.w = saturate(dot(tmp5, unity_OcclusionMaskSelector));
                tmp4.x = dot(tmp4.xyz, tmp4.xyz);
                tmp4 = tex2D(_LightTexture0, tmp4.xx);
                tmp3.w = tmp3.w * tmp4.x;
                tmp4.x = dot(inp.texcoord2.xyz, -tmp3.xyz);
                tmp4.y = dot(inp.texcoord3.xyz, -tmp3.xyz);
                tmp4.z = dot(inp.texcoord4.xyz, -tmp3.xyz);
                tmp3.x = dot(tmp4.xyz, tmp4.xyz);
                tmp3.x = rsqrt(tmp3.x);
                tmp3.xyz = tmp3.xxx * tmp4.xyz;
                tmp4.xyz = tmp3.www * _LightColor0.xyz;
                tmp1.xyz = tmp1.xyz * tmp0.www + tmp0.xyz;
                tmp0.w = dot(tmp1.xyz, tmp1.xyz);
                tmp0.w = rsqrt(tmp0.w);
                tmp1.xyz = tmp0.www * tmp1.xyz;
                tmp0.x = dot(tmp3.xyz, tmp0.xyz);
                tmp0.y = dot(tmp3.xyz, tmp1.xyz);
                tmp0.xy = max(tmp0.xy, float2(0.0, 0.0));
                tmp0.z = tmp1.w * 128.0;
                tmp0.y = log(tmp0.y);
                tmp0.y = tmp0.y * tmp0.z;
                tmp0.y = exp(tmp0.y);
                tmp1.xyz = tmp2.xyz * tmp4.xyz;
                tmp2.xyz = tmp4.xyz * _SpecColor.xyz;
                tmp0.yzw = tmp0.yyy * tmp2.xyz;
                o.sv_target.xyz = tmp1.xyz * tmp0.xxx + tmp0.yzw;
                o.sv_target.w = tmp2.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Caster"
			LOD 300
			Tags { "IGNOREPROJECTOR" = "true" "LIGHTMODE" = "SHADOWCASTER" "QUEUE" = "Transparent" "RenderType" = "Transparent" "SHADOWSUPPORT" = "true" }
			ColorMask RGB -1
			Cull Off
			Offset 1, 1
			Fog {
				Mode 0
			}
			GpuProgramID 145332
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord1 : TEXCOORD1;
				float2 texcoord3 : TEXCOORD3;
				float texcoord2 : TEXCOORD2;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_ST;
			float4 _OutlineTex_ST;
			float _OutlineWidth;
			float _FaceDilate;
			float _ScaleRatioA;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			
			// Keywords: SHADOWS_DEPTH
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp0 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp1 = tmp0.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp1 = unity_MatrixVP._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_MatrixVP._m02_m12_m22_m32 * tmp0.zzzz + tmp1;
                tmp0 = unity_MatrixVP._m03_m13_m23_m33 * tmp0.wwww + tmp1;
                tmp1.x = unity_LightShadowBias.x / tmp0.w;
                tmp1.x = min(tmp1.x, 0.0);
                tmp1.x = max(tmp1.x, -1.0);
                tmp0.z = tmp0.z + tmp1.x;
                tmp1.x = min(tmp0.w, tmp0.z);
                o.position.xyw = tmp0.xyw;
                tmp0.x = tmp1.x - tmp0.z;
                o.position.z = unity_LightShadowBias.y * tmp0.x + tmp0.z;
                o.texcoord1.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                o.texcoord3.xy = v.texcoord.xy * _OutlineTex_ST.xy + _OutlineTex_ST.zw;
                tmp0.x = -_OutlineWidth * _ScaleRatioA + 1.0;
                tmp0.x = -_FaceDilate * _ScaleRatioA + tmp0.x;
                o.texcoord2.x = tmp0.x * 0.5;
                return o;
			}
			// Keywords: SHADOWS_DEPTH
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = tmp0.w - inp.texcoord2.x;
                tmp0.x = tmp0.x < 0.0;
                if (tmp0.x) {
                    discard;
                }
                o.sv_target = float4(0.0, 0.0, 0.0, 0.0);
                return o;
			}
			ENDCG
		}
	}
	CustomEditor "TMPro.EditorUtilities.TMP_SDFShaderGUI"
}