Shader "TextMeshPro/Mobile/Bitmap" {
	Properties {
		_MainTex ("Font Atlas", 2D) = "white" {}
		[HDR] _Color ("Text Color", Vector) = (1,1,1,1)
		_DiffusePower ("Diffuse Power", Range(1, 4)) = 1
		_VertexOffsetX ("Vertex OffsetX", Float) = 0
		_VertexOffsetY ("Vertex OffsetY", Float) = 0
		_MaskSoftnessX ("Mask SoftnessX", Float) = 0
		_MaskSoftnessY ("Mask SoftnessY", Float) = 0
		_ClipRect ("Clip Rect", Vector) = (-32767,-32767,32767,32767)
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_CullMode ("Cull Mode", Float) = 0
		_ColorMask ("Color Mask", Float) = 15
	}
	SubShader {
		Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			ColorMask 0 -1
			ZWrite Off
			Cull Off
			Stencil {
				ReadMask 0
				WriteMask 0
				Comp Disabled
				Pass Keep
				Fail Keep
				ZFail Keep
			}
			Fog {
				Mode 0
			}
			GpuProgramID 3127
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 sv_position : SV_Position0;
				float4 color : COLOR0;
				float2 texcoord : TEXCOORD0;
				float4 texcoord2 : TEXCOORD2;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _Color;
			float _DiffusePower;
			float _VertexOffsetX;
			float _VertexOffsetY;
			float4 _ClipRect;
			float _MaskSoftnessX;
			float _MaskSoftnessY;
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
                float4 tmp1;
                float4 tmp2;
                tmp0.x = v.vertex.w * 0.5;
                tmp0.xy = tmp0.xx / _ScreenParams.xy;
                tmp0.zw = v.vertex.xy + float2(_VertexOffsetX.x, _VertexOffsetY.x);
                tmp0.xy = tmp0.xy + tmp0.zw;
                tmp1 = tmp0.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp1 = unity_ObjectToWorld._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp1;
                tmp1 = tmp1 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp2 = tmp1.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp2 = unity_MatrixVP._m00_m10_m20_m30 * tmp1.xxxx + tmp2;
                tmp2 = unity_MatrixVP._m02_m12_m22_m32 * tmp1.zzzz + tmp2;
                tmp1 = unity_MatrixVP._m03_m13_m23_m33 * tmp1.wwww + tmp2;
                tmp0.zw = tmp1.xy / tmp1.ww;
                tmp1.xy = _ScreenParams.xy * float2(0.5, 0.5);
                tmp0.zw = tmp0.zw * tmp1.xy;
                tmp0.zw = round(tmp0.zw);
                tmp0.zw = tmp0.zw / tmp1.xy;
                o.sv_position.xy = tmp1.ww * tmp0.zw;
                o.sv_position.zw = tmp1.zw;
                tmp0.zw = float2(_MaskSoftnessX.x, _MaskSoftnessY.x) * float2(0.25, 0.25) + tmp1.ww;
                o.texcoord2.zw = float2(0.25, 0.25) / tmp0.zw;
                tmp1 = v.color * _Color;
                o.color.xyz = tmp1.xyz * _DiffusePower.xxx;
                o.color.w = tmp1.w;
                o.texcoord.xy = v.texcoord.xy;
                tmp1 = max(_ClipRect, float4(-20000000000.0, -20000000000.0, -20000000000.0, -20000000000.0));
                tmp1 = min(tmp1, float4(20000000000.0, 20000000000.0, 20000000000.0, 20000000000.0));
                tmp0.xy = tmp0.xy * float2(2.0, 2.0) + -tmp1.xy;
                o.texcoord2.xy = tmp0.xy - tmp1.zw;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                o.sv_target.w = tmp0.w * inp.color.w;
                o.sv_target.xyz = inp.color.xyz;
                return o;
			}
			ENDCG
		}
	}
	SubShader {
		Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
		Pass {
			Tags { "IGNOREPROJECTOR" = "true" "QUEUE" = "Transparent" "RenderType" = "Transparent" }
			Blend SrcAlpha OneMinusSrcAlpha, SrcAlpha OneMinusSrcAlpha
			ZTest Always
			ZWrite Off
			Cull Off
			Fog {
				Mode 0
			}
			GpuProgramID 117148
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 color : COLOR0;
				float2 texcoord : TEXCOORD0;
				float4 position : SV_POSITION0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_ST;
			// $Globals ConstantBuffers for Fragment Shader
			float4 _Color;
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
                float4 tmp1;
                o.color = saturate(v.color);
                o.texcoord.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp0 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp1 = tmp0.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp1 = unity_MatrixVP._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_MatrixVP._m02_m12_m22_m32 * tmp0.zzzz + tmp1;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp0.wwww + tmp1;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                o.sv_target.w = tmp0.w * _Color.w;
                o.sv_target.xyz = inp.color.xyz * _Color.xyz;
                return o;
			}
			ENDCG
		}
	}
	CustomEditor "TMPro.EditorUtilities.TMP_BitmapShaderGUI"
}