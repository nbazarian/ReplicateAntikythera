//Calculations based on data from: https://www.antikytheramechanism.com/howitworks.html
//SQL code for opening/closing database and handling query callback source from code by Marisha Rawlins
#include <iostream>
#include <sqlite3.h>
#include <stdio.h>
#include <string>
#include <vector>
#include <time.h>
#include <chrono>
#include <ctime>
#include <string.h>

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

void calcEclipse(double solar, double  moon){
	
	while (solar > 1){
		solar = solar - 1;
	}

	while (moon > 13.3684){
		moon = moon - 13.368421052631578947368421052632;
	}

	double sunRot = solar * 360;
	double lunRot = moon * 360;
	if ((sunRot <= lunRot + 0.037134 && sunRot >= lunRot - 0.037134) ||  (sunRot <= lunRot + 360.037134 && sunRot >= lunRot + 359.62866) ){
		std::cout << "There is a solar eclipse occurring\n";
	}
	else if((sunRot <= lunRot + 180.037134 && sunRot >= lunRot + 179.962866) || (sunRot >= lunRot - 180.037134 && sunRot <= lunRot - 179.962866)){
		std::cout << "There is a lunar eclipse occurring\n";
	}

}

tm* returnCurrentDate(){
	std::time_t now_c = time(0);
	struct tm *parts = std::localtime(&now_c);
	return parts;
}


int main(void){

double solarPointer, metonicPointer, callippicPointer, gamesPointer, sarosPointer, exeglimosPointer, moonPointer;
char* messageError;
int input;
sqlite3* DB;
int exit = 0;
exit = sqlite3_open("antikythera.db", &DB);			//open the database

int uChoice;

int run =  1;
while(run == 1){
	std::cout << "1.Search for event by date\n2.Calculate positions\n3:Open Model\n4: Exit\nSelect:";
	std::cin >> input;
	switch(input){

		case 1: {
			tm* parts = returnCurrentDate();
			std::cout <<1 + parts->tm_mon << '/' << parts->tm_mday<<std::endl;
			std::cout << "1.Search by current date\n2.Search by different date\nSelect:";
			std::cin >> uChoice;
			double tmDay = parts->tm_mon;
			double tmMon = parts->tm_mday;
				if (uChoice == 1){
					std::string temp = "SELECT * FROM SpaceEvents WHERE Month = "+  to_string(tmMon) +" AND Day = "+ to_string(tmMon) +";";
					exit = sqlite3_exec(DB, temp.c_str(), callback, 0, &messageError);

					if (exit == 0){
						cerr << "No events occurring today.\n" << std::endl;
						sqlite3_free(messageError);
					}
				}

				else if(uChoice == 2){
					std::string month, day;
					std::cout << "Please enter the month and day:";
					std::cin >> month >> day;

					string temp = "SELECT * FROM SpaceEvents WHERE Month = "+ month +" AND Day = "+ day +";";
					exit = sqlite3_exec(DB, temp.c_str(), callback, 0, &messageError);

					if (exit == 0){
						std::cerr << "No events occurring today.\n" << std::endl;
						sqlite3_free(messageError);
					}
				}
		break;
		}

		case 2: {
			std::cout << "Enter the number of rotations of the sun:";
			std::cin >> solarPointer;
			metonicPointer = calcMetonic(solarPointer);
			callippicPointer = calcCallippic(solarPointer);
			gamesPointer = calcGames(solarPointer);
			sarosPointer = calcSaros(solarPointer);
			exeglimosPointer = calcExeglimos(sarosPointer);
			moonPointer = calcMoon(solarPointer);
			std::cout << "Metonic Pointer=" << metonicPointer << " cycle(s)\nCallippic Pointer=" << callippicPointer << " cycles(s)\nGames Pointer=" << gamesPointer << " cycle(s)\nSaros pointer=" << sarosPointer << " cycle(s)\n";
			std::cout << "Exeglimos pointer=" << exeglimosPointer << " cycles(s)\nMoon pointer=" << moonPointer << " rotations of the moon\n";
			calcEclipse(solarPointer, moonPointer);
			break;
		}
		case 3: {
			system("Start ./AntikytheraGUI.exe");
			break;
		}
		case 4: {
			sqlite3_close(DB);
			run = 0;
			std::cout<<"Closing Program"<<std::endl;
			break;
		}

		default: {
			std::cout<<"Input not recognized"<<std::endl;
			break;
		}
		}
	}

return 0;
}
