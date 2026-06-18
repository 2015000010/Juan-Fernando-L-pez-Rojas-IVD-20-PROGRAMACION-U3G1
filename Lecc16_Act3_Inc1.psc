Algoritmo Lecc16_Act3_Inc1
	Dimension numEnteros[15]
	
	Definir indice, comparador Como Entero
	Definir exisRepetido Como Logico
	
	exisRepetido <- Falso
	
	Para indice <- 1 Hasta 15 Hacer
		Escribir "Ingrese el numero ", indice, ": "
		Leer numEnteros[indice]
	Fin Para
	
	Para indice <- 1 Hasta 14 Hacer
		Para comparador <- indice + 1 Hasta 15 Hacer
			Si numEnteros[indice] = numEnteros[comparador] Entonces
				exisRepetido <- Verdadero
			Fin Si
		Fin Para
	Fin Para
	
	Si exisRepetido Entonces
		Escribir  "Si existe al menos un numero repetido."
	SiNo
		Escribir  "No existe ningun numero repetido."
	Fin Si
	
FinAlgoritmo
