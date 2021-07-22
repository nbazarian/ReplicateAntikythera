#include <iostream>
#include <sqlite3.h>
#include <stdio.h>
#include <string>
#include "EventClasses.h"

using namespace std;

/************************************************************************************************* 	
 The callback() function is invoked for each result row coming out of the evaluated SQL statement
 1st argument - the 4th argument provided by sqlite3_exec() and is typically not used
 2nd argument - number of columns in the result
 3rd argument - an array of strings containing the fields in that row
 4th argument - an array of strings containing the names of the columns
*************************************************************************************************/
static int callback(void* data, int argc, char** argv, char** azColName) 
{ 				
	int i; 
   
    	for (i = 0; i < argc; i++) 
		{ 
        	printf("%s = %s\n", azColName[i], argv[i] ? argv[i] : "NULL"); 
    	} 
  
    	printf("\n"); 
    	
		return 0; 
}


double calcMetonic(double solar){
 	return solar * (5.0/19.0);
}

double calcCallippic(double solar){
	return  solar * (1.0/76.0);
}

double calcGames(double solar){
	return solar * (1.0/4.0);
	
}

double calcSaros(double solar){
	return solar * (940.0/4237.0);
}

double calcExeglimos(double saros){
	return saros * (1.0/12.0);
}

double calcMoon(double solar){
	return solar * (254.0/19.0);
}
int main(void){

double solarPointer, metonicPointer, callippicPointer, gamesPointer, sarosPointer, exeglimosPointer, moonPointer;
std::string dbCarry;
int input;

std::cout << "1. Display information from database\n2.Calculate positions\n3.Close\nSelect:";
std::cin >> input;

	if (input == 1){
		sqlite3* DB; 
		int exit = 0;
    		exit = sqlite3_open("antikythera.db", &DB);			//open the database
		
		char* messageError; 

		//Input the SQL commands here.

		sqlite3_close(DB); 
	}
	else if (input == 2){
		std::cout << "Enter the number of rotations of the sun:";
		std::cin >> solarPointer;
		metonicPointer = calcMetonic(solarPointer);
		callippicPointer = calcCallippic(solarPointer);
		gamesPointer = calcGames(solarPointer);
		sarosPointer = calcSaros(solarPointer);
		exeglimosPointer = calcExeglimos(sarosPointer);
		moonPointer = calcMoon(solarPointer);
		std::cout << "Metonic Pointer=" << metonicPointer << "\nCallippic Pointer=" << callippicPointer << "\nGames Pointer=" << gamesPointer << "\nSaros pointer=" << sarosPointer << std::endl;
		std::cout << "Exeglimos pointer=" << exeglimosPointer << "\nMoon pointer=" << moonPointer << std::endl;
	}
	else if (input == 3)
		std::cout << "Closing program...\n";
	else {
		std::cout << "Input not recognized. Select:";
		std::cin >> input;
	}

return 0;
}
