Algoritmo Lecc16_Act2_Inc2
	Dimension numEnteros[8]
	
	Definir indice, numMayor, posMayor Como Entero
	
	Para indice <- 1 Hasta 8 Hacer
		Escribir "ingrese el numero", indice, ": "
		Leer numEnteros[indice]
		
		Si indice = 1 Entonces
			numMayor <- numEnteros[indice]
			posMayor <- indice
		SiNo
			Si numEnteros[indice] > numMayor Entonces
				numMayor <- numEnteros[indice]
				posMayor <- indice
			FinSi
		Fin Si
	Fin Para
	
	Escribir "El numero mayor es: ", numMayor
	Escribir "La poscicion es: ", posMayor
	
FinAlgoritmo
