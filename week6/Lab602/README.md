# Lab602: Identify design pattern and participants from program (group of 2 students)

In this lab, each group of 2 students has to identify a design pattern and all participants 
from the provided C# program. 

## Submission: a written report which contains

1. A class diagram of the original source code
2. Detail explaination about the identified pattern and all the parcipants

1. A class diagram of the original source code.

	![diag](https://raw.githubusercontent.com/cpe200-158-sec1-0559/week-6/master/week6/Lab602/LAB602.jpg)

2. Explanation.
	
	It's base on ABSTRACT FACTORY under CREATIONAL PATTERNS because it provide an interface for creating several families AND these families has a relationship between them. 

	It contain many participants as belows.

		1. Document as AbstractFactory for declares an interface for operations that create abstract group-of-page types (Resume, Report).

		2. Resume and Report as ConcreteFactory for implements the operations to create concrete Page objects (Type-of-Page like exp, edu, skill, etc.).

		3. Page as AbstractProduct for declare an interface for a type of Page objects.

		4. Type-of-Page like exp, edu, skill, etc. as Product for defines a page objects to be created by the concrete factory (Resume, Report) and implements the AbstractProduct (Page) interface.
