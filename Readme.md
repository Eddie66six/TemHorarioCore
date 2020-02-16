***** Nome do banco: TemHorarioDb

** Criar banco
-selecione o projeto TemHorario.Repository como inicial
Add-Migration InitialCreate
Update-Database

** Atualização do banco
-selecione o projeto TemHorario.Repository como inicial
Add-Migration AddProductReviews
Update-Database

** Refazer o banco
1 - deletar o banco do sql
2 - apagar a pasta Migrations do projeto TemHorario.Repository

** Para acessar o banco
nome do servidor: (localdb)\MSSQLLocalDB
autenticação: Autenticação do windows
