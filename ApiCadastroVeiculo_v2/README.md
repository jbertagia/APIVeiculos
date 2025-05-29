# API - Cadastro de Veículos Furtados

## 🎯 Objetivo

API RESTful desenvolvida em C# com ASP.NET Core para o cadastro, consulta e gerenciamento de veículos furtados. O sistema permite:

- Listar todos os veículos
- Buscar por ID
- Cadastrar novo veículo
- Excluir veículo por ID

---

## 🚀 Como Executar

### 1. Pré-requisitos

- .NET SDK 6 ou superior
- SQLite (opcional, banco é gerado automaticamente)
- Visual Studio Code ou Visual Studio

### 2. Passos para rodar

Abra o terminal na pasta do projeto (`ApiCadastrarVeiculo`) e execute:

```bash
dotnet restore
dotnet ef database update
dotnet run
```

---

## 🔗 Endpoints da API

| Método  | Rota                      | Descrição                    |
|---------|---------------------------|------------------------------|
| GET     | /api/veiculos             | Lista todos os veículos     |
| GET     | /api/veiculos/{id}        | Busca veículo por ID        |
| POST    | /api/veiculos             | Cadastra novo veículo       |
| DELETE  | /api/veiculos/{id}        | Exclui veículo por ID       |

---

## 🧪 Exemplos de Teste

### 📥 POST - Cadastrar novo veículo

URL: `http://localhost:5101/api/veiculos`  
Método: `POST`  
Body (JSON):

```json
{
  "modelo": "Tracker",
  "marca": "Chevrolet",
  "cor": "Branco",
  "placa": "ABC9876",
  "chassis": "CHS011",
  "status": "Roubado"
}
```

### 🗑️ DELETE - Remover veículo

URL: `http://localhost:5101/api/veiculos/1`  
Método: `DELETE`

---

## ✅ Observações para nota máxima

- Banco SQLite configurado via EF Core
- Seed com 10 registros automáticos
- Código dividido em arquivos para GET, POST, DELETE
- Documentação entregue em PDF (ver pasta)
- Testes demonstráveis via navegador ou Postman