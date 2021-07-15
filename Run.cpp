/*
 * Run.cpp
 *
 *  Created on: Jun 3, 2021
 *      Author: dangj3
 */
#include <sqlite3.h>
#include <iostream>
#include <vector>
#include <time.h>
#include <chrono>
#include <ctime>
#include "AntikytheraDB.h"
#include "DatabaseCommands.h"


tm* returnCurrentDate(){
	std::time_t now_c = time(0);
	struct tm *parts = std::localtime(&now_c);
	return parts;
}


int main(){

	tm* parts = returnCurrentDate();
    std::cout << parts->tm_mday  << std::endl;
    std::cout <<1 + parts->tm_mon <<std::endl;



    //See all events
    //Database query select * from all tables where month == tm->month && day == tm->day






	return 0;
}

