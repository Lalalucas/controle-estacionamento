🚗 Controle de Estacionamento Avançado


  

> Sistema de gestão de estacionamento robusto, profissional e multiplataforma, pronto para automação, controle financeiro e relatórios detalhados.




---

🌟 Introdução

O Controle de Estacionamento Avançado nasceu da necessidade de criar um sistema completo de gestão para estacionamentos, com foco em:

Registro completo de veículos: nome do proprietário, CPF, placa, horários de entrada e saída.

Controle de pagamentos digital: PIX, Cartão de Crédito/Débito e Criptomoedas.

Relatórios detalhados: faturamento diário, semanal e mensal, além de histórico de veículos.

Portabilidade e compatibilidade: funciona em Termux/Linux, Windows e MacOS via Mono/.NET.


Este projeto é ideal para profissionais, laboratórios digitais e estudantes, proporcionando experiência prática em C# e automação de sistemas.


---

🔧 Funcionalidades Principais

Funcionalidade	Descrição

Adicionar Veículo	Registro completo com dados do proprietário e entrada no estacionamento.
Remover Veículo	Calcula tempo de permanência, registra saída e gera pagamento automaticamente.
Pagamentos Digitais	Aceita PIX, cartão ou criptomoeda, garantindo flexibilidade.
Relatórios	Total de veículos, receita diária, semanal e mensal, com métricas precisas.
Logs e Auditoria	Todos os registros são mantidos no arquivo registro_pagamentos.txt.
Interface Simples	Menu intuitivo via terminal, facilitando o uso em qualquer ambiente.



---

📁 Estrutura do Projeto

controle-estacionamento/
├── src/                      # Código-fonte C# do sistema
├── scripts/                  # Scripts auxiliares (compilação, execução)
├── logs/                     # Logs de execução e auditoria
├── registro_pagamentos.txt   # Histórico de pagamentos
└── README.md                 # Documentação detalhada


---

⚡ Tecnologias e Metodologias

C# / .NET / Mono – Base do sistema

POO (Programação Orientada a Objetos) – Código modular, limpo e escalável

Automação Termux/Linux – Scripts para execução rápida

Gestão de pagamentos – PIX, Cartão e Criptomoedas integrados

Logging avançado – Auditoria e rastreabilidade completa



---

🎯 Objetivo do Projeto

Fornecer uma solução prática, confiável e escalável para gestão de estacionamentos, garantindo:

Controle total de entrada e saída de veículos

Transparência nos pagamentos e registros

Relatórios precisos para análise diária, semanal e mensal

Experiência prática em C# e sistemas multiplataforma



---

🚀 Como Executar

Via Mono (Linux / Mac / Termux)

# Entrar no diretório do projeto
cd ~/controle-estacionamento/src

# Compilar o sistema
mcs Program.cs -out:ControleEstacionamento.exe

# Executar
mono ControleEstacionamento.exe

Via Script Automatizado (Termux/Linux)

cd ~/controle-estacionamento/scripts
./criar_estacionamento_pro.sh


---

💡 Diferenciais do Projeto

Sistema modular e expansível

Integração com múltiplos métodos de pagamento

Relatórios detalhados e métricas em tempo real

Logs completos para auditoria

Código limpo, comentado e pronto para portfólio profissional



---

📌 Autor

Lucas Morais – Desenvolvedor Fullstack, especialista em automação, segurança digital e sistemas profissionais.

