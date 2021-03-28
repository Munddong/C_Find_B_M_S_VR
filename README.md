# C_Find_B_M_S_VR
#3. 신체, 감각, 기억을 찾는 게임(VR)

**설명사진은 Unity 사용**

## 1. 개발 계기

```
2019년 3학년 1학기 첫 Android VR 게임 개발
가상현실프로그래밍 과목을 수강, 텀 프로젝트를 하기 위해 3명이 팀을 이루고 개발.
'VR'은 가상의 세계에서 사람이 실체와 같은 체험할 할 수 있도록 하는 기술.
Cardboard를 끼고 몰입도를 선사해 주기 위해 만든 게임.
```

## 2. 역할

```
게임 기획 및 구상, 스크립트 작성, 파티클, 이펙트 구현, 시현 동영상 편집 등
```

## 3. 구현한 것

```
- 맵 제작(기억 파트)
- 횃불 이펙트
- 계산기
- 일시정지
- 랜덤 생성(맵, 비밀번호 힌트)
- Etc
```

## 4. 키 조작

OTG 케이블을 이용 -> Cardboard + 마우스를 활용.
```
선택 : 커서로 선택할 버튼을 2초간 응시
```
![녹화_2021_03_28_16_51_55_41](https://user-images.githubusercontent.com/81169838/112745799-f1af1c80-8fe5-11eb-89c2-4857fc45befa.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
```
이동 : 마우스 Left Click
```
![녹화_2021_03_28_16_56_16_447](https://user-images.githubusercontent.com/81169838/112745885-89ad0600-8fe6-11eb-92ec-7f3a1ce73145.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
```
점프 : 마우스 Right Click
```
![녹화_2021_03_28_16_58_10_818](https://user-images.githubusercontent.com/81169838/112745941-d2fd5580-8fe6-11eb-9124-756c3348337e.gif)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
```
일시정지 : 마우스 Scroll
```
![녹화_2021_03_28_17_11_10_687](https://user-images.githubusercontent.com/81169838/112746258-a0ecf300-8fe8-11eb-9707-993de40dbdc0.gif)

## 5. 게임

![녹화_2021_03_28_17_14_21_588](https://user-images.githubusercontent.com/81169838/112746347-16f15a00-8fe9-11eb-9096-8fe694812a70.gif)
```
앱 실행 후 간단한 설명과 시작 선택 -> Maze1 씬으로 넘어감.
※ 종료 선택 -> 앱 종료.
```
* 핵심 코드(선택)

![image](https://user-images.githubusercontent.com/81169838/112746466-e2ca6900-8fe9-11eb-87f5-e01a5ea94141.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![image](https://user-images.githubusercontent.com/81169838/112746542-608e7480-8fea-11eb-9979-7c968bf0cad4.png)
```
Maze1 씬에는 4개의 맵이 있으며 랜덤으로 생성.
```
* 핵심 코드(맵 랜덤)

![image](https://user-images.githubusercontent.com/81169838/112746605-cb3fb000-8fea-11eb-8515-097bc390d895.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
![녹화_2021_03_28_17_34_35_239](https://user-images.githubusercontent.com/81169838/112746772-0c848f80-8fec-11eb-824d-86ccf2ead78d.gif)
```
힌트와 숫자를 찾고 힌트 물체와 충돌 -> Boss1 씬으로 넘어감
※ 주인공은 B(Body), M(Memory), S(Sense)가 없는 상태 -> 지형지물을 통과 할 수 있음.
```
* 핵심 코드 및 적용(숫자 랜덤(저장), 알파 값(두 팔), 콜라이더 X(건물) )

![image](https://user-images.githubusercontent.com/81169838/112746987-7cdfe080-8fed-11eb-9929-2c28d286aa38.png)
![image](https://user-images.githubusercontent.com/81169838/112746912-1ce93a00-8fed-11eb-86b5-6a08866f35b8.png)
![image](https://user-images.githubusercontent.com/81169838/112747019-b3b5f680-8fed-11eb-97b3-ec02f132f206.png)
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
