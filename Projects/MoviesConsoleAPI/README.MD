# Creating an API in C# from URL


**MoviesConsoleAPI**
=======
#### É um programa criado para realizar requisições em uma API, através da URL padrão:
```http
https://jsonmock.hackerrank.com/api/movies/search?Title={titulo}&page={page}
```
O usuário deve digitar o título que deseja buscar para obter o resultado.
<br>
### **Problemas Na implementação**
> Principalmente por ser meu primeiro contato com APIs, durante as etapas iniciais de criação da solução encontrei diversos problemas.
Fiz algumas tentativas nos seguintes templates:
> - ASP.NET Core Web App;
> - Blazor Server App;
> - WPF Browser App (.NET Framework);
> - Console App;

Dentre as principais dificuldades estavam em compreender como ocorre o relacionamento entre as etapas de leitura dos dados da URL para conversão em json e finalmente envio dos resultados desejados para as classes correspondentes.  
Cheguei também a implementar uma API com ***ASP.NET Core Web App*** utilizando de requisições em banco de dados MySQL local. Mas tive dificuldade em 'converter' o processo de requisição de MySQL para uma URL externa.
Por fim, acabei por utilizar um Console App para completar a tarefa.
  
<br>

### **Observação sobre as Classes**
Mesmo havendo outros atributos possíveis de serem incluídas na classe, com base na própria API, apenas o atributo para armazenamento do Ano de lançamento dos filmes foi utilizado:
```C#
namespace MoviesConsoleAPI.Models
{
    public class MovieInfo
    {
        
        [JsonProperty("Year")]
        public int Year { get; set; }
    }
}
```

<br>

### **Como Utilizar a Aplicação**
Por ter sido produzido em um aplicativo de console, o uso se dá pela execução do aplicativo de console.  
O executável original está localizado no seguinte diretório:
```
\MoviesAPI\MoviesConsoleAPI\MoviesConsoleAPI\bin\Debug\net6.0\MoviesConsoleAPI.exe
```
Entretanto, foi criado um atalho para o executável na pasta principal do projeto em:
```
\MoviesAPI\MoviesConsoleAPI\Run.exe
```
Após abrir o executável, será exibida a mensagem:
> Type the movie Title do search: 
<p>
Então basta digitar um termo para a busca e pressionar enter para exibir o resultado.

<br><br>

### **Resultados Obtidos**
Há dois vídeos na pasta \videos com a execução do programa.
Dentre os resultados obtidos, temos os seguintes exemplos:
* Resultado utilizando o título: roma
```json
{
	"moviesByYear":[
		{
			"year":1917,
			"movies":1
		},
		{
			"year":1948,
			"movies":1
		},
		{
			"year":1976,
			"movies":1
		},
	],
	"total":3
}
```
* Resultado utilizando um título inválido: 9dasoplsdq2lkj
```json
$: No movie found with title '9dasoplsdq2lkj'
{
	"moviesByYear":[
	],
	"total":0
}
```

* Resultado sem enviar nenhum caractere:
```json
Invalid Title: type at least one character!
{
	"moviesByYear":[
	],
	"total":0
}
```
<br>

### **Próximas Atualizações**
Apesar de não ter concludído a API da forma como foi pensado inicialmente, utilizando recursos mais específicos como um template em ***ASP.NET Core Web App***, concluir essa etapa permitiu obter o conhecimento básico sobre o funcionamento de requisições de dados através de URLs e deserialização de conteúdo JSON.  
Assim, nas próximas atualizações irei introduzir os recursos de uma API padrão com ASP.NET Core Web App, permitindo requisições diretamente de URLs externas.

<br>

__________________

### <center> English Version</center>
__________________
<br>

# Creating an API in C# from URL


**MoviesConsoleAPI**
=======
#### It is a program created to make requests in an API, through the standard URL:
```http
https://jsonmock.hackerrank.com/api/movies/search?Title={title}&page={page}
```
The user must type the title they want to search for to get the result.
<br>

### **Implementation Problems**
> Mainly because it was my first contact with APIs, during the initial stages of creating the solution I encountered several problems.
I tried the following templates:
> - ASP.NET Core Web App;
> - Blazor Server App;
> - WPF Browser App (.NET Framework);
> - Console App;

Among the main difficulties were in understanding how the relationship between the steps of reading data from the URL for conversion to json and finally sending the desired results to the corresponding classes occurs.
I also implemented an API with ***ASP.NET Core Web App*** using requests in a local MySQL database. But I had a hard time 'converting' the MySQL request process to an external URL.
Finally, I ended up using a Console App to complete the task.
  
<br>

### **Class Notes**
Even though there are other attributes that can be included in the class, based on the API itself, only the attribute for storing the Year of release of the films was used:
```C#
MoviesConsoleAPI.Models namespace
{
    public class MovieInfo
    {
        
        [JsonProperty("Year")]
        public int Year { get; set; }
    }
}
```

<br>

### **How ​​to Use the Application**
Because it was produced in a console application, use is by running the console application.
The original executable is located in the following directory:
```
\MoviesAPI\MoviesConsoleAPI\MoviesConsoleAPI\bin\Debug\net6.0\MoviesConsoleAPI.exe
```
However, a shortcut to the executable was created in the main project folder at:
```
\MoviesAPI\MoviesConsoleAPI\Run.exe
```
After opening the executable, the message will appear:
> Type the movie Title of the search:
<p>
Then just type in a search term and press enter to display the result.

<br><br>

### **Results Obtained**
> There are two videos in the \videos folder with the program running.
Among the results obtained, we have the following examples:
* Result using the title: rome
```json
{
"moviesByYear":[
{
"year":1917,
"movies":1
},
{
"year":1948,
"movies":1
},
{
"year":1976,
"movies":1
},
],
"total":3
}
```
* Result using an invalid title: 9dasoplsdq2lkj
```json
$: No movie found with title '9dasoplsdq2lkj'
{
"moviesByYear":[
],
"total":0
}
```

* Result without sending any characters:
```json
Invalid Title: type at least one character!
{
"moviesByYear":[
],
"total":0
}
```
<br>

### **Upcoming Updates**
Despite not having completed the API in the way it was initially thought, using more specific resources such as a template in ***ASP.NET Core Web App***, completing this step allowed obtaining basic knowledge about how data requests work via URLs and deserialization of JSON content.
So, in the next updates I will introduce the features of a standard API with ASP.NET Core Web App, allowing requests directly from external URLs.