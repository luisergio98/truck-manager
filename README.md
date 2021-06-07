# truck-manager
A simple C# CRUD using ASP.NET and Entity


## English

### How to run the project

This project was built on top of .NET 5.0 using Visual Studio 2019 and SQL Server 2019. It is highly recommended that you use these platforms to run it.

First check if the project nugets are installed in the solution. To do this open the Solution Explorer, right-click on the solution and then click Manage Nuget Packages for Solution. Then on the Installed tab check if the following packages are installed:

#### For TruckManager project
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (v5.0.6) <br>
Microsoft.EntityFrameworkCore (v5.0.6) <br>
Microsoft.EntityFrameworkCore.SqlServer (v5.0.6) <br>
Microsoft.EntityFrameworkCore.Tools (v5.0.6) <br>
Microsoft.VisualStudio.Web.CodeGeneration.Design (v5.0.2) <br>

#### For TruckManagerUnitTests project
coverlet.collector (v1.3.0) <br>
Microsoft.NET.Test.Sdk (v16.7.1) <br>
MSTest.TestAdapter (v2.1.1) <br>
MSTest.TestFramework (v2.1.1) <br><br>

<div align="center">
  
  ![image](https://user-images.githubusercontent.com/28768906/121094217-a9ba2c00-c7c4-11eb-84fb-8552c52e8604.png)
  <br><br>
  ![image](https://user-images.githubusercontent.com/28768906/121094428-04ec1e80-c7c5-11eb-8ed9-63338a9d0871.png)
  <br><br>
  
</div>
<br><br>

The second step to run the project is to create a database and get its connection string. For this you will need to have SQL Server installed on your machine and do the following steps: Click in View tab and then click SQL Server Object Explorer. Then click on the der server symbol with a green plus sign to create a new connection. In the window that opens, click on one of the databases that will appear. In case you already have an instance created on your machine it will appear in this list too.
<br><br>

<div align="center">

![image](https://user-images.githubusercontent.com/28768906/121095202-403b1d00-c7c6-11eb-94a3-455512a072d9.png)
<br><br>
![image](https://user-images.githubusercontent.com/28768906/121095279-6e206180-c7c6-11eb-99a5-d71d78d28a53.png)
<br><br>
![image](https://user-images.githubusercontent.com/28768906/121095329-87291280-c7c6-11eb-954f-76f29c250994.png)

</div> 
<br><br>

After selecting the database and filling in its credentials if necessary, expand the database's attributes and right-click on it and then click in Properties. With that you see the connection string and copy it in its entirety. After copying it you will need to replace the line in the appsettings.Development.json file with the new copied one. If you want, you can configure the database any way you want, however there may be a need to make changes to the project.
<br><br>

<div align="center">

![image](https://user-images.githubusercontent.com/28768906/121095919-99578080-c7c7-11eb-89c6-e9cf9749ad18.png)
<br><br>
![image](https://user-images.githubusercontent.com/28768906/121095994-b3915e80-c7c7-11eb-8cdd-a0964a6354b7.png)
<br><br>
![image](https://user-images.githubusercontent.com/28768906/121096110-e9cede00-c7c7-11eb-87f8-1f372aa90b90.png)
  
</div> 
<br><br>

If you want to create a new database for your data just add "Initial Catalog=YOURDATABASENAME;" in the connection string after the "Data Source".<br><br>
Data Source=(localdb)\\MSSQLLocalDB;<b>Initial Catalog=TruckDatabase;</b>Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

If you are unsure how to set up a database, visit the Microsoft documentation:<br>
https://docs.microsoft.com/pt-br/sql/ssdt/how-to-connect-to-a-database-and-browse-existing-objects?view=sql-server-ver15

By doing these steps you can now run the Web project and test the system.

<br><br><br>

## Português

### Como rodar o projeto 

Este projeto foi feito em cima do .NET 5.0 usando o Visual Studio 2019 e o SQL Server 2019. É altamente recomendável que utilize essas plataformas para rodá-lo.

Primeiramente confira se os nugets do projeto estão instalados na solução. Para tal abra o Explorador de Solução, clique com o botão direito na solução e então clique em Gerenciar Pacotes Nuget para Solução. Então na aba de instalados veja se os seguintes pacotes estão instalados:

#### Para o projeto TruckManager
Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (v5.0.6) <br>
Microsoft.EntityFrameworkCore (v5.0.6) <br>
Microsoft.EntityFrameworkCore.SqlServer (v5.0.6) <br>
Microsoft.EntityFrameworkCore.Tools (v5.0.6) <br>
Microsoft.VisualStudio.Web.CodeGeneration.Design (v5.0.2) <br>

#### Para o projeto TruckManagerUnitTests
coverlet.collector (v1.3.0) <br>
Microsoft.NET.Test.Sdk (v16.7.1) <br>
MSTest.TestAdapter (v2.1.1) <br>
MSTest.TestFramework (v2.1.1) <br><br>

<div align="center">
  
  ![image](https://user-images.githubusercontent.com/28768906/121094217-a9ba2c00-c7c4-11eb-84fb-8552c52e8604.png)
  <br> <br>
  ![image](https://user-images.githubusercontent.com/28768906/121094428-04ec1e80-c7c5-11eb-8ed9-63338a9d0871.png)
  <br>
  
</div>
<br><br>

O segundo passo para rodar o projeto é criar um banco e pegar a linha de conexão do mesmo. Para isso você precisará ter o SQL Server instalado na sua máquina e fazer os seguintes passos: Clique em Visualizar e então clique em Explorador de Objetos SQL Server. Então clique no símbolo der servidor com um sinal de adição verde para criar uma nova conexão. Na janela que abrir clique em um dos bancos que irão aparecer. No caso de você já ter uma instância criada na sua máquina ela irá aparecer nessa lista também. 
<br><br>

<div align="center">

![image](https://user-images.githubusercontent.com/28768906/121095202-403b1d00-c7c6-11eb-94a3-455512a072d9.png)
<br> <br>
![image](https://user-images.githubusercontent.com/28768906/121095279-6e206180-c7c6-11eb-99a5-d71d78d28a53.png)
<br> <br>
![image](https://user-images.githubusercontent.com/28768906/121095329-87291280-c7c6-11eb-954f-76f29c250994.png)

</div> 
<br><br>

Após selecionar o banco e preencher suas credenciais caso necessário, expanda os atributos do banco e clique com o botão direito nele e então clique em Propriedades. Com isso você vai até a linha de conexão para copiá-la por inteira. Após copiá-la você precisará substituir a linha que está no arquivo appsettings.Development.json pela nova copiada. Caso queira pode configurar o banco da forma como bem entender, entretanto pode haver a necessidade de fazer alterações no projeto.
<br><br>

<div align="center">

![image](https://user-images.githubusercontent.com/28768906/121095919-99578080-c7c7-11eb-89c6-e9cf9749ad18.png)
<br>   <br>
![image](https://user-images.githubusercontent.com/28768906/121095994-b3915e80-c7c7-11eb-8cdd-a0964a6354b7.png)
<br> <br>
![image](https://user-images.githubusercontent.com/28768906/121096110-e9cede00-c7c7-11eb-87f8-1f372aa90b90.png)
  
</div>
<br> <br>

Se você quiser criar um novo banco de dados para suas informações adicione "Initial Catalog=NOMEDOSEUBANCO;" na linha de conexão após o "Data Source".<br><br>
Data Source=(localdb)\\MSSQLLocalDB;<b>Initial Catalog=TruckDatabase;</b>Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False

No caso de dúvidas em como configurar um banco de dados, visite a documentação da Microsoft:<br>
https://docs.microsoft.com/pt-br/sql/ssdt/how-to-connect-to-a-database-and-browse-existing-objects?view=sql-server-ver15


Fazendo esses passos você já pode rodar o projeto Web e testar o sistema.





