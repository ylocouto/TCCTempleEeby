Shader "Custom/1 - black phantom"
{
    Properties {
      _MainTex ("Texture", 2D) = "black" {}
      _BumpMap ("BumpMap", 2D) = "bump" {}
      _RimCor ("Cor", Color) = (1,0,0,0)
      _RimForca ("Força", Range(0,10)) = 3
    }
    SubShader {
      Tags { "RenderType" = "Opaque" }
      CGPROGRAM
      #pragma surface surf Lambert
      
	  sampler2D _MainTex;
      sampler2D _BumpMap;
      
      struct Input 
	  {
          float2 uv_MainTex;
          float2 uv_BumpMap;
          float3 viewDir;
      };
      
	  
	  float4 _RimCor;
      float _RimForca;

	  void surf (Input IN, inout SurfaceOutput o) 
	  {
          o.Albedo = tex2D (_MainTex, IN.uv_MainTex).rgb;
          o.Normal = UnpackNormal (tex2D (_BumpMap, IN.uv_BumpMap));
          half rim = 1.0 - saturate(dot (normalize(IN.viewDir), o.Normal));
          o.Emission = _RimCor.rgb * pow(rim, _RimForca);
      }
      ENDCG
    } 
    Fallback "Diffuse"
  }