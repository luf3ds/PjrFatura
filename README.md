💼 Sistema de Faturamento e Cadastro (C#)

Projeto desenvolvido em C# com foco em gestão de clientes, fornecedores, produtos e usuários, incluindo validações, controle de dados e persistência via serialização.

🚀 Funcionalidades
👤 Cadastro de Clientes e Fornecedores
📞 Gerenciamento de Contatos
📦 Cadastro de Produtos
🔐 Controle de Usuários e autenticação
💳 Controle de limite de crédito
🧾 Validação de CPF e CNPJ
💾 Serialização e desserialização de dados
🔢 Geração automática de códigos
📊 Ordenação de entidades (IComparable)
🧠 Estrutura do Sistema

O projeto segue uma estrutura orientada a objetos, separando responsabilidades em classes específicas.

🏗️ Classes Principais
👤 Cliente

Representa um cliente com controle de crédito e dados jurídicos.

Adiciona limite de crédito
Subtrai limite com validação
Possui contato associado
🏢 PessoaJuridica

Classe base para entidades com CNPJ.

Validação de CNPJ integrada
Base para Cliente e Fornecedor

📞 Contato

Representa informações de contato.

Validação de CPF
Dados como telefone, email e cargo
🚚 Fornecedor

Entidade fornecedora de produtos.

Possui contato e endereço
Herda de PessoaJuridica
📦 Produto

Representa produtos cadastrados no sistema.

Código gerado automaticamente
Associação com fornecedor
Implementa ordenação (IComparable)
👤 Usuário

Controle de usuários do sistema.

Login e senha
Controle de perfil
Atualização de dados
Geração de ID automático
🧾 Apresentação

Define características do produto (ex: peso).

💾 Serializa

Responsável por salvar e carregar dados em arquivos.

Serialização com BinaryFormatter
Suporte para:
Clientes
Fornecedores
Produtos
Usuários
Apresentações
🛠️ Util

Classe utilitária com validações e formatações.

Validação de CPF e CNPJ
Formatação de CPF
Regras de senha
⚙️ Tecnologias Utilizadas
C#
.NET
Programação Orientada a Objetos (POO)
Serialização com BinaryFormatter
🔐 Validações Implementadas
✔ CPF válido
✔ CNPJ válido
✔ Senha segura (mínimo 8 caracteres, maiúsculas, minúsculas, número e especial)
✔ Controle de crédito (não permite negativo ou exceder limite)
💡 Lógica de Negócio
Clientes possuem limite de crédito controlado
Produtos são vinculados a fornecedores
Usuários possuem níveis de acesso (perfil)
Dados são persistidos localmente via serialização
