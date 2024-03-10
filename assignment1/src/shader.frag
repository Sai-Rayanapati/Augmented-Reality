#version 330 core

in vec2 TexCoord;

out vec4 FragColor;

uniform sampler2D diffuseTexture;

void main() {
    // Sample diffuse color from the texture
    vec4 textureColour = texture(diffuseTexture, TexCoord);

    // Output the sampled color
    FragColor = textureColour;
}
