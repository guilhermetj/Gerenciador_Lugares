
# Gerenciador de Lugares
## 💡 Sobre o Projeto

Uma API para gerenciamento lugares onde você consegue cadastrar, editar e listar lugares.

## 🚀 Tecnologias utilizadas

O projeto foi desenvolvido utilizando as seguintes tecnologias:

- C#
- .NET 6
- EntityFramework
- Swagger
- SQLServer

## 📑 Documentação da API

#### Retorna todos os lugares

```http
  GET /place
```
#### Retorna todos os lugares filtrando pelo nome

```http
  GET /place?name="nameplace"
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `name`      | `string` | **Obrigatório**. A Variável "name" |

#### Retorna um lugar

```http
  GET /place/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `id`      | `int` | **Obrigatório**. O ID do item que você quer |

#### Cadastra um lugar
```http
  POST /place
```

| Body   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Name`      | `string` | **Obrigatório**. O Nome do lugar que você quer |
| `Slug`      | `string` | **Obrigatório**. O Slug que você quer |
| `City`      | `string` | **Obrigatório**. A Cidade do lugar que você quer |
| `State`      | `string` | **Obrigatório**. O Estado do lugar que você quer |

#### Edita um lugar
```http
  PUT /place/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Id`      | `Int` | **Obrigatório**. O Id do lugar que você quer editar|

| Body   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Name`      | `string` | **Obrigatório**. O Nome do lugar que você quer |
| `Slug`      | `string` | **Obrigatório**. O Slug que você quer |
| `City`      | `string` | **Obrigatório**. A Cidade do lugar que você quer |
| `State`      | `string` | **Obrigatório**. O Estado do lugar que você quer |

#### Exclui um lugar
```http
  DELETE /place/{id}
```

| Parâmetro   | Tipo       | Descrição                                   |
| :---------- | :--------- | :------------------------------------------ |
| `Id`      | `Int` | **Obrigatório**. O Id do lugar que você quer excluir|


## 📥 Executar esse projeto no seu computador

- Clonar Repositório: `git clone https://github.com/guilhermetj/Gerenciador_Lugares.git`

- Subir as tabelas do banco de dados: `dotnet ef database update`
- Rodar Aplicação: `dotnet run`
