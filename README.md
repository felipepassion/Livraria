
<h1 align="center">
  <br>
  <a href="https://github.com/Niu-Technology/niu-living/assets/170114515/3dc9ef51-9010-48e9-b0b2-132c2bb8cd4b"><img src=https://github.com/Niu-Technology/niu-living/assets/170114515/3dc9ef51-9010-48e9-b0b2-132c2bb8cd4b" alt="Niu Living Logo" width="200"></a>
  <br>
  Niu Living
  <br>
</h1>

<h4 align="center">Uma plataforma de busca de aluguel para universitários.</h4>

<p align="center">
  <a href="#como-utilizar">Como Utilizar</a> •
  <a href="#requisitos">Requisitos</a> •
  <a href="#passos-de-configuracao">Passos de Configuração</a> •
  <a href="#padroes-de-commit">Padrões de commit</a> •
  <a href="#license">License</a>
</p>

## 👋 Seja bem-vindo!

Está é a documentação de desenvolvimento da **Niu Living**! Aqui você encontrará todas as informações necessárias para configurar, desenvolver e contribuir para nossos projetos

### Requisitos

- .NET 8
- Postgres
- IDE de sua escolha (recomendamos VSCode)

### Passos de Configuração

- Após a liberação do e-mail, vincule-o com a sua IDE.
- Na barra superior do VSCode, clique em `Git` -> `Clone Repository` -> `GitHub` -> Selecione o repositório `Niu-Technology/niu-living`.
- Para inicializar o projeto, configure as APIs utilizadas no sistema:
  - Clique na Solution -> `Properties` -> `Multiple startup projects` -> Selecione os seguintes projetos: `Addresses.Api`, `Chat.Api`, `Nests.Api`, `Users.Api`.

## Padrões de commit

- Commits devem ser feitos utilizando os emojis abaixo, conforme o tipo do commit:

  - 🐛 (`:bug:`) -> bugs no sistema.
  - ✨ (`:sparkles:`) -> features no sistema, geralmente usado em uma nova implementação.
  - 💄 (`:lipstick:`) -> referente à parte visual (CSS, Layout).
  - ♻️ (`:recycle:`) -> refatoração no código, não implementa uma nova lógica.


MIT

---

> [niuliving.com.br](https://www.niuliving.com.br) &nbsp;&middot;&nbsp;
> GitHub [@NiuLiving](https://github.com/NiuLiving) &nbsp;&middot;&nbsp;
> Twitter [@NiuLiving](https://twitter.com/NiuLiving)

