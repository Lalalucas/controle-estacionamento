<p align="center">
  <a href="#" title="Controle de Estacionamento Avançado">
    <img src="https://user-images.githubusercontent.com/58760049/204286144-8355b343-85f2-430c-9944-8848148b6feb.png" alt="Car Icon" width="100">
  </a>
</p>

<h1 align="center">🚗 Controle de Estacionamento Avançado 🚗</h1>

<p align="center">
  <strong>Um sistema de gestão de estacionamento robusto, profissional e multiplataforma, pronto para automação, controle financeiro e relatórios detalhados.</strong>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/C%23-11.0-512BD4?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C# 11">
  <img src="https://img.shields.io/badge/.NET_/_Mono-Multiplatform-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET/Mono">
  <img src="https://img.shields.io/badge/Plataformas-Linux_|_Windows_|_macOS-blue?style=for-the-badge&logo=linux&logoColor=white" alt="Platforms">
  <img src="https://img.shields.io/badge/Status-Ativo-brightgreen?style=for-the-badge" alt="Status: Ativo">
</p>

---

## 🎯 Sobre o Projeto

O **Controle de Estacionamento Avançado** nasceu da necessidade de criar uma solução completa e moderna para a gestão de estacionamentos. O sistema foi projetado com foco em eficiência operacional e flexibilidade financeira, oferecendo:

🅿️ **Registro Completo de Veículos:** Cadastro detalhado com nome do proprietário, CPF, placa e controle preciso de horários de entrada e saída.
💰 **Controle de Pagamentos Digital:** Aceita os métodos de pagamento mais modernos, incluindo PIX, Cartão de Crédito/Débito e até Criptomoedas.
📊 **Relatórios Detalhados:** Métricas essenciais para o negócio, como faturamento diário, semanal, mensal e histórico completo de veículos.
📱 **Portabilidade Total:** Desenvolvido para rodar em qualquer ambiente, seja **Termux/Linux**, **Windows** ou **MacOS**, garantindo máxima compatibilidade.

Este projeto é uma ferramenta poderosa para profissionais, um laboratório digital para entusiastas e um excelente case de estudo para estudantes de C#.

---

## ✨ Funcionalidades em Destaque

| Funcionalidade | Descrição Detalhada |
| :--- | :--- |
| ➕ **Adicionar Veículo** | Realiza o registro completo do veículo e do proprietário, marcando o horário exato de entrada para um cálculo de permanência preciso. |
| ➖ **Remover Veículo** | Calcula automaticamente o tempo de permanência, gera o valor a ser pago e registra a saída, atualizando o status da vaga. |
| 💳 **Pagamentos Digitais** | Oferece flexibilidade máxima ao cliente, com suporte integrado para PIX, Cartão (Crédito/Débito) e Criptomoedas. |
| 📈 **Relatórios Gerenciais** | Gera relatórios financeiros (diário, semanal, mensal) e operacionais (fluxo de veículos), essenciais para a tomada de decisão. |
| 🛡️ **Logs e Auditoria** | Cada transação de pagamento e evento importante é registrado no arquivo `registro_pagamentos.txt`, garantindo total rastreabilidade. |
| 💻 **Interface Intuitiva** | Um menu de console limpo e direto facilita a operação do sistema em qualquer plataforma, sem a necessidade de interfaces gráficas. |

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Finalidade |
| :--- | :--- |
| 🔷 **C# / .NET / Mono** | Linguagem principal e frameworks que garantem a performance e a portabilidade do sistema entre Windows, Linux e macOS. |
| 🏗️ **POO (Programação Orientada a Objetos)** | Arquitetura baseada em objetos para um código modular, limpo, de fácil manutenção e altamente escalável. |
| 🤖 **Automação (Bash Script)** | Scripts para compilação e execução rápidas em ambientes como Termux e Linux, otimizando o fluxo de trabalho. |
| 💸 **Gestão de Pagamentos** | Lógica de negócio implementada para processar diferentes formas de pagamento e calcular valores de forma precisa. |
| 📝 **Logging Avançado** | Sistema de registro em arquivos de texto (`.txt`) para auditoria, rastreabilidade e análise de dados históricos. |

---

## 📂 Estrutura do Projeto

A arquitetura do projeto foi organizada para promover a separação de responsabilidades e a clareza do código.