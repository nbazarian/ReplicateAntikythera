#include <cstdlib>
#include <iostream>


int main() {

	int choice;

	std::cout << "Hello Astrologist." << std::endl;
	std::cout << "What would you like to explore?" << std::endl;
	std::cout << "1.Track planetary Orbit." << std::endl;
	std::cout << "2.Event Prediction"<<std::endl;
	std::cout << "# Choice:";
	std::cin >> choice;
	std::cout << std::endl;
	
	
		if (choice == 2)
		{
		}

		if (choice == 1)
		{
			std::system(".\\AntikytheraGUI.exe");//"C:\\Users\\hammettk\\source\\repos\\ReplicateAntikythera\\AntikytheraGUI\\bin\\Debug\\AntikytheraGUI.exe"
		}
		else
		{
			std::cout << "Try another Number" << std::endl;
		}








	return 0;
}