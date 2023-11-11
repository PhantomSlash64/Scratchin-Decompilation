Shader "Hidden/PostProcessing/Bloom" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 9736
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
			float4 _Threshold;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AutoExposureTex;
			
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
                tmp0 = saturate(_MainTex_TexelSize * float4(-0.5, -0.5, 0.5, -0.5) + inp.texcoord.xyxy);
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
                tmp1.xy = saturate(inp.texcoord.xy - _MainTex_TexelSize.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp2 = saturate(_MainTex_TexelSize * float4(0.0, -1.0, 1.0, -1.0) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp2 = tex2D(_MainTex, tmp2.zw);
                tmp2 = tmp2 + tmp3;
                tmp1 = tmp1 + tmp3;
                tmp3.xy = saturate(inp.texcoord.xy);
                tmp3.xy = tmp3.xy * _RenderViewportScaleFactor.xx;
                tmp3 = tex2D(_MainTex, tmp3.xy);
                tmp1 = tmp1 + tmp3;
                tmp4 = saturate(_MainTex_TexelSize * float4(-1.0, 0.0, 1.0, 0.0) + inp.texcoord.xyxy);
                tmp4 = tmp4 * _RenderViewportScaleFactor.xxxx;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp1 = tmp1 + tmp5;
                tmp5 = tmp3 + tmp5;
                tmp1 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125);
                tmp0 = tmp0 * float4(0.125, 0.125, 0.125, 0.125) + tmp1;
                tmp1 = tmp2 + tmp4;
                tmp2 = tmp3 + tmp4;
                tmp1 = tmp3 + tmp1;
                tmp0 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                tmp1 = saturate(_MainTex_TexelSize * float4(-1.0, 1.0, 0.0, 1.0) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp1.zw);
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp4 = tmp3 + tmp5;
                tmp1 = tmp1 + tmp4;
                tmp0 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                tmp1.xy = saturate(inp.texcoord.xy + _MainTex_TexelSize.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tmp1 + tmp2;
                tmp1 = tmp3 + tmp1;
                tmp0 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                tmp0 = min(tmp0, float4(65504.0, 65504.0, 65504.0, 65504.0));
                tmp1 = tex2D(_AutoExposureTex, inp.texcoord.xy);
                tmp0 = tmp0 * tmp1.xxxx;
                tmp0 = min(tmp0, _Params);
                tmp1.x = max(tmp0.y, tmp0.x);
                tmp1.x = max(tmp0.z, tmp1.x);
                tmp1.yz = tmp1.xx - _Threshold.yx;
                tmp1.xy = max(tmp1.xy, float2(0.0001, 0.0));
                tmp1.y = min(tmp1.y, _Threshold.z);
                tmp1.w = tmp1.y * _Threshold.w;
                tmp1.y = tmp1.y * tmp1.w;
                tmp1.y = max(tmp1.z, tmp1.y);
                tmp1.x = tmp1.y / tmp1.x;
                o.sv_target = tmp0 * tmp1.xxxx;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 125627
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
			float4 _Threshold;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AutoExposureTex;
			
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
                tmp0 = saturate(_MainTex_TexelSize * float4(-1.0, -1.0, 1.0, -1.0) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0 = tmp0 + tmp1;
                tmp1 = saturate(_MainTex_TexelSize * float4(-1.0, 1.0, 1.0, 1.0) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp0 = tmp0 + tmp2;
                tmp0 = tmp1 + tmp0;
                tmp0 = tmp0 * float4(0.25, 0.25, 0.25, 0.25);
                tmp0 = min(tmp0, float4(65504.0, 65504.0, 65504.0, 65504.0));
                tmp1 = tex2D(_AutoExposureTex, inp.texcoord.xy);
                tmp0 = tmp0 * tmp1.xxxx;
                tmp0 = min(tmp0, _Params);
                tmp1.x = max(tmp0.y, tmp0.x);
                tmp1.x = max(tmp0.z, tmp1.x);
                tmp1.yz = tmp1.xx - _Threshold.yx;
                tmp1.xy = max(tmp1.xy, float2(0.0001, 0.0));
                tmp1.y = min(tmp1.y, _Threshold.z);
                tmp1.w = tmp1.y * _Threshold.w;
                tmp1.y = tmp1.y * tmp1.w;
                tmp1.y = max(tmp1.z, tmp1.y);
                tmp1.x = tmp1.y / tmp1.x;
                o.sv_target = tmp0 * tmp1.xxxx;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 147226
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
                float4 tmp3;
                float4 tmp4;
                float4 tmp5;
                tmp0 = saturate(_MainTex_TexelSize * float4(-0.5, -0.5, 0.5, -0.5) + inp.texcoord.xyxy);
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
                tmp1.xy = saturate(inp.texcoord.xy - _MainTex_TexelSize.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp2 = saturate(_MainTex_TexelSize * float4(0.0, -1.0, 1.0, -1.0) + inp.texcoord.xyxy);
                tmp2 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp2 = tex2D(_MainTex, tmp2.zw);
                tmp2 = tmp2 + tmp3;
                tmp1 = tmp1 + tmp3;
                tmp3.xy = saturate(inp.texcoord.xy);
                tmp3.xy = tmp3.xy * _RenderViewportScaleFactor.xx;
                tmp3 = tex2D(_MainTex, tmp3.xy);
                tmp1 = tmp1 + tmp3;
                tmp4 = saturate(_MainTex_TexelSize * float4(-1.0, 0.0, 1.0, 0.0) + inp.texcoord.xyxy);
                tmp4 = tmp4 * _RenderViewportScaleFactor.xxxx;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp1 = tmp1 + tmp5;
                tmp5 = tmp3 + tmp5;
                tmp1 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125);
                tmp0 = tmp0 * float4(0.125, 0.125, 0.125, 0.125) + tmp1;
                tmp1 = tmp2 + tmp4;
                tmp2 = tmp3 + tmp4;
                tmp1 = tmp3 + tmp1;
                tmp0 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                tmp1 = saturate(_MainTex_TexelSize * float4(-1.0, 1.0, 0.0, 1.0) + inp.texcoord.xyxy);
                tmp1 = tmp1 * _RenderViewportScaleFactor.xxxx;
                tmp3 = tex2D(_MainTex, tmp1.zw);
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp4 = tmp3 + tmp5;
                tmp1 = tmp1 + tmp4;
                tmp0 = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                tmp1.xy = saturate(inp.texcoord.xy + _MainTex_TexelSize.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tmp1 + tmp2;
                tmp1 = tmp3 + tmp1;
                o.sv_target = tmp1 * float4(0.03125, 0.03125, 0.03125, 0.03125) + tmp0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 199315
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
                tmp0 = saturate(_MainTex_TexelSize * float4(-1.0, -1.0, 1.0, -1.0) + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0 = tmp0 + tmp1;
                tmp1 = saturate(_MainTex_TexelSize * float4(-1.0, 1.0, 1.0, 1.0) + inp.texcoord.xyxy);
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
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 292266
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
			float _SampleScale;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _BloomTex;
			
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
                tmp0.xy = saturate(inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp0 = tex2D(_MainTex, tmp0.xy);
                tmp1.x = 1.0;
                tmp1.z = _SampleScale;
                tmp1 = tmp1.xxzz * _MainTex_TexelSize;
                tmp2.zw = float2(-1.0, 0.0);
                tmp2.x = _SampleScale;
                tmp3 = saturate(-tmp1.xywy * tmp2.xxwx + inp.texcoord.xyxy);
                tmp3 = tmp3 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_MainTex, tmp3.xy);
                tmp3 = tex2D(_MainTex, tmp3.zw);
                tmp3 = tmp3 * float4(2.0, 2.0, 2.0, 2.0) + tmp4;
                tmp4.xy = saturate(-tmp1.zy * tmp2.zx + inp.texcoord.xy);
                tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                tmp4 = tex2D(_MainTex, tmp4.xy);
                tmp3 = tmp3 + tmp4;
                tmp4 = saturate(tmp1.zwxw * tmp2.zwxw + inp.texcoord.xyxy);
                tmp5 = saturate(tmp1.zywy * tmp2.zxwx + inp.texcoord.xyxy);
                tmp1.xy = saturate(tmp1.xy * tmp2.xx + inp.texcoord.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp2 = tmp5 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tmp4 * _RenderViewportScaleFactor.xxxx;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp3 = tmp5 * float4(2.0, 2.0, 2.0, 2.0) + tmp3;
                tmp0 = tmp0 * float4(4.0, 4.0, 4.0, 4.0) + tmp3;
                tmp0 = tmp4 * float4(2.0, 2.0, 2.0, 2.0) + tmp0;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp2 = tex2D(_MainTex, tmp2.zw);
                tmp0 = tmp0 + tmp3;
                tmp0 = tmp2 * float4(2.0, 2.0, 2.0, 2.0) + tmp0;
                tmp0 = tmp1 + tmp0;
                tmp1 = tex2D(_BloomTex, inp.texcoord1.xy);
                o.sv_target = tmp0 * float4(0.0625, 0.0625, 0.0625, 0.0625) + tmp1;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 361309
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
			float _SampleScale;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _BloomTex;
			
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
                tmp0 = _MainTex_TexelSize * float4(-1.0, -1.0, 1.0, 1.0);
                tmp1.x = _SampleScale * 0.5;
                tmp2 = saturate(tmp0.xyzy * tmp1.xxxx + inp.texcoord.xyxy);
                tmp0 = saturate(tmp0.xwzw * tmp1.xxxx + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp1 = tmp1 + tmp2;
                tmp2 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp1 = tmp1 + tmp2;
                tmp0 = tmp0 + tmp1;
                tmp1 = tex2D(_BloomTex, inp.texcoord1.xy);
                o.sv_target = tmp0 * float4(0.25, 0.25, 0.25, 0.25) + tmp1;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 428412
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
			float4 _Threshold;
			float4 _Params;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AutoExposureTex;
			
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
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp0.xyz = min(tmp0.xyz, float3(65504.0, 65504.0, 65504.0));
                tmp1 = tex2D(_AutoExposureTex, inp.texcoord.xy);
                tmp0.xyz = tmp0.xyz * tmp1.xxx;
                tmp0.xyz = min(tmp0.xyz, _Params.xxx);
                tmp0.w = max(tmp0.y, tmp0.x);
                tmp0.w = max(tmp0.z, tmp0.w);
                tmp1.xy = tmp0.ww - _Threshold.yx;
                tmp0.w = max(tmp0.w, 0.0001);
                tmp1.x = max(tmp1.x, 0.0);
                tmp1.x = min(tmp1.x, _Threshold.z);
                tmp1.z = tmp1.x * _Threshold.w;
                tmp1.x = tmp1.x * tmp1.z;
                tmp1.x = max(tmp1.y, tmp1.x);
                tmp0.w = tmp1.x / tmp0.w;
                o.sv_target.xyz = tmp0.www * tmp0.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 502561
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
			float _SampleScale;
			float4 _ColorIntensity;
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
                float4 tmp5;
                tmp0.xy = saturate(inp.texcoord.xy);
                tmp0.xy = tmp0.xy * _RenderViewportScaleFactor.xx;
                tmp0 = tex2D(_MainTex, tmp0.xy);
                tmp1.x = 1.0;
                tmp1.z = _SampleScale;
                tmp1 = tmp1.xxzz * _MainTex_TexelSize;
                tmp2.zw = float2(-1.0, 0.0);
                tmp2.x = _SampleScale;
                tmp3 = saturate(-tmp1.xywy * tmp2.xxwx + inp.texcoord.xyxy);
                tmp3 = tmp3 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tex2D(_MainTex, tmp3.xy);
                tmp3 = tex2D(_MainTex, tmp3.zw);
                tmp3.xyz = tmp3.xyz * float3(2.0, 2.0, 2.0) + tmp4.xyz;
                tmp4.xy = saturate(-tmp1.zy * tmp2.zx + inp.texcoord.xy);
                tmp4.xy = tmp4.xy * _RenderViewportScaleFactor.xx;
                tmp4 = tex2D(_MainTex, tmp4.xy);
                tmp3.xyz = tmp3.xyz + tmp4.xyz;
                tmp4 = saturate(tmp1.zwxw * tmp2.zwxw + inp.texcoord.xyxy);
                tmp5 = saturate(tmp1.zywy * tmp2.zxwx + inp.texcoord.xyxy);
                tmp1.xy = saturate(tmp1.xy * tmp2.xx + inp.texcoord.xy);
                tmp1.xy = tmp1.xy * _RenderViewportScaleFactor.xx;
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp2 = tmp5 * _RenderViewportScaleFactor.xxxx;
                tmp4 = tmp4 * _RenderViewportScaleFactor.xxxx;
                tmp5 = tex2D(_MainTex, tmp4.xy);
                tmp4 = tex2D(_MainTex, tmp4.zw);
                tmp3.xyz = tmp5.xyz * float3(2.0, 2.0, 2.0) + tmp3.xyz;
                tmp0.xyz = tmp0.xyz * float3(4.0, 4.0, 4.0) + tmp3.xyz;
                tmp0.xyz = tmp4.xyz * float3(2.0, 2.0, 2.0) + tmp0.xyz;
                tmp3 = tex2D(_MainTex, tmp2.xy);
                tmp2 = tex2D(_MainTex, tmp2.zw);
                tmp0.xyz = tmp0.xyz + tmp3.xyz;
                tmp0.xyz = tmp2.xyz * float3(2.0, 2.0, 2.0) + tmp0.xyz;
                tmp0.xyz = tmp1.xyz + tmp0.xyz;
                tmp0.xyz = tmp0.xyz * float3(0.0625, 0.0625, 0.0625);
                tmp0.xyz = tmp0.xyz * _ColorIntensity.www;
                o.sv_target.xyz = tmp0.xyz * _ColorIntensity.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 526297
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
			float _SampleScale;
			float4 _ColorIntensity;
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
                tmp0 = _MainTex_TexelSize * float4(-1.0, -1.0, 1.0, 1.0);
                tmp1.x = _SampleScale * 0.5;
                tmp2 = saturate(tmp0.xyzy * tmp1.xxxx + inp.texcoord.xyxy);
                tmp0 = saturate(tmp0.xwzw * tmp1.xxxx + inp.texcoord.xyxy);
                tmp0 = tmp0 * _RenderViewportScaleFactor.xxxx;
                tmp1 = tmp2 * _RenderViewportScaleFactor.xxxx;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp1.xyz = tmp1.xyz + tmp2.xyz;
                tmp2 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp1.xyz = tmp1.xyz + tmp2.xyz;
                tmp0.xyz = tmp0.xyz + tmp1.xyz;
                tmp0.xyz = tmp0.xyz * float3(0.25, 0.25, 0.25);
                tmp0.xyz = tmp0.xyz * _ColorIntensity.www;
                o.sv_target.xyz = tmp0.xyz * _ColorIntensity.xyz;
                o.sv_target.w = 1.0;
                return o;
			}
			ENDCG
		}
	}
}