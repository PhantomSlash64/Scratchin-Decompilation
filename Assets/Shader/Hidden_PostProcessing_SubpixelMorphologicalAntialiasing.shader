Shader "Hidden/PostProcessing/SubpixelMorphologicalAntialiasing" {
	Properties {
	}
	SubShader {
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 53444
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float4 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
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
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * float2(0.5, -0.5) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy;
                o.texcoord1 = _MainTex_TexelSize * float4(-1.0, 0.0, 0.0, -1.0) + tmp0.xyxy;
                o.texcoord2 = _MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + tmp0.xyxy;
                o.texcoord3 = _MainTex_TexelSize * float4(-2.0, 0.0, 0.0, -2.0) + tmp0.xyxy;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2.xyz = tmp0.xyz - tmp1.xyz;
                tmp0.w = max(abs(tmp2.y), abs(tmp2.x));
                tmp2.x = max(abs(tmp2.z), tmp0.w);
                tmp3 = tex2D(_MainTex, inp.texcoord1.zw);
                tmp4.xyz = tmp0.xyz - tmp3.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp2.y = max(abs(tmp4.z), tmp0.w);
                tmp2.zw = tmp2.xy >= float2(0.15, 0.15);
                tmp2.zw = tmp2.zw ? 1.0 : 0.0;
                tmp0.w = dot(tmp2.xy, float2(1.0, 1.0));
                tmp0.w = tmp0.w == 0.0;
                if (tmp0.w) {
                    discard;
                }
                tmp4 = tex2D(_MainTex, inp.texcoord2.xy);
                tmp4.xyz = tmp0.xyz - tmp4.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp4.x = max(abs(tmp4.z), tmp0.w);
                tmp5 = tex2D(_MainTex, inp.texcoord2.zw);
                tmp0.xyz = tmp0.xyz - tmp5.xyz;
                tmp0.x = max(abs(tmp0.y), abs(tmp0.x));
                tmp4.y = max(abs(tmp0.z), tmp0.x);
                tmp0.xy = max(tmp2.xy, tmp4.xy);
                tmp4 = tex2D(_MainTex, inp.texcoord3.xy);
                tmp1.xyz = tmp1.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp1.y), abs(tmp1.x));
                tmp1.x = max(abs(tmp1.z), tmp0.z);
                tmp4 = tex2D(_MainTex, inp.texcoord3.zw);
                tmp3.xyz = tmp3.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp3.y), abs(tmp3.x));
                tmp1.y = max(abs(tmp3.z), tmp0.z);
                tmp0.xy = max(tmp0.xy, tmp1.xy);
                tmp0.x = max(tmp0.y, tmp0.x);
                tmp0.yz = tmp2.xy + tmp2.xy;
                tmp0.xy = tmp0.yz >= tmp0.xx;
                tmp0.xy = tmp0.xy ? 1.0 : 0.0;
                tmp0.xy = tmp0.xy * tmp2.zw;
                o.sv_target.xy = tmp0.xy;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 120903
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float4 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
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
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * float2(0.5, -0.5) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy;
                o.texcoord1 = _MainTex_TexelSize * float4(-1.0, 0.0, 0.0, -1.0) + tmp0.xyxy;
                o.texcoord2 = _MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + tmp0.xyxy;
                o.texcoord3 = _MainTex_TexelSize * float4(-2.0, 0.0, 0.0, -2.0) + tmp0.xyxy;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2.xyz = tmp0.xyz - tmp1.xyz;
                tmp0.w = max(abs(tmp2.y), abs(tmp2.x));
                tmp2.x = max(abs(tmp2.z), tmp0.w);
                tmp3 = tex2D(_MainTex, inp.texcoord1.zw);
                tmp4.xyz = tmp0.xyz - tmp3.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp2.y = max(abs(tmp4.z), tmp0.w);
                tmp2.zw = tmp2.xy >= float2(0.1, 0.1);
                tmp2.zw = tmp2.zw ? 1.0 : 0.0;
                tmp0.w = dot(tmp2.xy, float2(1.0, 1.0));
                tmp0.w = tmp0.w == 0.0;
                if (tmp0.w) {
                    discard;
                }
                tmp4 = tex2D(_MainTex, inp.texcoord2.xy);
                tmp4.xyz = tmp0.xyz - tmp4.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp4.x = max(abs(tmp4.z), tmp0.w);
                tmp5 = tex2D(_MainTex, inp.texcoord2.zw);
                tmp0.xyz = tmp0.xyz - tmp5.xyz;
                tmp0.x = max(abs(tmp0.y), abs(tmp0.x));
                tmp4.y = max(abs(tmp0.z), tmp0.x);
                tmp0.xy = max(tmp2.xy, tmp4.xy);
                tmp4 = tex2D(_MainTex, inp.texcoord3.xy);
                tmp1.xyz = tmp1.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp1.y), abs(tmp1.x));
                tmp1.x = max(abs(tmp1.z), tmp0.z);
                tmp4 = tex2D(_MainTex, inp.texcoord3.zw);
                tmp3.xyz = tmp3.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp3.y), abs(tmp3.x));
                tmp1.y = max(abs(tmp3.z), tmp0.z);
                tmp0.xy = max(tmp0.xy, tmp1.xy);
                tmp0.x = max(tmp0.y, tmp0.x);
                tmp0.yz = tmp2.xy + tmp2.xy;
                tmp0.xy = tmp0.yz >= tmp0.xx;
                tmp0.xy = tmp0.xy ? 1.0 : 0.0;
                tmp0.xy = tmp0.xy * tmp2.zw;
                o.sv_target.xy = tmp0.xy;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 142247
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float4 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
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
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * float2(0.5, -0.5) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy;
                o.texcoord1 = _MainTex_TexelSize * float4(-1.0, 0.0, 0.0, -1.0) + tmp0.xyxy;
                o.texcoord2 = _MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + tmp0.xyxy;
                o.texcoord3 = _MainTex_TexelSize * float4(-2.0, 0.0, 0.0, -2.0) + tmp0.xyxy;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp1 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp2.xyz = tmp0.xyz - tmp1.xyz;
                tmp0.w = max(abs(tmp2.y), abs(tmp2.x));
                tmp2.x = max(abs(tmp2.z), tmp0.w);
                tmp3 = tex2D(_MainTex, inp.texcoord1.zw);
                tmp4.xyz = tmp0.xyz - tmp3.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp2.y = max(abs(tmp4.z), tmp0.w);
                tmp2.zw = tmp2.xy >= float2(0.1, 0.1);
                tmp2.zw = tmp2.zw ? 1.0 : 0.0;
                tmp0.w = dot(tmp2.xy, float2(1.0, 1.0));
                tmp0.w = tmp0.w == 0.0;
                if (tmp0.w) {
                    discard;
                }
                tmp4 = tex2D(_MainTex, inp.texcoord2.xy);
                tmp4.xyz = tmp0.xyz - tmp4.xyz;
                tmp0.w = max(abs(tmp4.y), abs(tmp4.x));
                tmp4.x = max(abs(tmp4.z), tmp0.w);
                tmp5 = tex2D(_MainTex, inp.texcoord2.zw);
                tmp0.xyz = tmp0.xyz - tmp5.xyz;
                tmp0.x = max(abs(tmp0.y), abs(tmp0.x));
                tmp4.y = max(abs(tmp0.z), tmp0.x);
                tmp0.xy = max(tmp2.xy, tmp4.xy);
                tmp4 = tex2D(_MainTex, inp.texcoord3.xy);
                tmp1.xyz = tmp1.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp1.y), abs(tmp1.x));
                tmp1.x = max(abs(tmp1.z), tmp0.z);
                tmp4 = tex2D(_MainTex, inp.texcoord3.zw);
                tmp3.xyz = tmp3.xyz - tmp4.xyz;
                tmp0.z = max(abs(tmp3.y), abs(tmp3.x));
                tmp1.y = max(abs(tmp3.z), tmp0.z);
                tmp0.xy = max(tmp0.xy, tmp1.xy);
                tmp0.x = max(tmp0.y, tmp0.x);
                tmp0.yz = tmp2.xy + tmp2.xy;
                tmp0.xy = tmp0.yz >= tmp0.xx;
                tmp0.xy = tmp0.xy ? 1.0 : 0.0;
                tmp0.xy = tmp0.xy * tmp2.zw;
                o.sv_target.xy = tmp0.xy;
                o.sv_target.zw = float2(0.0, 0.0);
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 255539
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float4 texcoord4 : TEXCOORD4;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AreaTex;
			sampler2D _SearchTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                tmp0 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
                o.texcoord1.xy = tmp0.zw * _MainTex_TexelSize.zw;
                tmp1 = _MainTex_TexelSize * float4(-0.25, 1.25, -0.125, -0.125) + tmp0.zzww;
                tmp0 = _MainTex_TexelSize * float4(-0.125, -0.25, -0.125, 1.25) + tmp0;
                o.texcoord2 = tmp1.xzyw;
                o.texcoord3 = tmp0;
                tmp1.zw = tmp0.yw;
                o.texcoord4 = _MainTex_TexelSize * float4(-8.0, 8.0, -8.0, 8.0) + tmp1;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp0.xy = tmp0.yx > float2(0.0, 0.0);
                if (tmp0.x) {
                    tmp1.xy = inp.texcoord2.xy;
                    tmp1.z = 1.0;
                    tmp2.x = 0.0;
                    while (true) {
                        tmp0.x = inp.texcoord4.x < tmp1.x;
                        tmp0.z = tmp1.z > 0.8281;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        tmp0.z = tmp2.x == 0.0;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        if (!(tmp0.x)) {
                            break;
                        }
                        tmp2 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                        tmp1.xy = _MainTex_TexelSize.xy * float2(-2.0, -0.0) + tmp1.xy;
                        tmp1.z = tmp2.y;
                    }
                    tmp2.yz = tmp1.xz;
                    tmp0.xz = tmp2.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    tmp0.x = tmp1.w * -2.007874 + 3.25;
                    tmp1.x = _MainTex_TexelSize.x * tmp0.x + tmp2.y;
                    tmp1.y = inp.texcoord3.y;
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                    tmp3.xy = inp.texcoord2.zw;
                    tmp3.z = 1.0;
                    tmp4.x = 0.0;
                    while (true) {
                        tmp0.x = tmp3.x < inp.texcoord4.y;
                        tmp0.z = tmp3.z > 0.8281;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        tmp0.z = tmp4.x == 0.0;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        if (!(tmp0.x)) {
                            break;
                        }
                        tmp4 = tex2Dlod(_MainTex, float4(tmp3.xy, 0, 0.0));
                        tmp3.xy = _MainTex_TexelSize.xy * float2(2.0, 0.0) + tmp3.xy;
                        tmp3.z = tmp4.y;
                    }
                    tmp4.yz = tmp3.xz;
                    tmp0.xz = tmp4.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                    tmp3 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    tmp0.x = tmp3.w * -2.007874 + 3.25;
                    tmp1.z = -_MainTex_TexelSize.x * tmp0.x + tmp4.y;
                    tmp0.xz = _MainTex_TexelSize.zz * tmp1.xz + -inp.texcoord1.xx;
                    tmp0.xz = round(tmp0.xz);
                    tmp0.xz = sqrt(abs(tmp0.xz));
                    tmp1 = tex2Dlod(_MainTex, float4(tmp1.zy, 0, 0.0));
                    tmp1.x = tmp2.x;
                    tmp1.xy = tmp1.xy * float2(4.0, 4.0);
                    tmp1.xy = round(tmp1.xy);
                    tmp0.xz = tmp1.xy * float2(16.0, 16.0) + tmp0.xz;
                    tmp0.xz = tmp0.xz * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    o.sv_target.xy = tmp1.xy;
                } else {
                    o.sv_target.xy = float2(0.0, 0.0);
                }
                if (tmp0.y) {
                    tmp0.xy = inp.texcoord3.xy;
                    tmp0.z = 1.0;
                    tmp1.x = 0.0;
                    while (true) {
                        tmp0.w = inp.texcoord4.z < tmp0.y;
                        tmp2.x = tmp0.z > 0.8281;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        tmp2.x = tmp1.x == 0.0;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        if (!(tmp0.w)) {
                            break;
                        }
                        tmp1 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                        tmp0.xy = _MainTex_TexelSize.xy * float2(-0.0, -2.0) + tmp0.xy;
                        tmp0.z = tmp1.y;
                    }
                    tmp1.yz = tmp0.yz;
                    tmp0.xy = tmp1.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                    tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                    tmp0.x = tmp0.w * -2.007874 + 3.25;
                    tmp0.x = _MainTex_TexelSize.y * tmp0.x + tmp1.y;
                    tmp0.y = inp.texcoord2.x;
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.yx, 0, 0.0));
                    tmp2.xy = inp.texcoord3.zw;
                    tmp2.z = 1.0;
                    tmp3.x = 0.0;
                    while (true) {
                        tmp0.w = tmp2.y < inp.texcoord4.w;
                        tmp1.x = tmp2.z > 0.8281;
                        tmp0.w = tmp0.w ? tmp1.x : 0.0;
                        tmp1.x = tmp3.x == 0.0;
                        tmp0.w = tmp0.w ? tmp1.x : 0.0;
                        if (!(tmp0.w)) {
                            break;
                        }
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                        tmp2.xy = _MainTex_TexelSize.xy * float2(0.0, 2.0) + tmp2.xy;
                        tmp2.z = tmp3.y;
                    }
                    tmp3.yz = tmp2.yz;
                    tmp1.xz = tmp3.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xz, 0, 0.0));
                    tmp0.w = tmp2.w * -2.007874 + 3.25;
                    tmp0.z = -_MainTex_TexelSize.y * tmp0.w + tmp3.y;
                    tmp0.xw = _MainTex_TexelSize.ww * tmp0.xz + -inp.texcoord1.yy;
                    tmp0.xw = round(tmp0.xw);
                    tmp0.xw = sqrt(abs(tmp0.xw));
                    tmp2 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                    tmp2.x = tmp1.y;
                    tmp0.yz = tmp2.xy * float2(4.0, 4.0);
                    tmp0.yz = round(tmp0.yz);
                    tmp0.xy = tmp0.yz * float2(16.0, 16.0) + tmp0.xw;
                    tmp0.xy = tmp0.xy * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                    tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                    o.sv_target.zw = tmp0.xy;
                } else {
                    o.sv_target.zw = float2(0.0, 0.0);
                }
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 325449
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float4 texcoord4 : TEXCOORD4;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AreaTex;
			sampler2D _SearchTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                tmp0 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
                o.texcoord1.xy = tmp0.zw * _MainTex_TexelSize.zw;
                tmp1 = _MainTex_TexelSize * float4(-0.25, 1.25, -0.125, -0.125) + tmp0.zzww;
                tmp0 = _MainTex_TexelSize * float4(-0.125, -0.25, -0.125, 1.25) + tmp0;
                o.texcoord2 = tmp1.xzyw;
                o.texcoord3 = tmp0;
                tmp1.zw = tmp0.yw;
                o.texcoord4 = _MainTex_TexelSize * float4(-16.0, 16.0, -16.0, 16.0) + tmp1;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp0.xy = tmp0.yx > float2(0.0, 0.0);
                if (tmp0.x) {
                    tmp1.xy = inp.texcoord2.xy;
                    tmp1.z = 1.0;
                    tmp2.x = 0.0;
                    while (true) {
                        tmp0.x = inp.texcoord4.x < tmp1.x;
                        tmp0.z = tmp1.z > 0.8281;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        tmp0.z = tmp2.x == 0.0;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        if (!(tmp0.x)) {
                            break;
                        }
                        tmp2 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                        tmp1.xy = _MainTex_TexelSize.xy * float2(-2.0, -0.0) + tmp1.xy;
                        tmp1.z = tmp2.y;
                    }
                    tmp2.yz = tmp1.xz;
                    tmp0.xz = tmp2.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    tmp0.x = tmp1.w * -2.007874 + 3.25;
                    tmp1.x = _MainTex_TexelSize.x * tmp0.x + tmp2.y;
                    tmp1.y = inp.texcoord3.y;
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                    tmp3.xy = inp.texcoord2.zw;
                    tmp3.z = 1.0;
                    tmp4.x = 0.0;
                    while (true) {
                        tmp0.x = tmp3.x < inp.texcoord4.y;
                        tmp0.z = tmp3.z > 0.8281;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        tmp0.z = tmp4.x == 0.0;
                        tmp0.x = tmp0.z ? tmp0.x : 0.0;
                        if (!(tmp0.x)) {
                            break;
                        }
                        tmp4 = tex2Dlod(_MainTex, float4(tmp3.xy, 0, 0.0));
                        tmp3.xy = _MainTex_TexelSize.xy * float2(2.0, 0.0) + tmp3.xy;
                        tmp3.z = tmp4.y;
                    }
                    tmp4.yz = tmp3.xz;
                    tmp0.xz = tmp4.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                    tmp3 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    tmp0.x = tmp3.w * -2.007874 + 3.25;
                    tmp1.z = -_MainTex_TexelSize.x * tmp0.x + tmp4.y;
                    tmp0.xz = _MainTex_TexelSize.zz * tmp1.xz + -inp.texcoord1.xx;
                    tmp0.xz = round(tmp0.xz);
                    tmp0.xz = sqrt(abs(tmp0.xz));
                    tmp1 = tex2Dlod(_MainTex, float4(tmp1.zy, 0, 0.0));
                    tmp1.x = tmp2.x;
                    tmp1.xy = tmp1.xy * float2(4.0, 4.0);
                    tmp1.xy = round(tmp1.xy);
                    tmp0.xz = tmp1.xy * float2(16.0, 16.0) + tmp0.xz;
                    tmp0.xz = tmp0.xz * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.xz, 0, 0.0));
                    o.sv_target.xy = tmp1.xy;
                } else {
                    o.sv_target.xy = float2(0.0, 0.0);
                }
                if (tmp0.y) {
                    tmp0.xy = inp.texcoord3.xy;
                    tmp0.z = 1.0;
                    tmp1.x = 0.0;
                    while (true) {
                        tmp0.w = inp.texcoord4.z < tmp0.y;
                        tmp2.x = tmp0.z > 0.8281;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        tmp2.x = tmp1.x == 0.0;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        if (!(tmp0.w)) {
                            break;
                        }
                        tmp1 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                        tmp0.xy = _MainTex_TexelSize.xy * float2(-0.0, -2.0) + tmp0.xy;
                        tmp0.z = tmp1.y;
                    }
                    tmp1.yz = tmp0.yz;
                    tmp0.xy = tmp1.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                    tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                    tmp0.x = tmp0.w * -2.007874 + 3.25;
                    tmp0.x = _MainTex_TexelSize.y * tmp0.x + tmp1.y;
                    tmp0.y = inp.texcoord2.x;
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.yx, 0, 0.0));
                    tmp2.xy = inp.texcoord3.zw;
                    tmp2.z = 1.0;
                    tmp3.x = 0.0;
                    while (true) {
                        tmp0.w = tmp2.y < inp.texcoord4.w;
                        tmp1.x = tmp2.z > 0.8281;
                        tmp0.w = tmp0.w ? tmp1.x : 0.0;
                        tmp1.x = tmp3.x == 0.0;
                        tmp0.w = tmp0.w ? tmp1.x : 0.0;
                        if (!(tmp0.w)) {
                            break;
                        }
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                        tmp2.xy = _MainTex_TexelSize.xy * float2(0.0, 2.0) + tmp2.xy;
                        tmp2.z = tmp3.y;
                    }
                    tmp3.yz = tmp2.yz;
                    tmp1.xz = tmp3.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xz, 0, 0.0));
                    tmp0.w = tmp2.w * -2.007874 + 3.25;
                    tmp0.z = -_MainTex_TexelSize.y * tmp0.w + tmp3.y;
                    tmp0.xw = _MainTex_TexelSize.ww * tmp0.xz + -inp.texcoord1.yy;
                    tmp0.xw = round(tmp0.xw);
                    tmp0.xw = sqrt(abs(tmp0.xw));
                    tmp2 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                    tmp2.x = tmp1.y;
                    tmp0.yz = tmp2.xy * float2(4.0, 4.0);
                    tmp0.yz = round(tmp0.yz);
                    tmp0.xy = tmp0.yz * float2(16.0, 16.0) + tmp0.xw;
                    tmp0.xy = tmp0.xy * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                    tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                    o.sv_target.zw = tmp0.xy;
                } else {
                    o.sv_target.zw = float2(0.0, 0.0);
                }
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 369268
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float2 texcoord1 : TEXCOORD1;
				float4 texcoord2 : TEXCOORD2;
				float4 texcoord3 : TEXCOORD3;
				float4 texcoord4 : TEXCOORD4;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _AreaTex;
			sampler2D _SearchTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                float4 tmp1;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                o.texcoord.xy = v.vertex.xy * float2(0.5, -0.5) + float2(0.5, 0.5);
                tmp0 = v.vertex.xyxy + float4(1.0, 1.0, 1.0, 1.0);
                tmp0 = tmp0 * float4(0.5, -0.5, 0.5, -0.5) + float4(0.0, 1.0, 0.0, 1.0);
                o.texcoord1.xy = tmp0.zw * _MainTex_TexelSize.zw;
                tmp1 = _MainTex_TexelSize * float4(-0.25, 1.25, -0.125, -0.125) + tmp0.zzww;
                tmp0 = _MainTex_TexelSize * float4(-0.125, -0.25, -0.125, 1.25) + tmp0;
                o.texcoord2 = tmp1.xzyw;
                o.texcoord3 = tmp0;
                tmp1.zw = tmp0.yw;
                o.texcoord4 = _MainTex_TexelSize * float4(-32.0, 32.0, -32.0, 32.0) + tmp1;
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
                tmp0 = tex2D(_MainTex, inp.texcoord.xy);
                tmp0.y = tmp0.y > 0.0;
                if (tmp0.y) {
                    tmp0.y = tmp0.x > 0.0;
                    if (tmp0.y) {
                        tmp1.xy = _MainTex_TexelSize.xy * float2(-1.0, 1.0);
                        tmp1.z = 1.0;
                        tmp2.xy = inp.texcoord.xy;
                        tmp3.x = 0.0;
                        tmp2.z = -1.0;
                        tmp4.x = 1.0;
                        while (true) {
                            tmp0.y = tmp2.z < 7.0;
                            tmp0.z = tmp4.x > 0.9;
                            tmp0.y = tmp0.z ? tmp0.y : 0.0;
                            if (!(tmp0.y)) {
                                break;
                            }
                            tmp2.xyz = tmp1.xyz + tmp2.xyz;
                            tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                            tmp4.x = dot(tmp3.xy, float2(0.5, 0.5));
                        }
                        tmp0.y = tmp3.x > 0.9;
                        tmp0.y = tmp0.y ? 1.0 : 0.0;
                        tmp1.x = tmp0.y + tmp2.z;
                    } else {
                        tmp1.x = 0.0;
                        tmp4.x = 0.0;
                    }
                    tmp0.yz = _MainTex_TexelSize.xy * float2(1.0, -1.0);
                    tmp0.w = 1.0;
                    tmp2.yz = inp.texcoord.xy;
                    tmp2.xw = float2(-1.0, 1.0);
                    while (true) {
                        tmp3.x = tmp2.x < 7.0;
                        tmp3.y = tmp2.w > 0.9;
                        tmp3.x = tmp3.y ? tmp3.x : 0.0;
                        if (!(tmp3.x)) {
                            break;
                        }
                        tmp2.xyz = tmp0.wyz + tmp2.xyz;
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.yz, 0, 0.0));
                        tmp2.w = dot(tmp3.xy, float2(0.5, 0.5));
                    }
                    tmp4.y = tmp2.w;
                    tmp0.y = tmp1.x + tmp2.x;
                    tmp0.y = tmp0.y > 2.0;
                    if (tmp0.y) {
                        tmp1.y = 0.25 - tmp1.x;
                        tmp1.zw = tmp2.xx * float2(1.0, -1.0) + float2(0.0, -0.25);
                        tmp2 = tmp1.yxzw * _MainTex_TexelSize + inp.texcoord.xyxy;
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                        tmp2 = tex2Dlod(_MainTex, float4(tmp2.zw, 0, 0.0));
                        tmp3.z = tmp2.x;
                        tmp0.yz = tmp3.xz * float2(5.0, 5.0) + float2(-3.75, -3.75);
                        tmp0.yz = abs(tmp0.yz) * tmp3.xz;
                        tmp0.yz = round(tmp0.yz);
                        tmp1.y = round(tmp3.y);
                        tmp1.w = round(tmp2.y);
                        tmp0.yz = tmp1.yw * float2(2.0, 2.0) + tmp0.yz;
                        tmp1.yw = tmp4.xy >= float2(0.9, 0.9);
                        tmp0.yz = tmp1.yw ? float2(0.0, 0.0) : tmp0.yz;
                        tmp0.yz = tmp0.yz * float2(20.0, 20.0) + tmp1.xz;
                        tmp0.yz = tmp0.yz * float2(0.00625, 0.0017857) + float2(0.503125, 0.0008929);
                        tmp1 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                    } else {
                        tmp1.xy = float2(0.0, 0.0);
                    }
                    tmp0.y = _MainTex_TexelSize.x * 0.25 + inp.texcoord.x;
                    tmp2.xy = -_MainTex_TexelSize.xy;
                    tmp2.z = 1.0;
                    tmp3.y = tmp0.y;
                    tmp3.z = inp.texcoord.y;
                    tmp3.xw = float2(1.0, -1.0);
                    while (true) {
                        tmp0.z = tmp3.w < 7.0;
                        tmp0.w = tmp3.x > 0.9;
                        tmp0.z = tmp0.w ? tmp0.z : 0.0;
                        if (!(tmp0.z)) {
                            break;
                        }
                        tmp3.yzw = tmp2.xyz + tmp3.yzw;
                        tmp4 = tex2Dlod(_MainTex, float4(tmp3.yz, 0, 0.0));
                        tmp0.z = tmp4.x * 5.0 + -3.75;
                        tmp0.z = abs(tmp0.z) * tmp4.x;
                        tmp5.x = round(tmp0.z);
                        tmp5.y = round(tmp4.y);
                        tmp3.x = dot(tmp5.xy, float2(0.5, 0.5));
                    }
                    tmp2.x = tmp3.w;
                    tmp4 = tex2Dlod(_MainTex, float4(inp.texcoord.xy, 0, 0.0));
                    tmp0.z = tmp4.x > 0.0;
                    if (tmp0.z) {
                        tmp4.xy = _MainTex_TexelSize.xy;
                        tmp4.z = 1.0;
                        tmp5.x = tmp0.y;
                        tmp5.y = inp.texcoord.y;
                        tmp0.z = 0.0;
                        tmp5.z = -1.0;
                        tmp3.y = 1.0;
                        while (true) {
                            tmp1.z = tmp5.z < 7.0;
                            tmp1.w = tmp3.y > 0.9;
                            tmp1.z = tmp1.w ? tmp1.z : 0.0;
                            if (!(tmp1.z)) {
                                break;
                            }
                            tmp5.xyz = tmp4.xyz + tmp5.xyz;
                            tmp6 = tex2Dlod(_MainTex, float4(tmp5.xy, 0, 0.0));
                            tmp1.z = tmp6.x * 5.0 + -3.75;
                            tmp1.z = abs(tmp1.z) * tmp6.x;
                            tmp0.w = round(tmp1.z);
                            tmp0.z = round(tmp6.y);
                            tmp3.y = dot(tmp0.xy, float2(0.5, 0.5));
                        }
                        tmp0.y = tmp0.z > 0.9;
                        tmp0.y = tmp0.y ? 1.0 : 0.0;
                        tmp2.z = tmp0.y + tmp5.z;
                    } else {
                        tmp2.z = 0.0;
                        tmp3.y = 0.0;
                    }
                    tmp0.y = tmp2.z + tmp2.x;
                    tmp0.y = tmp0.y > 2.0;
                    if (tmp0.y) {
                        tmp2.y = -tmp2.x;
                        tmp4 = tmp2.yyzz * _MainTex_TexelSize + inp.texcoord.xyxy;
                        tmp5 = tex2Dlod(_MainTex, float4(tmp4.xy, 0, 0.0));
                        tmp6 = tex2Dlod(_MainTex, float4(tmp4.xy, 0, 0.0));
                        tmp4 = tex2Dlod(_MainTex, float4(tmp4.zw, 0, 0.0));
                        tmp6.x = tmp5.y;
                        tmp6.yw = tmp4.yx;
                        tmp0.yz = tmp6.xy * float2(2.0, 2.0) + tmp6.zw;
                        tmp1.zw = tmp3.xy >= float2(0.9, 0.9);
                        tmp0.yz = tmp1.zw ? float2(0.0, 0.0) : tmp0.yz;
                        tmp0.yz = tmp0.yz * float2(20.0, 20.0) + tmp2.xz;
                        tmp0.yz = tmp0.yz * float2(0.00625, 0.0017857) + float2(0.503125, 0.0008929);
                        tmp2 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                        tmp1.xy = tmp1.xy + tmp2.yx;
                    }
                    tmp0.y = -tmp1.y == tmp1.x;
                    if (tmp0.y) {
                        tmp2.xy = inp.texcoord2.xy;
                        tmp2.z = 1.0;
                        tmp3.x = 0.0;
                        while (true) {
                            tmp0.y = inp.texcoord4.x < tmp2.x;
                            tmp0.z = tmp2.z > 0.8281;
                            tmp0.y = tmp0.z ? tmp0.y : 0.0;
                            tmp0.z = tmp3.x == 0.0;
                            tmp0.y = tmp0.z ? tmp0.y : 0.0;
                            if (!(tmp0.y)) {
                                break;
                            }
                            tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                            tmp2.xy = _MainTex_TexelSize.xy * float2(-2.0, -0.0) + tmp2.xy;
                            tmp2.z = tmp3.y;
                        }
                        tmp3.yz = tmp2.xz;
                        tmp0.yz = tmp3.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                        tmp2 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                        tmp0.y = tmp2.w * -2.007874 + 3.25;
                        tmp2.x = _MainTex_TexelSize.x * tmp0.y + tmp3.y;
                        tmp2.y = inp.texcoord3.y;
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                        tmp4.xy = inp.texcoord2.zw;
                        tmp4.z = 1.0;
                        tmp5.x = 0.0;
                        while (true) {
                            tmp0.y = tmp4.x < inp.texcoord4.y;
                            tmp0.z = tmp4.z > 0.8281;
                            tmp0.y = tmp0.z ? tmp0.y : 0.0;
                            tmp0.z = tmp5.x == 0.0;
                            tmp0.y = tmp0.z ? tmp0.y : 0.0;
                            if (!(tmp0.y)) {
                                break;
                            }
                            tmp5 = tex2Dlod(_MainTex, float4(tmp4.xy, 0, 0.0));
                            tmp4.xy = _MainTex_TexelSize.xy * float2(2.0, 0.0) + tmp4.xy;
                            tmp4.z = tmp5.y;
                        }
                        tmp5.yz = tmp4.xz;
                        tmp0.yz = tmp5.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                        tmp4 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                        tmp0.y = tmp4.w * -2.007874 + 3.25;
                        tmp2.z = -_MainTex_TexelSize.x * tmp0.y + tmp5.y;
                        tmp4 = _MainTex_TexelSize * tmp2.zxzx + -inp.texcoord1.xxxx;
                        tmp4 = round(tmp4);
                        tmp0.yz = sqrt(abs(tmp4.wz));
                        tmp5 = tex2Dlod(_MainTex, float4(tmp2.zy, 0, 0.0));
                        tmp5.x = tmp3.x;
                        tmp1.zw = tmp5.xy * float2(4.0, 4.0);
                        tmp1.zw = round(tmp1.zw);
                        tmp0.yz = tmp1.zw * float2(16.0, 16.0) + tmp0.yz;
                        tmp0.yz = tmp0.yz * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                        tmp3 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                        tmp4 = abs(tmp4) >= abs(tmp4.wzwz);
                        tmp4 = tmp4 ? 1.0 : 0.0;
                        tmp0.y = tmp4.y + tmp4.x;
                        tmp0.yz = tmp4.zw / tmp0.yy;
                        tmp2.w = inp.texcoord.y;
                        tmp4 = tex2Dlod(_MainTex, float4(tmp2.xw, 0, 0.0));
                        tmp0.w = -tmp0.y * tmp4.x + 1.0;
                        tmp4 = tex2Dlod(_MainTex, float4(tmp2.zw, 0, 0.0));
                        tmp4.x = saturate(-tmp0.z * tmp4.x + tmp0.w);
                        tmp5 = tex2Dlod(_MainTex, float4(tmp2.xw, 0, 0.0));
                        tmp0.y = -tmp0.y * tmp5.x + 1.0;
                        tmp2 = tex2Dlod(_MainTex, float4(tmp2.zw, 0, 0.0));
                        tmp4.y = saturate(-tmp0.z * tmp2.x + tmp0.y);
                        o.sv_target.xy = tmp3.xy * tmp4.xy;
                    } else {
                        o.sv_target.xy = tmp1.xy;
                        tmp0.x = 0.0;
                    }
                } else {
                    o.sv_target.xy = float2(0.0, 0.0);
                }
                tmp0.x = tmp0.x > 0.0;
                if (tmp0.x) {
                    tmp0.xy = inp.texcoord3.xy;
                    tmp0.z = 1.0;
                    tmp1.x = 0.0;
                    while (true) {
                        tmp0.w = inp.texcoord4.z < tmp0.y;
                        tmp2.x = tmp0.z > 0.8281;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        tmp2.x = tmp1.x == 0.0;
                        tmp0.w = tmp0.w ? tmp2.x : 0.0;
                        if (!(tmp0.w)) {
                            break;
                        }
                        tmp1 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                        tmp0.xy = _MainTex_TexelSize.xy * float2(-0.0, -2.0) + tmp0.xy;
                        tmp0.z = tmp1.y;
                    }
                    tmp1.yz = tmp0.yz;
                    tmp0.xy = tmp1.xz * float2(0.5, -2.0) + float2(0.0078125, 2.03125);
                    tmp0 = tex2Dlod(_MainTex, float4(tmp0.xy, 0, 0.0));
                    tmp0.x = tmp0.w * -2.007874 + 3.25;
                    tmp0.x = _MainTex_TexelSize.y * tmp0.x + tmp1.y;
                    tmp0.y = inp.texcoord2.x;
                    tmp1 = tex2Dlod(_MainTex, float4(tmp0.yx, 0, 0.0));
                    tmp2.xy = inp.texcoord3.zw;
                    tmp2.z = 1.0;
                    tmp3.x = 0.0;
                    while (true) {
                        tmp1.x = tmp2.y < inp.texcoord4.w;
                        tmp1.z = tmp2.z > 0.8281;
                        tmp1.x = tmp1.z ? tmp1.x : 0.0;
                        tmp1.z = tmp3.x == 0.0;
                        tmp1.x = tmp1.z ? tmp1.x : 0.0;
                        if (!(tmp1.x)) {
                            break;
                        }
                        tmp3 = tex2Dlod(_MainTex, float4(tmp2.xy, 0, 0.0));
                        tmp2.xy = _MainTex_TexelSize.xy * float2(0.0, 2.0) + tmp2.xy;
                        tmp2.z = tmp3.y;
                    }
                    tmp3.yz = tmp2.yz;
                    tmp1.xz = tmp3.xz * float2(0.5, -2.0) + float2(0.5234375, 2.03125);
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xz, 0, 0.0));
                    tmp1.x = tmp2.w * -2.007874 + 3.25;
                    tmp0.z = -_MainTex_TexelSize.y * tmp1.x + tmp3.y;
                    tmp2 = _MainTex_TexelSize * tmp0.zxzx + -inp.texcoord1.yyyy;
                    tmp2 = round(tmp2);
                    tmp1.xz = sqrt(abs(tmp2.wz));
                    tmp3 = tex2Dlod(_MainTex, float4(tmp0.yz, 0, 0.0));
                    tmp3.x = tmp1.y;
                    tmp1.yw = tmp3.xy * float2(4.0, 4.0);
                    tmp1.yw = round(tmp1.yw);
                    tmp1.xy = tmp1.yw * float2(16.0, 16.0) + tmp1.xz;
                    tmp1.xy = tmp1.xy * float2(0.00625, 0.0017857) + float2(0.003125, 0.0008929);
                    tmp1 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                    tmp2 = abs(tmp2) >= abs(tmp2.wzwz);
                    tmp2 = tmp2 ? 1.0 : 0.0;
                    tmp0.y = tmp2.y + tmp2.x;
                    tmp1.zw = tmp2.zw / tmp0.yy;
                    tmp0.w = inp.texcoord.x;
                    tmp2 = tex2Dlod(_MainTex, float4(tmp0.wx, 0, 0.0));
                    tmp0.y = -tmp1.z * tmp2.y + 1.0;
                    tmp2 = tex2Dlod(_MainTex, float4(tmp0.wz, 0, 0.0));
                    tmp2.z = saturate(-tmp1.w * tmp2.y + tmp0.y);
                    tmp3 = tex2Dlod(_MainTex, float4(tmp0.wx, 0, 0.0));
                    tmp0.x = -tmp1.z * tmp3.y + 1.0;
                    tmp3 = tex2Dlod(_MainTex, float4(tmp0.wz, 0, 0.0));
                    tmp2.w = saturate(-tmp1.w * tmp3.y + tmp0.x);
                    o.sv_target.zw = tmp1.xy * tmp2.zw;
                } else {
                    o.sv_target.zw = float2(0.0, 0.0);
                }
                return o;
			}
			ENDCG
		}
		Pass {
			ZTest Always
			ZWrite Off
			Cull Off
			GpuProgramID 422248
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			
			#include "UnityCG.cginc"
			struct v2f
			{
				float4 position : SV_POSITION0;
				float2 texcoord : TEXCOORD0;
				float4 texcoord1 : TEXCOORD1;
			};
			struct fout
			{
				float4 sv_target : SV_Target0;
			};
			// $Globals ConstantBuffers for Vertex Shader
			float4 _MainTex_TexelSize;
			// $Globals ConstantBuffers for Fragment Shader
			// Custom ConstantBuffers for Vertex Shader
			// Custom ConstantBuffers for Fragment Shader
			// Texture params for Vertex Shader
			// Texture params for Fragment Shader
			sampler2D _MainTex;
			sampler2D _BlendTex;
			
			// Keywords: 
			v2f vert(appdata_full v)
			{
                v2f o;
                float4 tmp0;
                o.position.xy = v.vertex.xy;
                o.position.zw = float2(0.0, 1.0);
                tmp0.xy = v.vertex.xy + float2(1.0, 1.0);
                tmp0.xy = tmp0.xy * float2(0.5, -0.5) + float2(0.0, 1.0);
                o.texcoord.xy = tmp0.xy;
                o.texcoord1 = _MainTex_TexelSize * float4(1.0, 0.0, 0.0, 1.0) + tmp0.xyxy;
                return o;
			}
			// Keywords: 
			fout frag(v2f inp)
			{
                fout o;
                float4 tmp0;
                float4 tmp1;
                float4 tmp2;
                tmp0 = tex2D(_MainTex, inp.texcoord1.xy);
                tmp1 = tex2D(_MainTex, inp.texcoord1.zw);
                tmp2 = tex2D(_MainTex, inp.texcoord.xy);
                tmp2.x = tmp0.w;
                tmp2.y = tmp1.y;
                tmp0.x = dot(tmp2, float4(1.0, 1.0, 1.0, 1.0));
                tmp0.x = tmp0.x < 0.00001;
                if (tmp0.x) {
                    o.sv_target = tex2Dlod(_MainTex, float4(inp.texcoord.xy, 0, 0.0));
                } else {
                    tmp0.x = max(tmp0.w, tmp2.z);
                    tmp0.y = max(tmp2.w, tmp2.y);
                    tmp0.x = tmp0.y < tmp0.x;
                    tmp1.x = tmp0.x ? tmp0.w : 0.0;
                    tmp1.z = tmp0.x ? tmp2.z : 0.0;
                    tmp1.yw = tmp0.xx ? float2(0.0, 0.0) : tmp2.yw;
                    tmp2.x = tmp0.x ? tmp0.w : tmp2.y;
                    tmp2.y = tmp0.x ? tmp2.z : tmp2.w;
                    tmp0.x = dot(tmp2.xy, float2(1.0, 1.0));
                    tmp0.xy = tmp2.xy / tmp0.xx;
                    tmp2 = _MainTex_TexelSize * float4(1.0, 1.0, -1.0, -1.0);
                    tmp1 = tmp1 * tmp2 + inp.texcoord.xyxy;
                    tmp2 = tex2Dlod(_MainTex, float4(tmp1.xy, 0, 0.0));
                    tmp1 = tex2Dlod(_MainTex, float4(tmp1.zw, 0, 0.0));
                    tmp1 = tmp0.yyyy * tmp1;
                    o.sv_target = tmp0.xxxx * tmp2 + tmp1;
                }
                return o;
			}
			ENDCG
		}
	}
}