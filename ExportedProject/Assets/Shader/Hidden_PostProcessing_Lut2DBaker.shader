Shader "Hidden/PostProcessing/Lut2DBaker" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 57050
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
			float4 _Lut2D_Params;
			float3 _ColorBalance;
			float3 _ColorFilter;
			float3 _HueSatCon;
			float _Brightness;
			float3 _ChannelMixerRed;
			float3 _ChannelMixerGreen;
			float3 _ChannelMixerBlue;
			float3 _Lift;
			float3 _InvGamma;
			float3 _Gain;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _Curves;
			
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
                tmp0.yz = inp.texcoord1.xy - _Lut2D_Params.yz;
                tmp1.x = tmp0.y * _Lut2D_Params.x;
                tmp0.x = frac(tmp1.x);
                tmp1.x = tmp0.x / _Lut2D_Params.x;
                tmp0.w = tmp0.y - tmp1.x;
                tmp0.xyz = tmp0.xzw * _Lut2D_Params.www;
                tmp0.xyz = tmp0.xyz * _Brightness.xxx + float3(-0.2176376, -0.2176376, -0.2176376);
                tmp0.xyz = tmp0.xyz * _HueSatCon + float3(0.2176376, 0.2176376, 0.2176376);
                tmp1.x = dot(float3(0.390405, 0.549941, 0.0089263), tmp0.xyz);
                tmp1.y = dot(float3(0.0708416, 0.963172, 0.0013578), tmp0.xyz);
                tmp1.z = dot(float3(0.0231082, 0.128021, 0.936245), tmp0.xyz);
                tmp0.xyz = tmp1.xyz * _ColorBalance;
                tmp1.x = dot(float3(2.85847, -1.62879, -0.024891), tmp0.xyz);
                tmp1.y = dot(float3(-0.210182, 1.1582, 0.0003243), tmp0.xyz);
                tmp1.z = dot(float3(-0.041812, -0.118169, 1.06867), tmp0.xyz);
                tmp0.xyz = tmp1.xyz * _ColorFilter;
                tmp1.x = dot(tmp0.xyz, _ChannelMixerRed);
                tmp1.y = dot(tmp0.xyz, _ChannelMixerGreen);
                tmp1.z = dot(tmp0.xyz, _ChannelMixerBlue);
                tmp0.xyz = tmp1.xyz * _Gain + _Lift;
                tmp1.xyz = log(abs(tmp0.xyz));
                tmp0.xyz = saturate(tmp0.xyz * float3(340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0) + float3(0.5, 0.5, 0.5));
                tmp0.xyz = tmp0.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.xyz = tmp1.xyz * _InvGamma;
                tmp1.xyz = exp(tmp1.xyz);
                tmp0.xyz = tmp0.xyz * tmp1.xyz;
                tmp0.xyz = max(tmp0.xyz, float3(0.0, 0.0, 0.0));
                tmp0.w = tmp0.y >= tmp0.z;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp1.xy = tmp0.zy;
                tmp2.xy = tmp0.yz - tmp1.xy;
                tmp1.zw = float2(-1.0, 0.6666667);
                tmp2.zw = float2(1.0, -1.0);
                tmp1 = tmp0.wwww * tmp2.xywz + tmp1.xywz;
                tmp0.w = tmp0.x >= tmp1.x;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp2.z = tmp1.w;
                tmp1.w = tmp0.x;
                tmp3.x = dot(tmp0.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp2.xyw = tmp1.wyx;
                tmp2 = tmp2 - tmp1;
                tmp0 = tmp0.wwww * tmp2 + tmp1;
                tmp1.x = min(tmp0.y, tmp0.w);
                tmp1.x = tmp0.x - tmp1.x;
                tmp1.y = tmp1.x * 6.0 + 0.0001;
                tmp0.y = tmp0.w - tmp0.y;
                tmp0.y = tmp0.y / tmp1.y;
                tmp0.y = tmp0.y + tmp0.z;
                tmp2.x = abs(tmp0.y);
                tmp3.z = tmp2.x + _HueSatCon.x;
                tmp3.yw = float2(0.25, 0.25);
                tmp4 = tex2Dlod(_Curves, float4(tmp3.zw, 0, 0.0));
                tmp5 = tex2Dlod(_Curves, float4(tmp3.xy, 0, 0.0));
                tmp5.x = saturate(tmp5.x);
                tmp4.x = saturate(tmp4.x);
                tmp0.y = tmp3.z + tmp4.x;
                tmp0.yzw = tmp0.yyy + float3(-0.5, 0.5, -1.5);
                tmp1.y = tmp0.y > 1.0;
                tmp0.w = tmp1.y ? tmp0.w : tmp0.y;
                tmp0.y = tmp0.y < 0.0;
                tmp0.y = tmp0.y ? tmp0.z : tmp0.w;
                tmp0.yzw = tmp0.yyy + float3(1.0, 0.6666667, 0.3333333);
                tmp0.yzw = frac(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(6.0, 6.0, 6.0) + float3(-3.0, -3.0, -3.0);
                tmp0.yzw = saturate(abs(tmp0.yzw) - float3(1.0, 1.0, 1.0));
                tmp0.yzw = tmp0.yzw - float3(1.0, 1.0, 1.0);
                tmp1.y = tmp0.x + 0.0001;
                tmp2.z = tmp1.x / tmp1.y;
                tmp0.yzw = tmp2.zzz * tmp0.yzw + float3(1.0, 1.0, 1.0);
                tmp1.xyz = tmp0.yzw * tmp0.xxx;
                tmp1.x = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.xyz = tmp0.xxx * tmp0.yzw + -tmp1.xxx;
                tmp2.yw = float2(0.25, 0.25);
                tmp3 = tex2Dlod(_Curves, float4(tmp2.xy, 0, 0.0));
                tmp2 = tex2Dlod(_Curves, float4(tmp2.zw, 0, 0.0));
                tmp2.x = saturate(tmp2.x);
                tmp3.x = saturate(tmp3.x);
                tmp0.w = tmp3.x + tmp3.x;
                tmp0.w = dot(tmp2.xy, tmp0.xy);
                tmp0.w = tmp0.w * tmp5.x;
                tmp0.w = dot(_HueSatCon.xy, tmp0.xy);
                tmp0.xyz = saturate(tmp0.www * tmp0.xyz + tmp1.xxx);
                tmp0.xyz = tmp0.xyz + float3(0.0039063, 0.0039063, 0.0039063);
                tmp0.w = 0.75;
                tmp1 = tex2D(_Curves, tmp0.xw);
                tmp1.x = saturate(tmp1.x);
                tmp2 = tex2D(_Curves, tmp0.yw);
                tmp0 = tex2D(_Curves, tmp0.zw);
                tmp1.z = saturate(tmp0.w);
                tmp1.y = saturate(tmp2.w);
                tmp0.xyz = tmp1.xyz + float3(0.0039063, 0.0039063, 0.0039063);
                tmp0.w = 0.75;
                tmp1 = tex2D(_Curves, tmp0.xw);
                o.sv_target.x = saturate(tmp1.x);
                tmp1 = tex2D(_Curves, tmp0.yw);
                tmp0 = tex2D(_Curves, tmp0.zw);
                o.sv_target.z = saturate(tmp0.z);
                o.sv_target.y = saturate(tmp1.y);
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 112774
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
			float4 _Lut2D_Params;
			float4 _UserLut2D_Params;
			float3 _ColorBalance;
			float3 _ColorFilter;
			float3 _HueSatCon;
			float _Brightness;
			float3 _ChannelMixerRed;
			float3 _ChannelMixerGreen;
			float3 _ChannelMixerBlue;
			float3 _Lift;
			float3 _InvGamma;
			float3 _Gain;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _Curves;
			
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
                tmp0.x = _UserLut2D_Params.y;
                tmp1.yz = inp.texcoord1.xy - _Lut2D_Params.yz;
                tmp2.x = tmp1.y * _Lut2D_Params.x;
                tmp1.x = frac(tmp2.x);
                tmp2.x = tmp1.x / _Lut2D_Params.x;
                tmp1.w = tmp1.y - tmp2.x;
                tmp2.xyz = tmp1.xzw * _Lut2D_Params.www;
                tmp3.xyz = tmp2.zxy * _UserLut2D_Params.zzz;
                tmp1.y = floor(tmp3.x);
                tmp3.xw = _UserLut2D_Params.xy * float2(0.5, 0.5);
                tmp3.yz = tmp3.yz * _UserLut2D_Params.xy + tmp3.xw;
                tmp3.x = tmp1.y * _UserLut2D_Params.y + tmp3.y;
                tmp1.y = tmp2.z * _UserLut2D_Params.z + -tmp1.y;
                tmp0.yw = float2(0.0, 0.25);
                tmp0.xy = tmp0.xy + tmp3.xz;
                tmp3 = tex2D(_MainTex, tmp3.xz);
                tmp4 = tex2D(_MainTex, tmp0.xy);
                tmp4.xyz = tmp4.xyz - tmp3.xyz;
                tmp3.xyz = tmp1.yyy * tmp4.xyz + tmp3.xyz;
                tmp1.xyz = -tmp1.xzw * _Lut2D_Params.www + tmp3.xyz;
                tmp1.xyz = _UserLut2D_Params.www * tmp1.xyz + tmp2.xyz;
                tmp1.xyz = tmp1.xyz * _Brightness.xxx + float3(-0.2176376, -0.2176376, -0.2176376);
                tmp1.xyz = tmp1.xyz * _HueSatCon + float3(0.2176376, 0.2176376, 0.2176376);
                tmp2.x = dot(float3(0.390405, 0.549941, 0.0089263), tmp1.xyz);
                tmp2.y = dot(float3(0.0708416, 0.963172, 0.0013578), tmp1.xyz);
                tmp2.z = dot(float3(0.0231082, 0.128021, 0.936245), tmp1.xyz);
                tmp1.xyz = tmp2.xyz * _ColorBalance;
                tmp2.x = dot(float3(2.85847, -1.62879, -0.024891), tmp1.xyz);
                tmp2.y = dot(float3(-0.210182, 1.1582, 0.0003243), tmp1.xyz);
                tmp2.z = dot(float3(-0.041812, -0.118169, 1.06867), tmp1.xyz);
                tmp1.xyz = tmp2.xyz * _ColorFilter;
                tmp2.x = dot(tmp1.xyz, _ChannelMixerRed);
                tmp2.y = dot(tmp1.xyz, _ChannelMixerGreen);
                tmp2.z = dot(tmp1.xyz, _ChannelMixerBlue);
                tmp1.xyz = tmp2.xyz * _Gain + _Lift;
                tmp2.xyz = log(abs(tmp1.xyz));
                tmp1.xyz = saturate(tmp1.xyz * float3(340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0) + float3(0.5, 0.5, 0.5));
                tmp1.xyz = tmp1.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp2.xyz = tmp2.xyz * _InvGamma;
                tmp2.xyz = exp(tmp2.xyz);
                tmp1.xyz = tmp1.xyz * tmp2.xyz;
                tmp1.xyz = max(tmp1.xyz, float3(0.0, 0.0, 0.0));
                tmp0.x = tmp1.y >= tmp1.z;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp2.xy = tmp1.zy;
                tmp3.xy = tmp1.yz - tmp2.xy;
                tmp2.zw = float2(-1.0, 0.6666667);
                tmp3.zw = float2(1.0, -1.0);
                tmp2 = tmp0.xxxx * tmp3.xywz + tmp2.xywz;
                tmp0.x = tmp1.x >= tmp2.x;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp3.z = tmp2.w;
                tmp2.w = tmp1.x;
                tmp1.z = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp3.xyw = tmp2.wyx;
                tmp3 = tmp3 - tmp2;
                tmp2 = tmp0.xxxx * tmp3 + tmp2;
                tmp0.x = min(tmp2.y, tmp2.w);
                tmp0.x = tmp2.x - tmp0.x;
                tmp0.y = tmp0.x * 6.0 + 0.0001;
                tmp2.y = tmp2.w - tmp2.y;
                tmp0.y = tmp2.y / tmp0.y;
                tmp0.y = tmp0.y + tmp2.z;
                tmp0.z = abs(tmp0.y);
                tmp3 = tex2Dlod(_Curves, float4(tmp0.zw, 0, 0.0));
                tmp4.x = tmp0.z + _HueSatCon.x;
                tmp3.x = saturate(tmp3.x);
                tmp0.y = tmp3.x + tmp3.x;
                tmp0.z = tmp2.x + 0.0001;
                tmp1.x = tmp0.x / tmp0.z;
                tmp1.yw = float2(0.25, 0.25);
                tmp3 = tex2Dlod(_Curves, float4(tmp1.xy, 0, 0.0));
                tmp5 = tex2Dlod(_Curves, float4(tmp1.zw, 0, 0.0));
                tmp5.x = saturate(tmp5.x);
                tmp3.x = saturate(tmp3.x);
                tmp0.x = dot(tmp3.xy, tmp0.xy);
                tmp0.x = tmp0.x * tmp5.x;
                tmp0.x = dot(_HueSatCon.xy, tmp0.xy);
                tmp4.y = 0.25;
                tmp3 = tex2Dlod(_Curves, float4(tmp4.xy, 0, 0.0));
                tmp3.x = saturate(tmp3.x);
                tmp0.y = tmp4.x + tmp3.x;
                tmp0.yzw = tmp0.yyy + float3(-0.5, 0.5, -1.5);
                tmp1.y = tmp0.y > 1.0;
                tmp0.w = tmp1.y ? tmp0.w : tmp0.y;
                tmp0.y = tmp0.y < 0.0;
                tmp0.y = tmp0.y ? tmp0.z : tmp0.w;
                tmp0.yzw = tmp0.yyy + float3(1.0, 0.6666667, 0.3333333);
                tmp0.yzw = frac(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(6.0, 6.0, 6.0) + float3(-3.0, -3.0, -3.0);
                tmp0.yzw = saturate(abs(tmp0.yzw) - float3(1.0, 1.0, 1.0));
                tmp0.yzw = tmp0.yzw - float3(1.0, 1.0, 1.0);
                tmp0.yzw = tmp1.xxx * tmp0.yzw + float3(1.0, 1.0, 1.0);
                tmp1.xyz = tmp0.yzw * tmp2.xxx;
                tmp1.x = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.yzw = tmp2.xxx * tmp0.yzw + -tmp1.xxx;
                tmp0.xyz = saturate(tmp0.xxx * tmp0.yzw + tmp1.xxx);
                tmp0.xyz = tmp0.xyz + float3(0.0039063, 0.0039063, 0.0039063);
                tmp0.w = 0.75;
                tmp1 = tex2D(_Curves, tmp0.xw);
                tmp1.x = saturate(tmp1.x);
                tmp2 = tex2D(_Curves, tmp0.yw);
                tmp0 = tex2D(_Curves, tmp0.zw);
                tmp1.z = saturate(tmp0.w);
                tmp1.y = saturate(tmp2.w);
                tmp0.xyz = tmp1.xyz + float3(0.0039063, 0.0039063, 0.0039063);
                tmp0.w = 0.75;
                tmp1 = tex2D(_Curves, tmp0.xw);
                o.sv_target.x = saturate(tmp1.x);
                tmp1 = tex2D(_Curves, tmp0.yw);
                tmp0 = tex2D(_Curves, tmp0.zw);
                o.sv_target.z = saturate(tmp0.z);
                o.sv_target.y = saturate(tmp1.y);
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 175109
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
			float4 _Lut2D_Params;
			float3 _ColorBalance;
			float3 _ColorFilter;
			float3 _HueSatCon;
			float3 _ChannelMixerRed;
			float3 _ChannelMixerGreen;
			float3 _ChannelMixerBlue;
			float3 _Lift;
			float3 _InvGamma;
			float3 _Gain;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _Curves;
			
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
                tmp0.yz = inp.texcoord.xy - _Lut2D_Params.yz;
                tmp1.x = tmp0.y * _Lut2D_Params.x;
                tmp0.x = frac(tmp1.x);
                tmp1.x = tmp0.x / _Lut2D_Params.x;
                tmp0.w = tmp0.y - tmp1.x;
                tmp0.xyz = tmp0.xzw * _Lut2D_Params.www + float3(-0.4135884, -0.4135884, -0.4135884);
                tmp0.xyz = tmp0.xyz * _HueSatCon + float3(0.0275524, 0.0275524, 0.0275524);
                tmp0.xyz = tmp0.xyz * float3(13.60548, 13.60548, 13.60548);
                tmp0.xyz = exp(tmp0.xyz);
                tmp0.xyz = tmp0.xyz - float3(0.047996, 0.047996, 0.047996);
                tmp0.xyz = tmp0.xyz * float3(0.18, 0.18, 0.18);
                tmp1.x = dot(float3(0.390405, 0.549941, 0.0089263), tmp0.xyz);
                tmp1.y = dot(float3(0.0708416, 0.963172, 0.0013578), tmp0.xyz);
                tmp1.z = dot(float3(0.0231082, 0.128021, 0.936245), tmp0.xyz);
                tmp0.xyz = tmp1.xyz * _ColorBalance;
                tmp1.x = dot(float3(2.85847, -1.62879, -0.024891), tmp0.xyz);
                tmp1.y = dot(float3(-0.210182, 1.1582, 0.0003243), tmp0.xyz);
                tmp1.z = dot(float3(-0.041812, -0.118169, 1.06867), tmp0.xyz);
                tmp0.xyz = tmp1.xyz * _ColorFilter;
                tmp1.x = dot(tmp0.xyz, _ChannelMixerRed);
                tmp1.y = dot(tmp0.xyz, _ChannelMixerGreen);
                tmp1.z = dot(tmp0.xyz, _ChannelMixerBlue);
                tmp0.xyz = tmp1.xyz * _Gain + _Lift;
                tmp1.xyz = log(abs(tmp0.xyz));
                tmp0.xyz = saturate(tmp0.xyz * float3(340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0, 340282300000000000000000000000000000000.0) + float3(0.5, 0.5, 0.5));
                tmp0.xyz = tmp0.xyz * float3(2.0, 2.0, 2.0) + float3(-1.0, -1.0, -1.0);
                tmp1.xyz = tmp1.xyz * _InvGamma;
                tmp1.xyz = exp(tmp1.xyz);
                tmp0.xyz = tmp0.xyz * tmp1.xyz;
                tmp0.xyz = max(tmp0.xyz, float3(0.0, 0.0, 0.0));
                tmp0.w = tmp0.y >= tmp0.z;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp1.xy = tmp0.zy;
                tmp2.xy = tmp0.yz - tmp1.xy;
                tmp1.zw = float2(-1.0, 0.6666667);
                tmp2.zw = float2(1.0, -1.0);
                tmp1 = tmp0.wwww * tmp2.xywz + tmp1.xywz;
                tmp0.w = tmp0.x >= tmp1.x;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp2.z = tmp1.w;
                tmp1.w = tmp0.x;
                tmp3.x = dot(tmp0.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp2.xyw = tmp1.wyx;
                tmp2 = tmp2 - tmp1;
                tmp0 = tmp0.wwww * tmp2 + tmp1;
                tmp1.x = min(tmp0.y, tmp0.w);
                tmp1.x = tmp0.x - tmp1.x;
                tmp1.y = tmp1.x * 6.0 + 0.0001;
                tmp0.y = tmp0.w - tmp0.y;
                tmp0.y = tmp0.y / tmp1.y;
                tmp0.y = tmp0.y + tmp0.z;
                tmp2.x = abs(tmp0.y);
                tmp3.z = tmp2.x + _HueSatCon.x;
                tmp3.yw = float2(0.25, 0.25);
                tmp4 = tex2Dlod(_Curves, float4(tmp3.zw, 0, 0.0));
                tmp5 = tex2Dlod(_Curves, float4(tmp3.xy, 0, 0.0));
                tmp5.x = saturate(tmp5.x);
                tmp4.x = saturate(tmp4.x);
                tmp0.y = tmp3.z + tmp4.x;
                tmp0.yzw = tmp0.yyy + float3(-0.5, 0.5, -1.5);
                tmp1.y = tmp0.y > 1.0;
                tmp0.w = tmp1.y ? tmp0.w : tmp0.y;
                tmp0.y = tmp0.y < 0.0;
                tmp0.y = tmp0.y ? tmp0.z : tmp0.w;
                tmp0.yzw = tmp0.yyy + float3(1.0, 0.6666667, 0.3333333);
                tmp0.yzw = frac(tmp0.yzw);
                tmp0.yzw = tmp0.yzw * float3(6.0, 6.0, 6.0) + float3(-3.0, -3.0, -3.0);
                tmp0.yzw = saturate(abs(tmp0.yzw) - float3(1.0, 1.0, 1.0));
                tmp0.yzw = tmp0.yzw - float3(1.0, 1.0, 1.0);
                tmp1.y = tmp0.x + 0.0001;
                tmp2.z = tmp1.x / tmp1.y;
                tmp0.yzw = tmp2.zzz * tmp0.yzw + float3(1.0, 1.0, 1.0);
                tmp1.xyz = tmp0.yzw * tmp0.xxx;
                tmp1.x = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.xyz = tmp0.xxx * tmp0.yzw + -tmp1.xxx;
                tmp2.yw = float2(0.25, 0.25);
                tmp3 = tex2Dlod(_Curves, float4(tmp2.xy, 0, 0.0));
                tmp2 = tex2Dlod(_Curves, float4(tmp2.zw, 0, 0.0));
                tmp2.x = saturate(tmp2.x);
                tmp3.x = saturate(tmp3.x);
                tmp0.w = tmp3.x + tmp3.x;
                tmp0.w = dot(tmp2.xy, tmp0.xy);
                tmp0.w = tmp0.w * tmp5.x;
                tmp0.w = dot(_HueSatCon.xy, tmp0.xy);
                tmp0.xyz = tmp0.www * tmp0.xyz + tmp1.xxx;
                o.sv_target.xyz = max(tmp0.xyz, float3(0.0, 0.0, 0.0));
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}