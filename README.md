# 🥽 Meu Ambiente VR — Avançado

> **Projeto Final Avançado — Residência em TIC 29**  
> Ambiente virtual interativo em primeira pessoa desenvolvido com Unity 6 e Meta XR SDK.

---

## 📋 Descrição

Este projeto é a evolução do ambiente VR desenvolvido na Fase 1 da Residência em TIC 29. Trata-se de uma **sala de estar virtual navegável em primeira pessoa**, com mobiliário, iluminação e interações implementadas via teclado e mouse.

Na versão avançada, foram adicionados novos elementos que enriquecem o realismo e a interatividade da cena:

- 🏠 **Teto** — estrutura que completa o ambiente fechado da sala
- 💡 **Luminária interativa** — luminária suspensa que pode ser acionada pelo usuário
- 🔌 **Cabo da luminária** — elemento visual que conecta a luminária ao teto, aumentando o realismo da cena

---

## 🚀 Como executar no Unity Editor

1. Abra o **Unity Hub**
2. Clique em **"Add project from disk"** e selecione esta pasta
3. Aguarde o Unity carregar todos os assets
4. Abra a cena: `Assets > StreamingAssets > MainScene`
5. Clique no botão **Play (▶)** no topo do Editor
6. Use os controles abaixo para navegar

---

## 🎮 Controles (PC)

| Tecla | Ação |
|---|---|
| `W` / `↑` | Mover para frente |
| `S` / `↓` | Mover para trás |
| `A` / `←` | Mover para esquerda |
| `D` / `→` | Mover para direita |
| `Shift` (esquerdo) | Correr |
| `Mouse` | Olhar ao redor |
| `E` | Interagir com a luminária |
| `Escape` | Liberar cursor do mouse |

---

## 📁 Estrutura do Projeto

```
Assets/
├── Oculus/             — Meta XR SDK
├── Resources/          — Materiais e texturas criados
├── Script/             — Scripts C# do projeto
│   ├── PlayerMovement.cs
│   └── LampadaInterativa.cs
├── StreamingAssets/    — Cena principal (MainScene)
└── XR/                 — Configurações XR

ProjectSettings/        — Configurações do projeto Unity
Packages/               — Dependências e pacotes
```

---

## 🛋️ Elementos da Cena

A cena representa uma sala de estar com os seguintes elementos:

| Elemento | Descrição |
|---|---|
| Sofás e poltronas | Mobiliário principal da sala |
| Mesa de centro e jantar | Com cadeiras ao redor |
| **Teto** ⭐ *novo* | Estrutura que fecha o ambiente da sala |
| **Luminária interativa** ⭐ *novo* | Luminária suspensa acionável pelo jogador |
| **Cabo da luminária** ⭐ *novo* | Cabo visual conectando a luminária ao teto |
| Quadro na parede | Elemento decorativo |
| Vaso decorativo | Elemento decorativo |
| Iluminação | Direcional e pontual |

---

## ⚙️ Requisitos Técnicos

- **Unity 6** (6000.0 LTS) ou superior
- **Meta XR SDK** instalado
- **Android Build Support** (para build no Meta Quest)
- **XR Plugin Management** configurado com OpenXR

---

## 🧠 Aprendizados e Novidades desta Versão

Na versão avançada do projeto foram aplicados e expandidos os seguintes conceitos:

**Base (Fase 1):**
- Configuração do ambiente Unity para XR/VR
- Instalação e configuração do Meta XR SDK
- Criação e organização de cenas 3D
- Importação e posicionamento de assets 3D
- Criação de materiais e aplicação de cores
- Programação de movimentação em C# com `CharacterController`
- Controle de câmera em primeira pessoa com mouse
- Configuração de iluminação (`Directional Light` + `Point Light`)
- Organização de hierarquia de objetos
- Build Settings para Android (Meta Quest)

**Avançado (esta versão):**
- Modelagem e posicionamento de teto para fechar o ambiente
- Criação de luminária suspensa com cabo conectado ao teto
- Implementação de **interação por proximidade** (ligar/desligar luminária)
- Controle dinâmico de luz via script C#

---

## 👨‍💻 Desenvolvido por

| Campo | Info |
|---|---|
| Aluno | Allison Oliveira |
| Curso | Residência em TIC 29 |
| Módulo | Realidade Virtual — Fase Avançada |
| Ano | 2026 |
| Repositório original (Fase 1) | [MeuAmbienteVR](https://github.com/allisonoliveira700) |

---

*Projeto desenvolvido para fins educacionais na Residência em TIC 29.*
