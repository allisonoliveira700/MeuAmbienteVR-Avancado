=====================================================
  MEU PRIMEIRO AMBIENTE VR
  Residência em TIC 29 — Projeto Final Fase 1
=====================================================

DESCRIÇÃO DO PROJETO
---------------------
Ambiente virtual em primeira pessoa desenvolvido em Unity 6
utilizando o Meta XR SDK. O projeto simula uma sala de estar
moderna e navegável, com mobiliário, iluminação e interação
básica via teclado e mouse.

COMO EXECUTAR NO UNITY EDITOR
------------------------------
1. Abra o Unity Hub
2. Clique em "Add project from disk" e selecione esta pasta
3. Aguarde o Unity carregar todos os assets
4. Abra a cena: Assets > StreamingAssets > MainScene
5. Clique no botão Play (▶) no topo do Editor
6. Use os controles abaixo para navegar

CONTROLES (PC)
--------------
  W / Seta cima    — Mover para frente
  S / Seta baixo   — Mover para trás
  A / Seta esq.    — Mover para esquerda
  D / Seta dir.    — Mover para direita
  Shift (esquerdo) — Correr
  Mouse            — Olhar ao redor
  Escape           — Liberar cursor do mouse

ESTRUTURA DO PROJETO
---------------------
  Assets/
  ├── Oculus/          — Meta XR SDK
  ├── Resources/       — Materiais e texturas criados
  ├── Script/          — Scripts C# do projeto
  │   └── PlayerMovement.cs
  ├── StreamingAssets/ — Cena principal (MainScene)
  └── XR/              — Configurações XR

  ProjectSettings/     — Configurações do projeto Unity
  Packages/            — Dependências e pacotes

CENA: SALA DE ESTAR
--------------------
A cena representa uma sala de estar com os seguintes elementos:
  - Sofás e poltronas
  - Mesa de centro e mesa de jantar com cadeiras
  - Luminária decorativa
  - Quadro na parede
  - Vaso decorativo
  - Iluminação direcional e pontual

REQUISITOS TÉCNICOS
--------------------
  - Unity 6 (6000.0 LTS) ou superior
  - Meta XR SDK instalado
  - Android Build Support (para build no Meta Quest)
  - XR Plugin Management configurado com OpenXR

APRENDIZADOS E DIFICULDADES
-----------------------------
Durante o desenvolvimento deste projeto foram aplicados os
seguintes conceitos:

  - Configuração do ambiente Unity para XR/VR
  - Instalação e configuração do Meta XR SDK
  - Criação e organização de cenas 3D
  - Importação e posicionamento de assets 3D
  - Criação de materiais e aplicação de cores
  - Programação de movimentação em C# com CharacterController
  - Controle de câmera em primeira pessoa com mouse
  - Configuração de iluminação (Directional Light + Point Light)
  - Organização de hierarquia de objetos
  - Configuração de Build Settings para Android (Meta Quest)

DESENVOLVIDO POR
-----------------
  Aluno: [Allison Oliveira]
  Curso: Residência em TIC 29
  Módulo: Realidade Virtual — Fase 1
  Data: 2026

=====================================================
