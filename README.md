# Calculadora – Case Engenharia de Software JR

O repositório contém a resolução do case técnico proposto para vaga Engenharia de Software Júnior.

---

## Desafio

Corrigir e implementar as seguintes funcionalidades:

- Aplicação só processava o **primeiro item da fila infinitamente**; 
- Implementar a funcionalidade de **divisão**;
- Corrigir o cálculo da **penúltima operação**;
- Exibir a **lista de operações restantes** após cada cálculo;
- Criar uma **pilha (Stack)** para guardar resultados e imprimir ao final.  

---

## Solução

A solução foi desenvolvida em C# aplicando Programação Orientada a Objetos e boas práticas:

- **POO e Polimorfismo** → cada operação (Soma, Subtração, Multiplicação, Divisão) foi implementada em uma classe específica que herda de `OperacaoBase`;  
- **Responsabilidade única (SRP)** → separação entre cálculo, apresentação (ConsoleManager) e execução (Calculadora);
- **Tratamento de exceções** → divisão por zero gera `DivideByZeroException`;
- **Testes unitários (xUnit)** → garantem a confiabilidade das operações;
- **Uso de Queue e Stack**: 

  Queue (fila) → processa as operações na ordem em que foram inseridas;

  Stack (pilha) → armazena os resultados em ordem inversa, simulando cenários de "último resultado primeiro".

---

## Como rodar o projeto
```bash
Clonar o repositório
git clone https://github.com/mariananlemos/Calculadora_Case_InvestimentServices.git
cd Calculadora_Case_InvestimentServices/Calculadora/main

Executar a aplicação
dotnet run

Rodar os testes unitários
cd Calculadora.Tests
dotnet test
