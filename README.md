# SmartBreaker Console App

💡 Simulador de impactos cibernéticos e falhas elétricas, inspirado no projeto SmartBreaker — um quadro de luz inteligente com IA embarcada. Desenvolvido como aplicação console em C# (.NET), o sistema permite registrar, simular e analisar falhas e alertas em circuitos elétricos.

---

## 🔧 Funcionalidades

- Registro manual de falhas elétricas
- Geração de alertas críticos
- Simulação de eventos (falha ou alerta)
- Relatórios por circuito:
  - 📉 Falhas
  - 🚨 Alertas
- Log de eventos registrados
- Login básico com usuário e senha

---

## 🧠 Cenário Simulado

A aplicação representa um fallback local de um quadro de luz inteligente durante um ataque cibernético. Enquanto a IA embarcada estiver inacessível, este sistema permite manter controle mínimo da operação elétrica e registros críticos.

---

## 🛠️ Tecnologias

- C# com .NET SDK 6 ou superior
- Console Application
- Organização em camadas (Models, Services, Utils)
- Boas práticas: encapsulamento, coesão, herança e tratamento de erros com `try-catch`

---

## 🚀 Como Executar

1. Clone o repositório:

```bash
git clone https://github.com/seu-usuario/smartbreaker-console-app.git
cd smartbreaker-console-app
```

2. Compile o projeto:

```bash
dotnet build
```

3. Execute a aplicação:

```bash
dotnet run
```

4. Faça login com as credenciais padrão:

- **Usuário:** `admin`  
- **Senha:** `1234`

---

## 📁 Estrutura do Projeto

```
SmartBreakerConsoleApp/
├── Program.cs               # Ponto de entrada
├── Models/                  # Definições de Falha, Alerta, Evento
├── Services/                # Lógica de negócio (registro, simulação, relatórios)
├── Utils/                   # Logger simples
└── README.md                # Este documento
```

---

## ✅ Requisitos Atendidos

- [x] Simulação de falhas e alertas
- [x] Registro e log de eventos
- [x] Relatórios por tipo
- [x] Classes coesas e bem organizadas
- [x] Boas práticas de código limpo
- [x] Login obrigatório
- [x] Publicação com README no GitHub

---

## 👨‍💻 Autor

Samuel Ramos de Almeida – RM99134
Gabriel Marquez Trevisan – RM99227
Enricco Rossi de Souza Carvalho Miranda – RM551717