Shader "Hidden/PostProcessing/DepthOfField" {
	Properties {
	}
	SubShader {
		Pass {
			Name "CoC Calculation"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 38108
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
			float _Distance;
			float _LensCoeff;
			float _RcpMaxCoC;
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
                tmp0 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.x = _ZBufferParams.z * tmp0.x + _ZBufferParams.w;
                tmp0.x = 1.0 / tmp0.x;
                tmp0.y = tmp0.x - _Distance;
                tmp0.x = max(tmp0.x, 0.0001);
                tmp0.y = tmp0.y * _LensCoeff;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x * 0.5;
                tmp0.x = tmp0.x * _RcpMaxCoC + 0.5;
                o.sv_target = saturate(tmp0.xxxx);
                return o;
			}
			ENDCG
		}
		Pass {
			Name "CoC Temporal Filter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 74593
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
			float3 _TaaParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraMotionVectorsTexture;
			sampler2D _CoCTex;
			
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
                tmp0.xy = _MainTex_TexelSize.yy * float2(-0.0, -1.0);
                tmp1 = saturate(-_MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp0.w = tex2D(_CoCTex, tmp1.xy);
                tmp0.z = tex2D(_CoCTex, tmp1.zw);
                tmp1.xy = saturate(inp.texcoord.xy - _TaaParams.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1.x = tex2D(_CoCTex, tmp1.xy);
                tmp1.y = tmp0.w < tmp1.x;
                tmp2.z = tmp1.y ? tmp0.w : tmp1.x;
                tmp0.w = max(tmp0.w, tmp1.x);
                tmp0.w = max(tmp0.z, tmp0.w);
                tmp1.z = tmp0.z < tmp2.z;
                tmp3.xy = _MainTex_TexelSize.xy * float2(1.0, 0.0);
                tmp3.zw = -tmp3.xy;
                tmp2.xy = tmp1.yy ? tmp3.zw : 0.0;
                tmp0.xyz = tmp1.zzz ? tmp0.xyz : tmp2.xyz;
                tmp2 = saturate(_MainTex_TexelSize * float4(0.0, 1.0, 1.0, 0.0) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp1.w = tex2D(_CoCTex, tmp2.xy);
                tmp2.x = tex2D(_CoCTex, tmp2.zw);
                tmp2.y = tmp1.w < tmp0.z;
                tmp1.yz = _MainTex_TexelSize.yy * float2(0.0, 1.0);
                tmp0.w = max(tmp0.w, tmp1.w);
                tmp0.w = max(tmp2.x, tmp0.w);
                tmp0.xyz = tmp2.yyy ? tmp1.yzw : tmp0.xyz;
                tmp1.y = tmp2.x < tmp0.z;
                tmp0.z = min(tmp2.x, tmp0.z);
                tmp0.xy = tmp1.yy ? tmp3.xy : tmp0.xy;
                tmp0.xy = saturate(tmp0.xy + inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp0.xy = tex2D(_CameraMotionVectorsTexture, tmp0.xy);
                tmp0.xy = saturate(inp.texcoord.xy - tmp0.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp0.x = tex2D(_MainTex, tmp0.xy);
                tmp0.x = max(tmp0.z, tmp0.x);
                tmp0.x = min(tmp0.w, tmp0.x);
                tmp0.x = tmp0.x - tmp1.x;
                o.sv_target = _TaaParams.zzzz * tmp0.xxxx + tmp1.xxxx;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Downsample and Prefilter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 155771
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
			float _MaxCoC;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CoCTex;
			
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
                tmp0 = saturate(-_MainTex_TexelSize * float4(0.5, 0.5, -0.5, 0.5) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1.xyz = tex2D(_MainTex, tmp0.zw);
                tmp1.w = max(tmp1.y, tmp1.x);
                tmp1.w = max(tmp1.z, tmp1.w);
                tmp1.w = tmp1.w + 1.0;
                tmp0.z = tex2D(_CoCTex, tmp0.zw);
                tmp0.z = tmp0.z * 2.0 + -1.0;
                tmp0.w = abs(tmp0.z) / tmp1.w;
                tmp1.xyz = tmp0.www * tmp1.xyz;
                tmp2.xyz = tex2D(_MainTex, tmp0.xy);
                tmp0.x = tex2D(_CoCTex, tmp0.xy);
                tmp0.x = tmp0.x * 2.0 + -1.0;
                tmp0.y = max(tmp2.y, tmp2.x);
                tmp0.y = max(tmp2.z, tmp0.y);
                tmp0.y = tmp0.y + 1.0;
                tmp0.y = abs(tmp0.x) / tmp0.y;
                tmp1.xyz = tmp2.xyz * tmp0.yyy + tmp1.xyz;
                tmp0.y = tmp0.w + tmp0.y;
                tmp2 = saturate(_MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp3.xyz = tex2D(_MainTex, tmp2.xy);
                tmp0.w = max(tmp3.y, tmp3.x);
                tmp0.w = max(tmp3.z, tmp0.w);
                tmp0.w = tmp0.w + 1.0;
                tmp1.w = tex2D(_CoCTex, tmp2.xy);
                tmp1.w = tmp1.w * 2.0 + -1.0;
                tmp0.w = abs(tmp1.w) / tmp0.w;
                tmp1.xyz = tmp3.xyz * tmp0.www + tmp1.xyz;
                tmp0.y = tmp0.w + tmp0.y;
                tmp3.xyz = tex2D(_MainTex, tmp2.zw);
                tmp0.w = tex2D(_CoCTex, tmp2.zw);
                tmp0.w = tmp0.w * 2.0 + -1.0;
                tmp2.x = max(tmp3.y, tmp3.x);
                tmp2.x = max(tmp3.z, tmp2.x);
                tmp2.x = tmp2.x + 1.0;
                tmp2.x = abs(tmp0.w) / tmp2.x;
                tmp1.xyz = tmp3.xyz * tmp2.xxx + tmp1.xyz;
                tmp0.y = tmp0.y + tmp2.x;
                tmp0.y = max(tmp0.y, 0.0001);
                tmp1.xyz = tmp1.xyz / tmp0.yyy;
                tmp0.y = min(tmp0.z, tmp1.w);
                tmp0.z = max(tmp0.z, tmp1.w);
                tmp0.z = max(tmp0.w, tmp0.z);
                tmp0.y = min(tmp0.w, tmp0.y);
                tmp0.y = min(tmp0.y, tmp0.x);
                tmp0.x = max(tmp0.z, tmp0.x);
                tmp0.z = tmp0.x < -tmp0.y;
                tmp0.x = tmp0.z ? tmp0.y : tmp0.x;
                tmp0.x = tmp0.x * _MaxCoC;
                tmp0.y = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp0.y = 1.0 / tmp0.y;
                tmp0.y = saturate(tmp0.y * abs(tmp0.x));
                o.sv_target.w = tmp0.x;
                tmp0.x = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.x = tmp0.y * tmp0.x;
                tmp0.yzw = tmp1.xyz * tmp0.xxx + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp0.xxx * tmp1.xyz;
                tmp0.xyz = tmp0.yzw * float3(0.9478673, 0.9478673, 0.9478673);
                tmp0.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp0.xyz = log(tmp0.xyz);
                tmp0.xyz = tmp0.xyz * float3(2.4, 2.4, 2.4);
                tmp0.xyz = exp(tmp0.xyz);
                tmp2.xyz = tmp1.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp1.xyz = tmp1.xyz <= float3(0.04045, 0.04045, 0.04045);
                o.sv_target.xyz = tmp1.xyz ? tmp2.xyz : tmp0.xyz;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (small)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 222627
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[16] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.5454546, 0.0, 0.0, 0.0),
                    float4(0.1685547, 0.5187581, 0.0, 0.0),
                    float4(-0.441282, 0.3206101, 0.0, 0.0),
                    float4(-0.441282, -0.3206102, 0.0, 0.0),
                    float4(0.1685548, -0.5187581, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.809017, 0.5877852, 0.0, 0.0),
                    float4(0.309017, 0.9510565, 0.0, 0.0),
                    float4(-0.309017, 0.9510565, 0.0, 0.0),
                    float4(-0.8090171, 0.5877852, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.8090169, -0.5877854, 0.0, 0.0),
                    float4(-0.3090166, -0.9510566, 0.0, 0.0),
                    float4(0.3090171, -0.9510565, 0.0, 0.0),
                    float4(0.8090169, -0.5877853, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 16; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.1963495;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (medium)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 313855
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[22] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.5333334, 0.0, 0.0, 0.0),
                    float4(0.3325279, 0.4169768, 0.0, 0.0),
                    float4(-0.1186778, 0.5199616, 0.0, 0.0),
                    float4(-0.4805167, 0.2314047, 0.0, 0.0),
                    float4(-0.4805167, -0.2314047, 0.0, 0.0),
                    float4(-0.1186776, -0.5199617, 0.0, 0.0),
                    float4(0.3325278, -0.4169769, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9009688, 0.4338838, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.222521, 0.9749279, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.62349, 0.7818314, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.6234896, -0.7818316, 0.0, 0.0),
                    float4(-0.2225205, -0.974928, 0.0, 0.0),
                    float4(0.2225215, -0.9749278, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.9009688, -0.4338838, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 22; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.1427997;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (large)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 364199
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[43] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.3636364, 0.0, 0.0, 0.0),
                    float4(0.2267236, 0.2843024, 0.0, 0.0),
                    float4(-0.0809167, 0.3545192, 0.0, 0.0),
                    float4(-0.327625, 0.1577759, 0.0, 0.0),
                    float4(-0.327625, -0.1577759, 0.0, 0.0),
                    float4(-0.0809166, -0.3545193, 0.0, 0.0),
                    float4(0.2267235, -0.2843024, 0.0, 0.0),
                    float4(0.6818182, 0.0, 0.0, 0.0),
                    float4(0.614297, 0.2958298, 0.0, 0.0),
                    float4(0.4251067, 0.5330669, 0.0, 0.0),
                    float4(0.1517189, 0.6647236, 0.0, 0.0),
                    float4(-0.1517188, 0.6647236, 0.0, 0.0),
                    float4(-0.4251068, 0.5330669, 0.0, 0.0),
                    float4(-0.614297, 0.2958299, 0.0, 0.0),
                    float4(-0.6818182, 0.0, 0.0, 0.0),
                    float4(-0.614297, -0.2958298, 0.0, 0.0),
                    float4(-0.4251066, -0.533067, 0.0, 0.0),
                    float4(-0.1517186, -0.6647236, 0.0, 0.0),
                    float4(0.1517192, -0.6647235, 0.0, 0.0),
                    float4(0.4251066, -0.533067, 0.0, 0.0),
                    float4(0.614297, -0.2958298, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9555728, 0.2947552, 0.0, 0.0),
                    float4(0.8262388, 0.5633201, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.365341, 0.9308738, 0.0, 0.0),
                    float4(0.07473, 0.9972038, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.5000001, 0.8660254, 0.0, 0.0),
                    float4(-0.733052, 0.6801727, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-0.9888309, 0.1490421, 0.0, 0.0),
                    float4(-0.9888308, -0.1490425, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.7330518, -0.6801728, 0.0, 0.0),
                    float4(-0.4999999, -0.8660254, 0.0, 0.0),
                    float4(-0.222521, -0.9749279, 0.0, 0.0),
                    float4(0.0747303, -0.9972038, 0.0, 0.0),
                    float4(0.3653415, -0.9308736, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.8262388, -0.56332, 0.0, 0.0),
                    float4(0.9555729, -0.2947548, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 43; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.0730603;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (very large)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 412682
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[71] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.2758621, 0.0, 0.0, 0.0),
                    float4(0.1719972, 0.2156777, 0.0, 0.0),
                    float4(-0.0613851, 0.2689457, 0.0, 0.0),
                    float4(-0.2485432, 0.1196921, 0.0, 0.0),
                    float4(-0.2485432, -0.1196921, 0.0, 0.0),
                    float4(-0.061385, -0.2689457, 0.0, 0.0),
                    float4(0.1719972, -0.2156777, 0.0, 0.0),
                    float4(0.5172414, 0.0, 0.0, 0.0),
                    float4(0.4660183, 0.2244226, 0.0, 0.0),
                    float4(0.3224947, 0.4043956, 0.0, 0.0),
                    float4(0.1150971, 0.5042731, 0.0, 0.0),
                    float4(-0.115097, 0.5042731, 0.0, 0.0),
                    float4(-0.3224948, 0.4043955, 0.0, 0.0),
                    float4(-0.4660183, 0.2244226, 0.0, 0.0),
                    float4(-0.5172414, 0.0, 0.0, 0.0),
                    float4(-0.4660183, -0.2244226, 0.0, 0.0),
                    float4(-0.3224946, -0.4043956, 0.0, 0.0),
                    float4(-0.1150968, -0.5042731, 0.0, 0.0),
                    float4(0.1150973, -0.504273, 0.0, 0.0),
                    float4(0.3224947, -0.4043956, 0.0, 0.0),
                    float4(0.4660183, -0.2244226, 0.0, 0.0),
                    float4(0.7586207, 0.0, 0.0, 0.0),
                    float4(0.7249173, 0.2236074, 0.0, 0.0),
                    float4(0.6268018, 0.4273463, 0.0, 0.0),
                    float4(0.4729922, 0.5931135, 0.0, 0.0),
                    float4(0.2771552, 0.7061801, 0.0, 0.0),
                    float4(0.0566917, 0.7564995, 0.0, 0.0),
                    float4(-0.168809, 0.7396005, 0.0, 0.0),
                    float4(-0.3793104, 0.6569847, 0.0, 0.0),
                    float4(-0.5561084, 0.5159931, 0.0, 0.0),
                    float4(-0.6834936, 0.3291532, 0.0, 0.0),
                    float4(-0.7501475, 0.1130664, 0.0, 0.0),
                    float4(-0.7501475, -0.1130667, 0.0, 0.0),
                    float4(-0.6834936, -0.3291532, 0.0, 0.0),
                    float4(-0.5561083, -0.5159932, 0.0, 0.0),
                    float4(-0.3793103, -0.6569848, 0.0, 0.0),
                    float4(-0.168809, -0.7396005, 0.0, 0.0),
                    float4(0.0566919, -0.7564994, 0.0, 0.0),
                    float4(0.2771556, -0.7061799, 0.0, 0.0),
                    float4(0.4729922, -0.5931137, 0.0, 0.0),
                    float4(0.6268018, -0.4273462, 0.0, 0.0),
                    float4(0.7249174, -0.2236071, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9749279, 0.2225209, 0.0, 0.0),
                    float4(0.9009688, 0.4338838, 0.0, 0.0),
                    float4(0.7818315, 0.6234898, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.4338836, 0.9009689, 0.0, 0.0),
                    float4(0.222521, 0.9749279, 0.0, 0.0),
                    float4(0.0, 1.0, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.4338838, 0.9009688, 0.0, 0.0),
                    float4(-0.62349, 0.7818314, 0.0, 0.0),
                    float4(-0.7818317, 0.6234896, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-0.9749279, 0.2225209, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.9749279, -0.2225209, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.7818314, -0.6234899, 0.0, 0.0),
                    float4(-0.6234896, -0.7818316, 0.0, 0.0),
                    float4(-0.4338835, -0.900969, 0.0, 0.0),
                    float4(-0.2225205, -0.974928, 0.0, 0.0),
                    float4(0.0, -1.0, 0.0, 0.0),
                    float4(0.2225215, -0.9749278, 0.0, 0.0),
                    float4(0.4338835, -0.900969, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.7818314, -0.6234899, 0.0, 0.0),
                    float4(0.9009688, -0.4338838, 0.0, 0.0),
                    float4(0.9749279, -0.2225209, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 71; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.0442478;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Postfilter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 473214
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
                tmp0 = saturate(-_MainTex_TexelSize * float4(0.5, 0.5, -0.5, 0.5) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0 = tmp0 + tmp1;
                tmp1 = saturate(_MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp0 = tmp0 + tmp2;
                tmp0 = tmp1 + tmp0;
                o.sv_target = tmp0 * float4(0.25, 0.25, 0.25, 0.25);
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Combine"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 581092
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
			float _MaxCoC;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CoCTex;
			sampler2D _DepthOfFieldTex;
			
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
                tmp1.xyz = tmp0.xyz + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp1.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp1.xyz = max(abs(tmp1.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(2.4, 2.4, 2.4);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp0.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp3.xyz = tmp0.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.xyz = tmp3.xyz ? tmp2.xyz : tmp1.xyz;
                tmp1 = tex2D(_CoCTex, inp.texcoord1.xy);
                tmp1.x = tmp1.x - 0.5;
                tmp1.x = tmp1.x + tmp1.x;
                tmp1.y = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.x = tmp1.x * _MaxCoC + -tmp1.y;
                tmp1.y = 1.0 / tmp1.y;
                tmp1.x = saturate(tmp1.y * tmp1.x);
                tmp1.y = tmp1.x * -2.0 + 3.0;
                tmp1.x = tmp1.x * tmp1.x;
                tmp1.z = tmp1.x * tmp1.y;
                tmp2 = tex2D(_DepthOfFieldTex, inp.texcoord1.xy);
                tmp1.x = tmp1.y * tmp1.x + tmp2.w;
                tmp1.x = -tmp1.z * tmp2.w + tmp1.x;
                tmp1.y = max(tmp2.y, tmp2.x);
                tmp2.w = max(tmp2.z, tmp1.y);
                tmp2 = tmp2 - tmp0;
                tmp0 = tmp1.xxxx * tmp2 + tmp0;
                tmp1.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp1.xyz = exp(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp2.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.w = tmp0.w;
                o.sv_target.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Debug Overlay"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 608515
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
			float _Distance;
			float _LensCoeff;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
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
                tmp0 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.x = _ZBufferParams.z * tmp0.x + _ZBufferParams.w;
                tmp0.x = 1.0 / tmp0.x;
                tmp0.y = tmp0.x - _Distance;
                tmp0.y = tmp0.y * _LensCoeff;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x * 80.0;
                tmp0.y = saturate(tmp0.x);
                tmp0.x = saturate(-tmp0.x);
                tmp0.xzw = tmp0.xxx * float3(0.0, 1.0, 1.0) + float3(1.0, 0.0, 0.0);
                tmp1.xyz = float3(0.4, 0.4, 0.4) - tmp0.xww;
                tmp0.xyz = tmp0.yyy * tmp1.xyz + tmp0.xzw;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.w = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.w = tmp0.w + 0.5;
                o.sv_target.xyz = tmp0.www * tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
	SubShader {
		Pass {
			Name "CoC Calculation"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 703831
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
			float _Distance;
			float _LensCoeff;
			float _RcpMaxCoC;
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
                tmp0 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.x = _ZBufferParams.z * tmp0.x + _ZBufferParams.w;
                tmp0.x = 1.0 / tmp0.x;
                tmp0.y = tmp0.x - _Distance;
                tmp0.x = max(tmp0.x, 0.0001);
                tmp0.y = tmp0.y * _LensCoeff;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x * 0.5;
                tmp0.x = tmp0.x * _RcpMaxCoC + 0.5;
                o.sv_target = saturate(tmp0.xxxx);
                return o;
			}
			ENDCG
		}
		Pass {
			Name "CoC Temporal Filter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 732018
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
			float3 _TaaParams;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CameraMotionVectorsTexture;
			sampler2D _CoCTex;
			
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
                tmp0.xy = _MainTex_TexelSize.yy * float2(-0.0, -1.0);
                tmp1 = saturate(-_MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_CoCTex, tmp1.xy);
                tmp1 = tex2D(_CoCTex, tmp1.zw);
                tmp1.yz = saturate(inp.texcoord.xy - _TaaParams.xy);
                tmp1.yz = tmp1.yz * _RenderViewportScaleFactor.xx;
                tmp3 = tex2D(_CoCTex, tmp1.yz);
                tmp0.w = tmp2.x < tmp3.x;
                tmp4.z = tmp0.w ? tmp2.x : tmp3.x;
                tmp1.y = max(tmp2.x, tmp3.x);
                tmp1.y = max(tmp1.x, tmp1.y);
                tmp1.z = tmp1.x < tmp4.z;
                tmp0.z = tmp1.x;
                tmp1.xw = _MainTex_TexelSize.xy * float2(1.0, 0.0);
                tmp2.xy = -tmp1.xw;
                tmp4.xy = tmp0.ww ? tmp2.xy : 0.0;
                tmp0.xyz = tmp1.zzz ? tmp0.xyz : tmp4.xyz;
                tmp2 = saturate(_MainTex_TexelSize * float4(0.0, 1.0, 1.0, 0.0) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_CoCTex, tmp2.xy);
                tmp2 = tex2D(_CoCTex, tmp2.zw);
                tmp0.w = tmp4.z < tmp0.z;
                tmp4.xy = _MainTex_TexelSize.yy * float2(0.0, 1.0);
                tmp1.y = max(tmp1.y, tmp4.z);
                tmp1.y = max(tmp2.x, tmp1.y);
                tmp0.xyz = tmp0.www ? tmp4.xyz : tmp0.xyz;
                tmp0.w = tmp2.x < tmp0.z;
                tmp0.z = min(tmp2.x, tmp0.z);
                tmp0.xy = tmp0.ww ? tmp1.xw : tmp0.xy;
                tmp0.xy = saturate(tmp0.xy + inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp2 = tex2D(_CameraMotionVectorsTexture, tmp0.xy);
                tmp0.xy = saturate(inp.texcoord.xy - tmp2.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp2 = tex2D(_MainTex, tmp0.xy);
                tmp0.x = max(tmp0.z, tmp2.x);
                tmp0.x = min(tmp1.y, tmp0.x);
                tmp0.x = tmp0.x - tmp3.x;
                o.sv_target = _TaaParams.zzzz * tmp0.xxxx + tmp3.xxxx;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Downsample and Prefilter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 793451
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
			float _MaxCoC;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CoCTex;
			
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
                tmp0 = saturate(-_MainTex_TexelSize * float4(0.5, 0.5, -0.5, 0.5) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tex2D(_MainTex, tmp0.zw);
                tmp1.w = max(tmp1.y, tmp1.x);
                tmp1.w = max(tmp1.z, tmp1.w);
                tmp1.w = tmp1.w + 1.0;
                tmp2 = tex2D(_CoCTex, tmp0.zw);
                tmp0.z = tmp2.x * 2.0 + -1.0;
                tmp0.w = abs(tmp0.z) / tmp1.w;
                tmp1.xyz = tmp0.www * tmp1.xyz;
                tmp2 = tex2D(_MainTex, tmp0.xy);
                tmp3 = tex2D(_CoCTex, tmp0.xy);
                tmp0.x = tmp3.x * 2.0 + -1.0;
                tmp0.y = max(tmp2.y, tmp2.x);
                tmp0.y = max(tmp2.z, tmp0.y);
                tmp0.y = tmp0.y + 1.0;
                tmp0.y = abs(tmp0.x) / tmp0.y;
                tmp1.xyz = tmp2.xyz * tmp0.yyy + tmp1.xyz;
                tmp0.y = tmp0.w + tmp0.y;
                tmp2 = saturate(_MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp0.w = max(tmp3.y, tmp3.x);
                tmp0.w = max(tmp3.z, tmp0.w);
                tmp0.w = tmp0.w + 1.0;
                tmp4 = tex2D(_CoCTex, tmp2.xy);
                tmp1.w = tmp4.x * 2.0 + -1.0;
                tmp0.w = abs(tmp1.w) / tmp0.w;
                tmp1.xyz = tmp3.xyz * tmp0.www + tmp1.xyz;
                tmp0.y = tmp0.w + tmp0.y;
                tmp3 = tex2D(_MainTex, tmp2.zw);
                tmp2 = tex2D(_CoCTex, tmp2.zw);
                tmp0.w = tmp2.x * 2.0 + -1.0;
                tmp2.x = max(tmp3.y, tmp3.x);
                tmp2.x = max(tmp3.z, tmp2.x);
                tmp2.x = tmp2.x + 1.0;
                tmp2.x = abs(tmp0.w) / tmp2.x;
                tmp1.xyz = tmp3.xyz * tmp2.xxx + tmp1.xyz;
                tmp0.y = tmp0.y + tmp2.x;
                tmp0.y = max(tmp0.y, 0.0001);
                tmp1.xyz = tmp1.xyz / tmp0.yyy;
                tmp0.y = min(tmp0.z, tmp1.w);
                tmp0.z = max(tmp0.z, tmp1.w);
                tmp0.z = max(tmp0.w, tmp0.z);
                tmp0.y = min(tmp0.w, tmp0.y);
                tmp0.y = min(tmp0.y, tmp0.x);
                tmp0.x = max(tmp0.z, tmp0.x);
                tmp0.z = tmp0.x < -tmp0.y;
                tmp0.x = tmp0.z ? tmp0.y : tmp0.x;
                tmp0.x = tmp0.x * _MaxCoC;
                tmp0.y = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp0.y = 1.0 / tmp0.y;
                tmp0.y = saturate(tmp0.y * abs(tmp0.x));
                o.sv_target.w = tmp0.x;
                tmp0.x = tmp0.y * -2.0 + 3.0;
                tmp0.y = tmp0.y * tmp0.y;
                tmp0.x = tmp0.y * tmp0.x;
                tmp0.yzw = tmp1.xyz * tmp0.xxx + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp0.xxx * tmp1.xyz;
                tmp0.xyz = tmp0.yzw * float3(0.9478673, 0.9478673, 0.9478673);
                tmp0.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp0.xyz = log(tmp0.xyz);
                tmp0.xyz = tmp0.xyz * float3(2.4, 2.4, 2.4);
                tmp0.xyz = exp(tmp0.xyz);
                tmp2.xyz = tmp1.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp1.xyz = tmp1.xyz <= float3(0.04045, 0.04045, 0.04045);
                o.sv_target.xyz = tmp1.xyz ? tmp2.xyz : tmp0.xyz;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (small)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 890411
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[16] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.5454546, 0.0, 0.0, 0.0),
                    float4(0.1685547, 0.5187581, 0.0, 0.0),
                    float4(-0.441282, 0.3206101, 0.0, 0.0),
                    float4(-0.441282, -0.3206102, 0.0, 0.0),
                    float4(0.1685548, -0.5187581, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.809017, 0.5877852, 0.0, 0.0),
                    float4(0.309017, 0.9510565, 0.0, 0.0),
                    float4(-0.309017, 0.9510565, 0.0, 0.0),
                    float4(-0.8090171, 0.5877852, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.8090169, -0.5877854, 0.0, 0.0),
                    float4(-0.3090166, -0.9510566, 0.0, 0.0),
                    float4(0.3090171, -0.9510565, 0.0, 0.0),
                    float4(0.8090169, -0.5877853, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 16; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.1963495;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (medium)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 966469
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[22] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.5333334, 0.0, 0.0, 0.0),
                    float4(0.3325279, 0.4169768, 0.0, 0.0),
                    float4(-0.1186778, 0.5199616, 0.0, 0.0),
                    float4(-0.4805167, 0.2314047, 0.0, 0.0),
                    float4(-0.4805167, -0.2314047, 0.0, 0.0),
                    float4(-0.1186776, -0.5199617, 0.0, 0.0),
                    float4(0.3325278, -0.4169769, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9009688, 0.4338838, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.222521, 0.9749279, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.62349, 0.7818314, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.6234896, -0.7818316, 0.0, 0.0),
                    float4(-0.2225205, -0.974928, 0.0, 0.0),
                    float4(0.2225215, -0.9749278, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.9009688, -0.4338838, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 22; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.1427997;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (large)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 1035014
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[43] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.3636364, 0.0, 0.0, 0.0),
                    float4(0.2267236, 0.2843024, 0.0, 0.0),
                    float4(-0.0809167, 0.3545192, 0.0, 0.0),
                    float4(-0.327625, 0.1577759, 0.0, 0.0),
                    float4(-0.327625, -0.1577759, 0.0, 0.0),
                    float4(-0.0809166, -0.3545193, 0.0, 0.0),
                    float4(0.2267235, -0.2843024, 0.0, 0.0),
                    float4(0.6818182, 0.0, 0.0, 0.0),
                    float4(0.614297, 0.2958298, 0.0, 0.0),
                    float4(0.4251067, 0.5330669, 0.0, 0.0),
                    float4(0.1517189, 0.6647236, 0.0, 0.0),
                    float4(-0.1517188, 0.6647236, 0.0, 0.0),
                    float4(-0.4251068, 0.5330669, 0.0, 0.0),
                    float4(-0.614297, 0.2958299, 0.0, 0.0),
                    float4(-0.6818182, 0.0, 0.0, 0.0),
                    float4(-0.614297, -0.2958298, 0.0, 0.0),
                    float4(-0.4251066, -0.533067, 0.0, 0.0),
                    float4(-0.1517186, -0.6647236, 0.0, 0.0),
                    float4(0.1517192, -0.6647235, 0.0, 0.0),
                    float4(0.4251066, -0.533067, 0.0, 0.0),
                    float4(0.614297, -0.2958298, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9555728, 0.2947552, 0.0, 0.0),
                    float4(0.8262388, 0.5633201, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.365341, 0.9308738, 0.0, 0.0),
                    float4(0.07473, 0.9972038, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.5000001, 0.8660254, 0.0, 0.0),
                    float4(-0.733052, 0.6801727, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-0.9888309, 0.1490421, 0.0, 0.0),
                    float4(-0.9888308, -0.1490425, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.7330518, -0.6801728, 0.0, 0.0),
                    float4(-0.4999999, -0.8660254, 0.0, 0.0),
                    float4(-0.222521, -0.9749279, 0.0, 0.0),
                    float4(0.0747303, -0.9972038, 0.0, 0.0),
                    float4(0.3653415, -0.9308736, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.8262388, -0.56332, 0.0, 0.0),
                    float4(0.9555729, -0.2947548, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 43; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.0730603;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Bokeh Filter (very large)"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 1051185
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
			float _MaxCoC;
			float _RcpAspect;
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
                const float4 icb[71] = {
                    float4(0.0, 0.0, 0.0, 0.0),
                    float4(0.2758621, 0.0, 0.0, 0.0),
                    float4(0.1719972, 0.2156777, 0.0, 0.0),
                    float4(-0.0613851, 0.2689457, 0.0, 0.0),
                    float4(-0.2485432, 0.1196921, 0.0, 0.0),
                    float4(-0.2485432, -0.1196921, 0.0, 0.0),
                    float4(-0.061385, -0.2689457, 0.0, 0.0),
                    float4(0.1719972, -0.2156777, 0.0, 0.0),
                    float4(0.5172414, 0.0, 0.0, 0.0),
                    float4(0.4660183, 0.2244226, 0.0, 0.0),
                    float4(0.3224947, 0.4043956, 0.0, 0.0),
                    float4(0.1150971, 0.5042731, 0.0, 0.0),
                    float4(-0.115097, 0.5042731, 0.0, 0.0),
                    float4(-0.3224948, 0.4043955, 0.0, 0.0),
                    float4(-0.4660183, 0.2244226, 0.0, 0.0),
                    float4(-0.5172414, 0.0, 0.0, 0.0),
                    float4(-0.4660183, -0.2244226, 0.0, 0.0),
                    float4(-0.3224946, -0.4043956, 0.0, 0.0),
                    float4(-0.1150968, -0.5042731, 0.0, 0.0),
                    float4(0.1150973, -0.504273, 0.0, 0.0),
                    float4(0.3224947, -0.4043956, 0.0, 0.0),
                    float4(0.4660183, -0.2244226, 0.0, 0.0),
                    float4(0.7586207, 0.0, 0.0, 0.0),
                    float4(0.7249173, 0.2236074, 0.0, 0.0),
                    float4(0.6268018, 0.4273463, 0.0, 0.0),
                    float4(0.4729922, 0.5931135, 0.0, 0.0),
                    float4(0.2771552, 0.7061801, 0.0, 0.0),
                    float4(0.0566917, 0.7564995, 0.0, 0.0),
                    float4(-0.168809, 0.7396005, 0.0, 0.0),
                    float4(-0.3793104, 0.6569847, 0.0, 0.0),
                    float4(-0.5561084, 0.5159931, 0.0, 0.0),
                    float4(-0.6834936, 0.3291532, 0.0, 0.0),
                    float4(-0.7501475, 0.1130664, 0.0, 0.0),
                    float4(-0.7501475, -0.1130667, 0.0, 0.0),
                    float4(-0.6834936, -0.3291532, 0.0, 0.0),
                    float4(-0.5561083, -0.5159932, 0.0, 0.0),
                    float4(-0.3793103, -0.6569848, 0.0, 0.0),
                    float4(-0.168809, -0.7396005, 0.0, 0.0),
                    float4(0.0566919, -0.7564994, 0.0, 0.0),
                    float4(0.2771556, -0.7061799, 0.0, 0.0),
                    float4(0.4729922, -0.5931137, 0.0, 0.0),
                    float4(0.6268018, -0.4273462, 0.0, 0.0),
                    float4(0.7249174, -0.2236071, 0.0, 0.0),
                    float4(1.0, 0.0, 0.0, 0.0),
                    float4(0.9749279, 0.2225209, 0.0, 0.0),
                    float4(0.9009688, 0.4338838, 0.0, 0.0),
                    float4(0.7818315, 0.6234898, 0.0, 0.0),
                    float4(0.6234898, 0.7818315, 0.0, 0.0),
                    float4(0.4338836, 0.9009689, 0.0, 0.0),
                    float4(0.222521, 0.9749279, 0.0, 0.0),
                    float4(0.0, 1.0, 0.0, 0.0),
                    float4(-0.2225209, 0.9749279, 0.0, 0.0),
                    float4(-0.4338838, 0.9009688, 0.0, 0.0),
                    float4(-0.62349, 0.7818314, 0.0, 0.0),
                    float4(-0.7818317, 0.6234896, 0.0, 0.0),
                    float4(-0.9009688, 0.4338838, 0.0, 0.0),
                    float4(-0.9749279, 0.2225209, 0.0, 0.0),
                    float4(-1.0, 0.0, 0.0, 0.0),
                    float4(-0.9749279, -0.2225209, 0.0, 0.0),
                    float4(-0.9009688, -0.4338838, 0.0, 0.0),
                    float4(-0.7818314, -0.6234899, 0.0, 0.0),
                    float4(-0.6234896, -0.7818316, 0.0, 0.0),
                    float4(-0.4338835, -0.900969, 0.0, 0.0),
                    float4(-0.2225205, -0.974928, 0.0, 0.0),
                    float4(0.0, -1.0, 0.0, 0.0),
                    float4(0.2225215, -0.9749278, 0.0, 0.0),
                    float4(0.4338835, -0.900969, 0.0, 0.0),
                    float4(0.6234897, -0.7818316, 0.0, 0.0),
                    float4(0.7818314, -0.6234899, 0.0, 0.0),
                    float4(0.9009688, -0.4338838, 0.0, 0.0),
                    float4(0.9749279, -0.2225209, 0.0, 0.0)
                };
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.x = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.w = 1.0;
                tmp2 = float4(0.0, 0.0, 0.0, 0.0);
                tmp3 = float4(0.0, 0.0, 0.0, 0.0);
                tmp0.y = 0.0;
                for (int i = tmp0.y; i < 71; i += 1) {
                    tmp4.yz = _MaxCoC.xx * icb[i + 0].xy;
                    tmp0.z = dot(tmp4.xy, tmp4.xy);
                    tmp0.z = sqrt(tmp0.z);
                    tmp4.x = tmp4.y * _RcpAspect;
                    tmp4.xy = saturate(tmp4.xz + inp.texcoord.xy);
                    tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                    tmp4 = tex2D(_MainTex, tmp4.xy);
                    tmp5.x = min(tmp0.w, tmp4.w);
                    tmp5.x = max(tmp5.x, 0.0);
                    tmp5.x = tmp5.x - tmp0.z;
                    tmp5.x = _MainTex_TexelSize.y * 2.0 + tmp5.x;
                    tmp5.x = saturate(tmp5.x / tmp0.x);
                    tmp0.z = -tmp0.z - tmp4.w;
                    tmp0.z = _MainTex_TexelSize.y * 2.0 + tmp0.z;
                    tmp0.z = saturate(tmp0.z / tmp0.x);
                    tmp4.w = -tmp4.w >= _MainTex_TexelSize.y;
                    tmp4.w = tmp4.w ? 1.0 : 0.0;
                    tmp0.z = tmp0.z * tmp4.w;
                    tmp1.xyz = tmp4.xyz;
                    tmp2 = tmp1 * tmp5.xxxx + tmp2;
                    tmp3 = tmp1 * tmp0.zzzz + tmp3;
                }
                tmp0.x = tmp2.w == 0.0;
                tmp0.x = tmp0.x ? 1.0 : 0.0;
                tmp0.x = tmp0.x + tmp2.w;
                tmp0.xyz = tmp2.xyz / tmp0.xxx;
                tmp0.w = tmp3.w == 0.0;
                tmp0.w = tmp0.w ? 1.0 : 0.0;
                tmp0.w = tmp0.w + tmp3.w;
                tmp1.xyz = tmp3.xyz / tmp0.www;
                tmp0.w = tmp3.w * 0.0442478;
                tmp0.w = min(tmp0.w, 1.0);
                tmp1.xyz = tmp1.xyz - tmp0.xyz;
                o.sv_target.xyz = tmp0.www * tmp1.xyz + tmp0.xyz;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Postfilter"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 1120897
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
                tmp0 = saturate(-_MainTex_TexelSize * float4(0.5, 0.5, -0.5, 0.5) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0 = tmp0 + tmp1;
                tmp1 = saturate(_MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp0 = tmp0 + tmp2;
                tmp0 = tmp1 + tmp0;
                o.sv_target = tmp0 * float4(0.25, 0.25, 0.25, 0.25);
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Combine"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 1218761
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
			float _MaxCoC;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _CoCTex;
			sampler2D _DepthOfFieldTex;
			
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
                tmp1.xyz = tmp0.xyz + float3(0.055, 0.055, 0.055);
                tmp1.xyz = tmp1.xyz * float3(0.9478673, 0.9478673, 0.9478673);
                tmp1.xyz = max(abs(tmp1.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(2.4, 2.4, 2.4);
                tmp1.xyz = exp(tmp1.xyz);
                tmp2.xyz = tmp0.xyz * float3(0.0773994, 0.0773994, 0.0773994);
                tmp3.xyz = tmp0.xyz <= float3(0.04045, 0.04045, 0.04045);
                tmp0.xyz = tmp3.xyz ? tmp2.xyz : tmp1.xyz;
                tmp1 = tex2D(_CoCTex, inp.texcoord1.xy);
                tmp1.x = tmp1.x - 0.5;
                tmp1.x = tmp1.x + tmp1.x;
                tmp1.y = _MainTex_TexelSize.y + _MainTex_TexelSize.y;
                tmp1.x = tmp1.x * _MaxCoC + -tmp1.y;
                tmp1.y = 1.0 / tmp1.y;
                tmp1.x = saturate(tmp1.y * tmp1.x);
                tmp1.y = tmp1.x * -2.0 + 3.0;
                tmp1.x = tmp1.x * tmp1.x;
                tmp1.z = tmp1.x * tmp1.y;
                tmp2 = tex2D(_DepthOfFieldTex, inp.texcoord1.xy);
                tmp1.x = tmp1.y * tmp1.x + tmp2.w;
                tmp1.x = -tmp1.z * tmp2.w + tmp1.x;
                tmp1.y = max(tmp2.y, tmp2.x);
                tmp2.w = max(tmp2.z, tmp1.y);
                tmp2 = tmp2 - tmp0;
                tmp0 = tmp1.xxxx * tmp2 + tmp0;
                tmp1.xyz = max(abs(tmp0.xyz), float3(0.0000001, 0.0000001, 0.0000001));
                tmp1.xyz = log(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(0.4166667, 0.4166667, 0.4166667);
                tmp1.xyz = exp(tmp1.xyz);
                tmp1.xyz = tmp1.xyz * float3(1.055, 1.055, 1.055) + float3(-0.055, -0.055, -0.055);
                tmp2.xyz = tmp0.xyz * float3(12.92, 12.92, 12.92);
                tmp0.xyz = tmp0.xyz <= float3(0.0031308, 0.0031308, 0.0031308);
                o.sv_target.w = tmp0.w;
                o.sv_target.xyz = tmp0.xyz ? tmp2.xyz : tmp1.xyz;
                return o;
			}
			ENDCG
		}
		Pass {
			Name "Debug Overlay"
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 1269419
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
			float _Distance;
			float _LensCoeff;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
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
                tmp0 = tex2D(_CameraDepthTexture, inp.texcoord1.xy);
                tmp0.x = _ZBufferParams.z * tmp0.x + _ZBufferParams.w;
                tmp0.x = 1.0 / tmp0.x;
                tmp0.y = tmp0.x - _Distance;
                tmp0.y = tmp0.y * _LensCoeff;
                tmp0.x = tmp0.y / tmp0.x;
                tmp0.x = tmp0.x * 80.0;
                tmp0.y = saturate(tmp0.x);
                tmp0.x = saturate(-tmp0.x);
                tmp0.xzw = tmp0.xxx * float3(0.0, 1.0, 1.0) + float3(1.0, 0.0, 0.0);
                tmp1.xyz = float3(0.4, 0.4, 0.4) - tmp0.xww;
                tmp0.xyz = tmp0.yyy * tmp1.xyz + tmp0.xzw;
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.w = dot(tmp1.xyz, float3(0.2126729, 0.7151522, 0.072175));
                tmp0.w = tmp0.w + 0.5;
                o.sv_target.xyz = tmp0.www * tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}