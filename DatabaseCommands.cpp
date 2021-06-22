/*
 * DatabaseCommands.cpp
 *
 *  Created on: Jun 2, 2021
 *      Author: dangj3
 */
//Implementation of the DatabaseCommands header file
#include "DatabaseCommands.h"
#include "DBTable.h"
#include <vector>


//Constructor and Destructor
DatabaseCommands::DatabaseCommands(){
	errMsg = NULL;
	database = NULL;
}

DatabaseCommands::DatabaseCommands(sqlite3* database){
	this->database = database;
	errMsg = NULL;
}

DatabaseCommands::~DatabaseCommands(){
	delete database;
}


//Opening database
void DatabaseCommands::openDatabase(std::string name){
	int exit = sqlite3_open(name.c_str(), &database);
}
void DatabaseCommands::openDatabase(sqlite3* database, std::string name){
	int exit = sqlite3_open(name.c_str(), &database);
}

//Sqlite3 commands
void DatabaseCommands::sqlite3Command(sqlite3* database, std::string command){
	sqlite3_exec(database, command.c_str(), printCallBack, NULL, NULL);
}

void DatabaseCommands::sqlite3Command(sqlite3* database, char* command){
	sqlite3_exec(database, command, printCallBack, NULL, NULL);
}

void DatabaseCommands::sqlite3Command(std::string command){
	sqlite3_exec(this->database, command.c_str(), printCallBack, NULL, NULL);
}

void DatabaseCommands::sqlite3Command(char* command){
	sqlite3_exec(this->database, command, printCallBack, NULL, NULL);
}

//Notice the callback function within the sqlite3_exec method call
Table DatabaseCommands::returnQuery(std::string command){
	Table newTable;
	int exit = sqlite3_exec(this->database, command.c_str(), queryCallBack, &newTable, &errMsg);
	return newTable;
}


