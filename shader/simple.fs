#version 330 core

uniform vec4 ourColor; //uniform 변수
out vec4 fragColor; // 최종 출력 색상

void main(){
    fragColor = ourColor;
}