#version 330 core

layout(location = 0) in vec3 pos;
layout(location = 1) in vec2 tex;
layout(location = 2) in vec3 norm;

// Output variables
out vec2 TexCoord;
out vec3 Normal;

// Uniform matrices
uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

void main()
{
    vec4 worldPos = model * vec4(pos, 1.0);
    gl_Position = projection * view * worldPos;

    TexCoord = tex;
    Normal = mat3(transpose(inverse(model))) * norm;
}
