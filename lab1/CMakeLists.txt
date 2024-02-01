cmake_minimum_required(VERSION 3.0)
project(lab1)

find_package(OpenGL REQUIRED)
set(CMAKE_LIBRARY_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}")
set(CMAKE_RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}")
set(CMAKE_ARCHIVE_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}")

add_subdirectory(external)

include_directories(
	external/glfw-3.1.2/include/
	external/glm-0.9.7.1/
	external/glad-opengl-3.3/include/
	.
)

add_executable(lab1_window
	lab1/lab1_window.cpp
)
target_link_libraries(lab1_window
	${OPENGL_LIBRARY}
	glfw
)

add_executable(lab1_triangle
	lab1/lab1_triangle.cpp
)
target_link_libraries(lab1_triangle
	${OPENGL_LIBRARY}
	glfw
	glad
)
