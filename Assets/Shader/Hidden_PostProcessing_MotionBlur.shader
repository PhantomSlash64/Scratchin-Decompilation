Shader "Hidden/PostProcessing/MotionBlur" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 25479
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
			float4 unity_OrthoParams;
			float4 _CameraMotionVectorsTexture_TexelSize;
			float _VelocityScale;
			float _RcpMaxBlurRadius;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _CameraDepthTexture;
			sampler2D _CameraMotionVectorsTexture;
			
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
                tmp0.x = _VelocityScale * 0.5;
                tmp0.xy = tmp0.xx * _CameraMotionVectorsTexture_TexelSize.zw;
                tmp1 = tex2D(_CameraMotionVectorsTexture, inp.texcoord.xy);
                tmp0.xy = tmp0.xy * tmp1.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.z = sqrt(tmp0.z);
                tmp0.z = tmp0.z * _RcpMaxBlurRadius;
                tmp0.z = max(tmp0.z, 1.0);
                tmp0.xy = tmp0.xy / tmp0.zz;
                tmp0.xy = tmp0.xy * _RcpMaxBlurRadius.xx + float2(1.0, 1.0);
                o.sv_target.xy = tmp0.xy * float2(0.5, 0.5);
                tmp0.x = 1.0 - unity_OrthoParams.w;
                tmp1 = tex2D(_CameraDepthTexture, inp.texcoord.xy);
                tmp0.y = tmp1.x * _ZBufferParams.x;
                tmp0.x = tmp0.x * tmp0.y + _ZBufferParams.y;
                tmp0.y = -unity_OrthoParams.w * tmp0.y + 1.0;
                o.sv_target.z = tmp0.y / tmp0.x;
                o.sv_target.w = 0.0;
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 95730
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
			float _MaxBlurRadius;
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
                tmp0 = _MainTex_TexelSize * float4(-0.5, -0.5, 0.5, -0.5) + inp.texcoord.xyxy;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0.xy = tmp0.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp0.zw = tmp1.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp0 = tmp0 * _MaxBlurRadius.xxxx;
                tmp1.x = dot(tmp0.xy, tmp0.xy);
                tmp1.y = dot(tmp0.xy, tmp0.xy);
                tmp1.x = tmp1.x < tmp1.y;
                tmp0.xy = tmp1.xx ? tmp0.xy : tmp0.zw;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp1 = _MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp1.xy = tmp1.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp1.zw = tmp2.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp1 = tmp1 * _MaxBlurRadius.xxxx;
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp0.z = tmp0.z < tmp0.w;
                tmp0.xy = tmp0.zz ? tmp1.zw : tmp0.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp0.z = tmp0.z < tmp0.w;
                o.sv_target.xy = tmp0.zz ? tmp1.xy : tmp0.xy;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 194360
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
                tmp0 = _MainTex_TexelSize * float4(-0.5, -0.5, 0.5, -0.5) + inp.texcoord.xyxy;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0.z = dot(tmp1.xy, tmp1.xy);
                tmp0.w = dot(tmp0.xy, tmp0.xy);
                tmp0.z = tmp0.z < tmp0.w;
                tmp0.xy = tmp0.zz ? tmp0.xy : tmp1.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp1 = _MainTex_TexelSize * float4(-0.5, 0.5, 0.5, 0.5) + inp.texcoord.xyxy;
                tmp2 = tex2D(_MainTex, tmp1.xy);
                tmp1 = tex2D(_MainTex, tmp1.zw);
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp0.z = tmp0.z < tmp0.w;
                tmp0.xy = tmp0.zz ? tmp2.xy : tmp0.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp0.z = tmp0.z < tmp0.w;
                o.sv_target.xy = tmp0.zz ? tmp1.xy : tmp0.xy;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 233378
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
			int _TileMaxLoop;
			float2 _TileMaxOffs;
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
                tmp0.xy = _MainTex_TexelSize.xy * _TileMaxOffs + inp.texcoord.xy;
                tmp1.yz = float2(0.0, 0.0);
                tmp1.xw = _MainTex_TexelSize.xy;
                tmp0.zw = float2(0.0, 0.0);
                tmp2.x = 0.0;
                while (true) {
                    tmp2.y = i >= _TileMaxLoop;
                    if (tmp2.y) {
                        break;
                    }
                    tmp2.y = floor(i);
                    tmp2.yz = tmp1.xy * tmp2.yy + tmp0.xy;
                    tmp3.xy = tmp0.zw;
                    tmp2.w = 0.0;
                    for (int j = tmp2.w; j < _TileMaxLoop; j += 1) {
                        tmp3.z = floor(j);
                        tmp3.zw = tmp1.zw * tmp3.zz + tmp2.yz;
                        tmp4 = tex2D(_MainTex, tmp3.zw);
                        tmp3.z = dot(tmp3.xy, tmp3.xy);
                        tmp3.w = dot(tmp4.xy, tmp4.xy);
                        tmp3.z = tmp3.z < tmp3.w;
                        tmp3.xy = tmp3.zz ? tmp4.xy : tmp3.xy;
                    }
                    tmp0.zw = tmp3.xy;
                    tmp2.x = tmp2.x + 1;
                }
                o.sv_target.xy = tmp0.zw;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 280318
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
                tmp0 = _MainTex_TexelSize * float4(0.0, 1.0, 1.0, 1.0) + inp.texcoord.xyxy;
                tmp1 = tex2D(_MainTex, tmp0.xy);
                tmp0 = tex2D(_MainTex, tmp0.zw);
                tmp0.z = dot(tmp1.xy, tmp1.xy);
                tmp0.w = dot(tmp0.xy, tmp0.xy);
                tmp0.z = tmp0.z < tmp0.w;
                tmp0.xy = tmp0.zz ? tmp0.xy : tmp1.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp1 = _MainTex_TexelSize * float4(1.0, 0.0, -1.0, 1.0) + inp.texcoord.xyxy;
                tmp2 = tex2D(_MainTex, tmp1.zw);
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp0.z = tmp0.w < tmp0.z;
                tmp0.xy = tmp0.zz ? tmp0.xy : tmp2.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp2 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1.zw = tmp2.xy * float2(1.01, 1.01);
                tmp2.x = dot(tmp1.xy, tmp1.xy);
                tmp0.w = tmp2.x < tmp0.w;
                tmp1.xy = tmp0.ww ? tmp1.xy : tmp1.zw;
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp2 = -_MainTex_TexelSize * float4(-1.0, 1.0, 1.0, 0.0) + inp.texcoord.xyxy;
                tmp3 = tex2D(_MainTex, tmp2.zw);
                tmp2 = tex2D(_MainTex, tmp2.xy);
                tmp1.z = dot(tmp3.xy, tmp3.xy);
                tmp0.w = tmp1.z < tmp0.w;
                tmp1.xy = tmp0.ww ? tmp1.xy : tmp3.xy;
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp0.z = tmp0.w < tmp0.z;
                tmp0.xy = tmp0.zz ? tmp0.xy : tmp1.xy;
                tmp0.z = dot(tmp0.xy, tmp0.xy);
                tmp0.w = dot(tmp2.xy, tmp2.xy);
                tmp1 = -_MainTex_TexelSize * float4(1.0, 1.0, 0.0, 1.0) + inp.texcoord.xyxy;
                tmp3 = tex2D(_MainTex, tmp1.zw);
                tmp1 = tex2D(_MainTex, tmp1.xy);
                tmp1.z = dot(tmp3.xy, tmp3.xy);
                tmp0.w = tmp1.z < tmp0.w;
                tmp1.zw = tmp0.ww ? tmp2.xy : tmp3.xy;
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp2.x = dot(tmp1.xy, tmp1.xy);
                tmp0.w = tmp2.x < tmp0.w;
                tmp1.xy = tmp0.ww ? tmp1.zw : tmp1.xy;
                tmp0.w = dot(tmp1.xy, tmp1.xy);
                tmp0.z = tmp0.w < tmp0.z;
                tmp0.xy = tmp0.zz ? tmp0.xy : tmp1.xy;
                o.sv_target.xy = tmp0.xy * float2(0.990099, 0.990099);
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 348419
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
			float2 _VelocityTex_TexelSize;
			float2 _NeighborMaxTex_TexelSize;
			float _MaxBlurRadius;
			float _LoopCount;
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _VelocityTex;
			sampler2D _NeighborMaxTex;
			
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
                float4 tmp9;
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1.xy = inp.texcoord.xy + float2(2.0, 0.0);
                tmp1.xy = tmp1.xy * _ScreenParams.xy;
                tmp1.xy = floor(tmp1.xy);
                tmp1.x = dot(float2(0.0671106, 0.0058372), tmp1.xy);
                tmp1.x = frac(tmp1.x);
                tmp1.x = tmp1.x * 52.98292;
                tmp1.x = frac(tmp1.x);
                tmp1.x = tmp1.x * 6.283185;
                tmp1.x = sin(tmp1.x);
                tmp2.x = cos(tmp1.x);
                tmp2.y = tmp1.x;
                tmp1.xy = tmp2.xy * _NeighborMaxTex_TexelSize;
                tmp1.xy = tmp1.xy * float2(0.25, 0.25) + inp.texcoord.xy;
                tmp1 = tex2D(_NeighborMaxTex, tmp1.xy);
                tmp1.z = dot(tmp1.xy, tmp1.xy);
                tmp1.z = sqrt(tmp1.z);
                tmp1.w = tmp1.z < 2.0;
                if (tmp1.w) {
                    o.sv_target = tmp0;
                    return o;
                }
                tmp2 = tex2Dlod(_VelocityTex, float4(inp.texcoord.xy, 0, 0.0));
                tmp2.xy = tmp2.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                tmp2.xy = tmp2.xy * _MaxBlurRadius.xx;
                tmp1.w = dot(tmp2.xy, tmp2.xy);
                tmp1.w = sqrt(tmp1.w);
                tmp3.xy = max(tmp1.ww, float2(0.5, 1.0));
                tmp1.w = 1.0 / tmp2.z;
                tmp2.w = tmp3.x + tmp3.x;
                tmp2.w = tmp1.z < tmp2.w;
                tmp3.x = tmp1.z / tmp3.x;
                tmp2.xy = tmp2.xy * tmp3.xx;
                tmp2.xy = tmp2.ww ? tmp2.xy : tmp1.xy;
                tmp2.w = tmp1.z * 0.5;
                tmp2.w = min(tmp2.w, _LoopCount);
                tmp2.w = floor(tmp2.w);
                tmp3.x = 1.0 / tmp2.w;
                tmp3.zw = inp.texcoord.xy * _ScreenParams.xy;
                tmp3.zw = floor(tmp3.zw);
                tmp3.z = dot(float2(0.0671106, 0.0058372), tmp3.xy);
                tmp3.z = frac(tmp3.z);
                tmp3.zw = tmp3.zx * float2(52.98292, 0.25);
                tmp3.z = frac(tmp3.z);
                tmp3.z = tmp3.z - 0.5;
                tmp4.x = -tmp3.x * 0.5 + 1.0;
                tmp5.w = 1.0;
                tmp6 = float4(0.0, 0.0, 0.0, 0.0);
                tmp4.y = tmp4.x;
                tmp4.z = 0.0;
                tmp4.w = tmp3.y;
                for (float i = tmp3.w; i < tmp4.y; i += 1) {
                    tmp7.xy = tmp4.zz * float2(0.25, 0.5);
                    tmp7.xy = frac(tmp7.xy);
                    tmp7.xy = tmp7.xy > float2(0.499, 0.499);
                    tmp7.xz = tmp7.xx ? tmp2.xy : tmp1.xy;
                    tmp7.w = tmp7.y ? -tmp4.y : tmp4.y;
                    tmp7.w = tmp3.z * tmp3.x + tmp7.w;
                    tmp7.xz = tmp7.ww * tmp7.xz;
                    tmp8.xy = tmp7.xz * _MainTex_TexelSize.xy + inp.texcoord.xy;
                    tmp7.xz = tmp7.xz * _VelocityTex_TexelSize + inp.texcoord.xy;
                    tmp8 = tex2Dlod(_MainTex, float4(tmp8.xy, 0, 0.0));
                    tmp9 = tex2Dlod(_VelocityTex, float4(tmp7.xz, 0, 0.0));
                    tmp7.xz = tmp9.xy * float2(2.0, 2.0) + float2(-1.0, -1.0);
                    tmp7.xz = tmp7.xz * _MaxBlurRadius.xx;
                    tmp8.w = tmp2.z - tmp9.z;
                    tmp8.w = tmp1.w * tmp8.w;
                    tmp8.w = saturate(tmp8.w * 20.0);
                    tmp7.x = dot(tmp7.xy, tmp7.xy);
                    tmp7.x = sqrt(tmp7.x);
                    tmp7.x = tmp7.x - tmp4.w;
                    tmp7.x = tmp8.w * tmp7.x + tmp4.w;
                    tmp7.z = saturate(-tmp1.z * abs(tmp7.w) + tmp7.x);
                    tmp7.z = tmp7.z / tmp7.x;
                    tmp7.w = 1.2 - tmp4.y;
                    tmp7.z = tmp7.w * tmp7.z;
                    tmp5.xyz = tmp8.xyz;
                    tmp6 = tmp5 * tmp7.zzzz + tmp6;
                    tmp4.w = max(tmp4.w, tmp7.x);
                    tmp5.x = tmp4.y - tmp3.x;
                    tmp4.y = tmp7.y ? tmp5.x : tmp4.y;
                }
                tmp1.x = dot(tmp4.xy, tmp2.xy);
                tmp1.x = 1.2 / tmp1.x;
                tmp2.xyz = tmp0.xyz;
                tmp2.w = 1.0;
                tmp1 = tmp2 * tmp1.xxxx + tmp6;
                o.sv_target.xyz = tmp1.xyz / tmp1.www;
                o.sv_target.w = tmp0.w;
                return o;
			}
			ENDCG
		}
	}
}