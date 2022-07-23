## Detalhamento do Projeto ByteBank
- Completar README do projeto, descrevendo conteúdos aprendidos.


Try, Catch e Throw


Try
O bloco Try é utilizado para colocar o trecho de código que potencialmente pode gerar um problema na execução deste determinado trecho.
De modo mais genérico, colocamos o trecho do código que tem grande potencial de gerar um problema e o bloco Try 'tenta' executar esse trecho. Se não tiver nenhum problema na execução, todo o bloco Try/Catch é encerrado.

Catch
É o bloco responsável por tratar o problema caso a excessão seja lançada. Ou seja, caso o trecho de código que tentamos executar no bloco Try gere um problema (excessão), o Catch 'pega' essa excessão para tratamento do problema. Comumente utilizamos argumentos textuais para alertar esta falha.

Throw - Do ingl


Um exemplo bem comum para demonstrar o uso do tratamento de excessões é a divisão.

No código abaixo, supondo o uso dos argumentos numerador = 22.4 e divisor = 0, o compilador encerra a execução do programa mostrando a mensagem de erro.

```cs
public int dividir(int numerador, int divisor)
{
	return numerador/divisor;
}
```

```log
Unhandled Exception:
System.DivideByZeroException: Attempted to divide by zero.
  at Program.Main (System.String[] args) [0x00001] in <54352dd9a5d647fdaec681b1dcc9d196>:0 
[ERROR] FATAL UNHANDLED EXCEPTION: System.DivideByZeroException: Attempted to divide by zero.
  at Program.Main (System.String[] args) [0x00001] in <54352dd9a5d647fdaec681b1dcc9d196>:0 
```
ParamName

Serve para obtermos o nome do parâmetro que está causando a excessão.
