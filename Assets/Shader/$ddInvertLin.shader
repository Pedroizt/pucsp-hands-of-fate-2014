//ddInvertLin shader: Daniel DeEntremont
//Only works correctly in Linear Color space
//Apply this shader to a mesh and watch all pixels behind the mesh become inverted!
Shader "ddShaders/ddInvertLin" {
    Properties
        {
            _Color ("Tint Color", Color) = (1,1,1,1)
        }
       
        SubShader
        {
            Tags { "Queue"="Transparent" }
     
            Pass
            {
            Cull Off
               ZWrite On
               ColorMask 0
            }
			Pass
			{
			
			Cull Off
				Blend OneMinusDstColor OneMinusSrcAlpha //invert blending, so long as FG color is 1,1,1,1
				BlendOp Add
				SetTexture [_Color] 
				{
					constantColor [_Color]
					combine constant
				}
			}
			
			Pass //this and following Passes are used for gamma correction
			{
			
			Cull Off
			
				Blend Zero DstColor  //multiplies (newly created) bg by itself to simulate a de-gamma in linear color space
				BlendOp Add
				SetTexture [_Color] 
				{constantColor (1,1,1,1)
				combine constant}
			}
			Pass
			{
			
			Cull Off
				Blend Zero DstColor  //multiplies (newly created) bg by itself to simulate a de-gamma in linear color space
				BlendOp Add
				SetTexture [_Color] 
				{constantColor (1,1,1,1)
				combine constant}
			}
			
			
         }//end subshader
}//end shader