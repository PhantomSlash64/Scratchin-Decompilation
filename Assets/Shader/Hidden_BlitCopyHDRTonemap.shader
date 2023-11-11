Shader "Hidden/BlitCopyHDRTonemap" {
	Properties {
		_MainTex ("Texture", any) = "" {}
		_NitsForPaperWhite ("NitsForPaperWhite", Float) = 160
		_ColorGamut ("ColorGamut", Float) = 0
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 57251
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_ST;
			// $Globals ConstantBuffers for Fragment Shader
			float _NitsForPaperWhite;
			int _ColorGamut;
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
                tmp0 = v.vertex.yyyy * unity_ObjectToWorld._m01_m11_m21_m31;
                tmp0 = unity_ObjectToWorld._m00_m10_m20_m30 * v.vertex.xxxx + tmp0;
                tmp0 = unity_ObjectToWorld._m02_m12_m22_m32 * v.vertex.zzzz + tmp0;
                tmp0 = tmp0 + unity_ObjectToWorld._m03_m13_m23_m33;
                tmp1 = tmp0.yyyy * unity_MatrixVP._m01_m11_m21_m31;
                tmp1 = unity_MatrixVP._m00_m10_m20_m30 * tmp0.xxxx + tmp1;
                tmp1 = unity_MatrixVP._m02_m12_m22_m32 * tmp0.zzzz + tmp1;
                o.position = unity_MatrixVP._m03_m13_m23_m33 * tmp0.wwww + tmp1;
                o.texcoord.xy = v.texcoord.xy * _MainTex_ST.xy + _MainTex_ST.zw;
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
                tmp0.x = _NitsForPaperWhite * 0.0001;
                tmp1 = tex2D(_MainTex, inp.texcoord.xy);
                tmp0.yzw = tmp1.xyz + float3(0.055, 0.055, 0.055);
                tmp0.yzw = tmp0.yzw * float3(0.9478673, 0.9478673, 0.9478673);
                tmp0.yzw = log(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(2.4, 2.4, 2.4);
                tmp0.yzw = exp(tmp0.yzw);
                tmp2.xyz = log(tmp1.xyz);
                tmp2.xyz = tmp2.xyz * float3(2.2, 2.2, 2.2);
                tmp2.xyz = exp(tmp2.xyz);
                tmp3.xyz = tmp1.xyz < float3(1.0, 1.0, 1.0);
                tmp0.yzw = tmp3.xyz ? tmp0.yzw : tmp2.xyz;
                tmp2.xyz = tmp1.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp1.xyz = tmp1.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                o.sv_target.w = tmp1.w;
                tmp0.yzw = tmp2.xyz ? tmp1.xyz : tmp0.yzw;
                tmp1.x = dot(float3(0.627402, 0.329292, 0.043306), tmp0.xyz);
                tmp1.y = dot(float3(0.069095, 0.919544, 0.01136), tmp0.xyz);
                tmp1.z = dot(float3(0.016394, 0.088028, 0.895578), tmp0.xyz);
                tmp1.xyz = tmp0.xxx * tmp1.xyz;
                tmp1.xyz = log(abs(tmp1.xyz));
                tmp1.xyz = tmp1.xyz * float3(0.1593018, 0.1593018, 0.1593018);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp1.xyz * float3(18.85156, 18.85156, 18.85156) + float3(0.8359375, 0.8359375, 0.8359375);
                tmp1.xyz = tmp1.xyz * float3(18.6875, 18.6875, 18.6875) + float3(1.0, 1.0, 1.0);
                tmp1.xyz = tmp2.xyz / tmp1.xyz;
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(78.84375, 78.84375, 78.84375);
                tmp1.xyz = exp(tmp1.xyz);
                tmp0.x = _ColorGamut == 4;
                tmp1.xyz = tmp0.xxx ? tmp1.xyz : tmp0.yzw;
                tmp2.xyz = log(abs(tmp0.yzw));
                tmp2.xyz = tmp2.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp2.xyz = exp(tmp2.xyz);
                tmp2.xyz = tmp2.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp3.xyz = tmp0.yzw < float3(0.0031308, 0.0031308, 0.0031308);
                tmp0.xyz = tmp0.yzw * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp3.xyz ? tmp0.xyz : tmp2.xyz;
                o.sv_target.xyz = _ColorGamut.xxx ? tmp1.xyz : tmp0.xyz;
                return o;
			}
			ENDCG
		}
	}
}