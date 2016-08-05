#version 150 core

in vec3 Color;
in vec2 Texcoord;
out vec4 outColor;

//uniform sampler2D texKitten;
//uniform sampler2D texPuppy;
uniform sampler2D myTexture;
void main()
{
    //outColor = mix(texture(texKitten, Texcoord), texture(texPuppy, Texcoord), 0.5);
    outColor = texture(myTexture, Texcoord);
}
