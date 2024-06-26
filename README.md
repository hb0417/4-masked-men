<div align="center"><h1> RuningGame</h1>
</div>


# 목차
1. [프로젝트 소개](#프로젝트-소개)
2. [팀소개](#팀소개)
3. [프로젝트 계기](#프로젝트-계기)
4. [주요기능](#주요기능)
5. [개발기간](#개발기간)
6. [기술스택](#기술스택)
7. [와이어프레임](#와이어프레임)
8. [Trouble Shooting](#trouble-shooting)

# 프로젝트 소개
 - 프로젝트 이름 : 4 Masked Man
 - 개발언어 및 엔진 : C#, 유니티2D 
 - ## 게임 설명
    클릭으로 보스를 처치해서, 우리의 프로필사진을 되찾아주자!!
   
# 팀소개
 - 팀장 : 황원강
 - 팀원 : 홍성우
 - 팀원 : 문경건
 - 팀원 : 여현빈

# 프로젝트 계기
 팀원전체가 프로필사진이 없는걸 보고 제작하였습니다.
 
# 주요기능
 - 플레이어의 공격
 - 플레이어 공격강화 시스템
 - 펫 시스템
 - 아이템(프로필사진) 인벤토리 시스템

# 개발기간
 개발 기간 : 2024.19. ~ 2024.06.26
 
# 기술스택
|![image](https://github.com/choiyunhwa/RuningGame/assets/82863756/bca72594-c744-4bfe-9432-a59b58a16295)|![image](https://github.com/choiyunhwa/RuningGame/assets/82863756/ab527bb2-a85d-45c6-9036-faa7533520ce)|![image](https://github.com/choiyunhwa/RuningGame/assets/82863756/e53fce63-6924-40f1-83fa-8055a89bc352)|![image](https://github.com/choiyunhwa/RuningGame/assets/82863756/80297e45-d969-4ffc-bd03-0235beb3ed23)
|:---:|:---:|:---:|:---:|
|Unity|C#|VisualStudio|GitHub|

# 와이어프레임
![image](https://github.com/hb0417/4-masked-men/assets/82863756/808083e3-dca6-489e-85f6-2d5015b17579)

# Trouble Shooting
황원강
문제 : 마스크 효과가 제대로 적용 되지 않음
해결 : 폰트가 문제가 있는 것으로 확인. 폰트를 바꿈으로서 해결함.

홍성우
문제 : 사진 선택 창의 초기화 문제.
해결 : 보스가 죽는 부분에 델리게이트로 이벤트를 추가해주어 리스트의 마지막에 추가된 사진을 등록해주는 것으로 해결

문경건
문제 : 능력치 강화상점을 디자인패턴 사용 및 동적생성을 함에 있어서 컨테이너 크기 조절 및 GameObject 생성 문제
해결 : abillitySoList 의 Count 만큼 SetSizeWithCurrentAnchors() 함수로 container의 크기를 조절한뒤 gameobject를 생성하고 AbillitySO 정보를 넣어준다.

여현빈
문제 : UI에 구현 과정에서 특정 기능 구현에 막히거나 한가지 작업에 소요시간이 오래걸려서 정해진 시간내에서 작업 구현을 하지 못하여서 프로젝트 전체적인 작업속도에 차질이 있었습니다.
해결 : 다른 조원의 도움으로 막히는 부분에 해결에 도움을 받았으며 오래걸리는 작업은 다른 작업과 겹치는 같이 만드는것으로 시간이 단축되었습니다.
