# UsuariosApp

## Sobre o Projeto

**UsuariosApp** é o back-end responsável pela autenticação de usuários em um ecossistema que inclui também os projetos **ClientesApp** e **ClientesWeb**. Ele utiliza **JWT Bearer** para autenticação segura e garante o controle de acesso aos recursos do sistema. O projeto foi desenvolvido com foco em boas práticas, escalabilidade e segurança.

---

## Tecnologias Utilizadas

- **.NET 8**: Framework robusto e moderno para aplicações de back-end.
- **JWT Bearer**: Implementação segura de autenticação baseada em tokens.
- **CORS**: Configuração para permitir o acesso controlado a partir de origens específicas.
- **Testes com TDD**: Desenvolvimento orientado a testes utilizando **xUnit**.
- **Princípios SOLID**: Para garantir flexibilidade, manutenibilidade e organização do código.
- **Práticas de Código Limpo**: Foco em legibilidade, simplicidade e testes.

---

## Funcionalidades

- **Autenticação Segura**: Geração e validação de tokens JWT para acesso seguro aos recursos.
- **Gerenciamento de Usuários**: Cadastro, edição, exclusão lógica e autenticação de usuários.
- **Integração com ClientesApp e ClientesWeb**: Fornece o serviço de autenticação para os outros sistemas do ecossistema.

---

## Estrutura do Projeto

- **Autenticação**: Utiliza JWT para criar um fluxo seguro de login e autorização.
- **Configuração de CORS**: Permite o controle de acessos externos de forma granular.
- **Testes Automatizados**: Seguem a abordagem TDD para garantir qualidade e confiabilidade.

---

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu_usuario/UsuariosApp.git
   ```
2. Configure o ambiente (exemplo: variáveis de conexão de banco de dados e chaves JWT).
3. Execute a aplicação:
   ```bash
   dotnet run
   ```
4. (Opcional) Execute os testes para verificar o funcionamento:
   ```bash
   dotnet test
   ```

---

## Contribuições

Contribuições são bem-vindas! Sinta-se à vontade para abrir **issues** ou enviar **pull requests** no repositório oficial.

---

## Licença

Este projeto é licenciado sob a [MIT License](LICENSE).

