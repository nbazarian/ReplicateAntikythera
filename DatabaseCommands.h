

#include <iostream>
#include <sqlite3.h>
#include <stdio.h>



class DatabaseCommands {

private:

	//Private data members and functions of this class
	char* errMsg;
	sqlite3* database;
	static int callback(void* data, int argc, char** argv, char** azColName){
			int i;
		    for (i = 0; i < argc; i++){
		        printf("%s = %s\n", azColName[i], argv[i] ? argv[i] : "NULL");
		    }
		    printf("\n");
			return 0;
	}
public:
	//Constructor and destructor
	DatabaseCommands();
	DatabaseCommands(sqlite3* database);
	~DatabaseCommands();

	//These functions will just do the exact command you put in
	void sqlite3Command(std::string command);
	void sqlite3Command(char* command);
	//These functions are the same as above except you now need to pass in a pointer to a Splite3 object
	void sqlite3Command(sqlite3* database, std::string command);
	void sqlite3Command(sqlite3* database, char* command);
	//These functions open up a database
	void openDatabase(std::string name);
	void openDatabase(sqlite3* database, std::string name);
};
