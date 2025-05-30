# Semáforo com Windows Forms e Imagens 🚦

Este projeto é uma simulação visual de um semáforo utilizando **C# e Windows Forms**. O semáforo alterna entre os estados **vermelho, verde e amarelo** com base em temporizadores. A interface é gráfica e utiliza imagens para representar cada luz do semáforo.

## 🖼️ Funcionalidades

- Início e parada do ciclo do semáforo com um botão.
- Ciclo de luzes com tempos definidos:
  - 🔴 Vermelho: 30 segundos
  - 🟢 Verde: 30 segundos
  - 🟡 Amarelo: 10 segundos
- Alteração automática de imagem de acordo com o estado atual do semáforo.
- Interface amigável e visual com `PictureBox`.

## 🛠️ Tecnologias Utilizadas

- C# (.NET Framework)
- Windows Forms (WinForms)
- Visual Studio
- Imagens de semáforo adicionadas via `Resources`

## 📁 Estrutura de Pastas

SemaforoWFA_Imagens/
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── Properties/
│ ├── Resources.resx # Imagens do semáforo
│ ├── Resources.Designer.cs
├── bin/
├── obj/


## 🖼️ Recursos Visuais

As imagens do semáforo devem estar no diretório `Properties > Resources` com os seguintes nomes:

- `verde.png`
- `amarelo.png`
- `vermelho.png`
- `apagado.png`

Você pode adicionar essas imagens ao projeto pelo painel **Resources** do Visual Studio.

## ▶️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/semaforo-wfa-imagens.git
