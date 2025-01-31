# API-CRUD-C-

Uma API RESTful construída em **.NET 8** com suporte a **Docker** e deploy no **Render**.

## 🚀 Tecnologias utilizadas
- **.NET 8**
- **Entity Framework Core**
- **SQLite**
- **Swagger**
- **Docker**
- **Render** (para deploy)

## 📌 Configuração do Projeto

### **1️⃣ Clonar o Repositório**
```sh
git clone https://github.com/marcosviniciussdeveloper/API-CRUD-C-.git
cd API-CRUD-C-
```

### **2️⃣ Configurar o Banco de Dados**
Esta API usa **SQLite**. Certifique-se de que o arquivo `appsettings.json` contém a string de conexão correta:

```json
"ConnectionStrings": {
  "DefaultConnection": "Data Source=person.Sqlite"
}
```

Rodar as **migrações** do banco de dados:
```sh
dotnet ef database update
```

### **3️⃣ Executar a API**
```sh
dotnet run
```

Acesse no navegador:
```
http://localhost:5000/swagger
```

---

## 📦 **Docker**
### **Rodar a API no Docker**
Se preferir, pode rodar o projeto via Docker:
```sh
docker build -t api-crud .
docker run -p 8080:80 api-crud
```
Agora, a API estará acessível em:
```
http://localhost:8080/swagger
```

---

## 🌍 **Deploy no Render**
Esta API está hospedada no **Render** e pode ser acessada através do seguinte link:
🔗 **[API Online](https://api-crud-8jgp.onrender.com/swagger)**

Exemplo de requisição para listar usuários:
```sh
curl -X GET https://SEU-LINK-DO-RENDER.onrender.com/api/users
```

---

## 🛠️ **Endpoints**
### ✅ `GET /api/users`
Obtém a lista de usuários.

### ✅ `POST /api/users`
Cria um novo usuário.

### ✅ `PUT /api/users/{id}`
Atualiza um usuário existente.

### ✅ `DELETE /api/users/{id}`
Remove um usuário pelo ID.

---

## 📜 **Licença**
Este projeto é de código aberto e pode ser usado conforme necessário.

---

### **🔗 Contribuição**
Se desejar contribuir, faça um **fork** do repositório e envie um **pull request**!

---

## **📧 Contato**
📌 Desenvolvido por **[Marcos Vinicius](https://github.com/marcosviniciussdeveloper)**

