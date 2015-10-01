# Lab601: Identify the design pattern and participants from the program (group of 2 students)

In this lab, each group of 2 students has to identify a design pattern and all participants 
from the provided C# source code. 

## Submission: a written report which contains

1. A class diagram of the original source code
2. Detail explaination about the identified pattern and all the participants
3. Explain how to include "an asian herbivore and an asian carnivore" to the program: 
  - Show the class diagram of the program after including the new requirment.
  - Test the new requirment by modifying the main function and show the result.
  - Show the main function and snippet of C# code that is related to the process.

1. A class diagram of the original source code

	![bfdi](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/LAB601BF.jpg)

2. Explaination.
	
	It's base on ABSTRACT FACTORY under CREATIONAL PATTERNS because it provide an interface for creating several families AND these families has a relationship between them. 

	It contain many participants as belows.

		1. ContinentFactory as AbstractFactory for declares an interface for operations that create abstract Animal types (Carnivore, Herbivore).

		2. AfricaFactory and AmericaFactory as ConcreteFactory for implements the operations to create concrete Animal objects (Lion, Wolf, Bison, Wildbeast).

		3. Carnivore and Herbivore as AbstractProduct for declare an interface for a type of Animal objects (Carnivore, Herbivore).

		4. Animals as Product for defines a animal objects to be created by the concrete factory (AfricaFactory,AmericaFactory) and implements the AbstractProduct (Carnivore, Herbivore) interface.

3. Explanation.
	
	To include an "an asian herbivore and an asian carnivore", we must add AsianFactory class for implement to ContinentFactory like AfricaFactory and AmericaFactory.
	- Class diagram of the program after including the new requirment.

		![afdi](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/LAB602AF.jpg)

	- Result.
		![rest](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/res.JPG)
	- Main function.

		![mn](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/mnfn.JPG)
	- Snippet C# Code.

		![snip1](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/snip1.JPG)

		![snip2](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab601/snip2.JPG)
