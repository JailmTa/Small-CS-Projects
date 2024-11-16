#include<iostream>
#include<cstdlib>
using namespace std;

struct InfoGame {
	int TrueAnswers=0;
	int FalseAnswers=0;
};

int HowManyTimesReplay() {
	cout << "How Many Times Do You Wonna To Replay ? ";
	int Num;
	cin >> Num;
	return Num;
}

int MakeRandom(int From, int To) {
	return rand() % (To - From + 1) + From;
}

enum enLevels{Easy=1,Medume=2,Hard=3,Mix=4};

enum enQType{Add=1,Sub=2,Mul=3,Div=4,Mixx=5};

enLevels EnterLevel() {
	cout << "Enter The Level Of Qustions => { [1]:Easy  ,  [2]:Medume  ,  [3]:Hard  ,  [4]:Mix } : ";
	int Num;
	cin >> Num;
	switch (Num)
	{
	case 1:
		return enLevels::Easy;
		break;
	case 2:
		return enLevels::Medume;
		break;
	case 3:
		return enLevels::Hard;
		break;
	case 4:
		return enLevels::Mix;
		break;
	default:
		break;
	}
}

enQType EnterQType() {
	cout << "Enter The Type Of Qustions => { [1]:Add  ,  [2]:Sub  ,  [3]:Mul  ,  [4]:Dev  ,  [5]:Mix } : ";
	int Num;
	cin >> Num;
	switch (Num)
	{
	case 1:
		return enQType::Add;
		break;
	case 2:
		return enQType::Sub;
		break;
	case 3:
		return enQType::Mul;
		break;
	case 4:
		return enQType::Div;
		break;
	case 5:
		return enQType::Mixx;
		break;
	default:
		break;
	}
}

void EasyQustion(int &Num1,int &Num2) {
	 Num1 = MakeRandom(1,10);
	 Num2 = MakeRandom(1, 10);
}

void MedumQustion(int& Num1, int& Num2) {
	Num1 = MakeRandom(10, 100);
	Num2 = MakeRandom(1, 10);
}

void HardQustion(int& Num1, int& Num2) {
	Num1 = MakeRandom(10, 100);
	Num2 = MakeRandom(10, 100);
}

int AddType(int Num1, int Num2) {
	cout << Num1 << "\t+\n";
	cout << Num2 << endl;
	cout << "-------------\n";
	return Num1 + Num2;
}

int SubType(int Num1, int Num2) {
	cout << Num1 << "\t-\n";
	cout << Num2 << endl;
	cout << "-------------\n";
	return Num1 - Num2;
}

int MulType(int Num1, int Num2) {
	cout << Num1 << "\t*\n";
	cout << Num2 << endl;
	cout << "-------------\n";
	return Num1 * Num2;
}

int DevType(int Num1, int Num2) {
	cout << Num1 << "\t/\n";
	cout << Num2 << endl;
	cout << "-------------\n";
	return Num1 / Num2;
}

void MakeLevelQustions(enLevels Level,int &Num1,int &Num2) {
	if (Level==1){
		EasyQustion(Num1,Num2);
	}
	else if (Level ==2) {
		MedumQustion(Num1,Num2);
	}
	else if (Level==3) {
		HardQustion(Num1,Num2);
	}
	else {
		enLevels n =(enLevels) MakeRandom(1, 3);
		MakeLevelQustions(n,Num1,Num2);
	}
}

int GetAns() {
	int Num;
	cin >> Num;
	return Num;
}

void MakeTypeQustions(enQType Type, int& Num1, int& Num2,int &Yes,int &No) {
	int z;
	if (Type == 1) {
		z=AddType(Num1, Num2);
		if (GetAns() == z) {
			system("color 2F");
			cout << "***************************" << endl;
			cout << "    True Answer :-)\n";
			cout << "***************************" << endl;
			Yes++;
		}
		else {
			system("color 4F");
			cout << "\a***************************" << endl;
			cout << "    False Answer : -(\n";
			cout << "***************************" << endl;
			cout << "The True Answer Is :" << z<<endl;
			No++;
		}
	}
	else if (Type == 2) {
		z=SubType(Num1, Num2);
		if (GetAns() == z) {
			system("color 2F");
			cout << "***************************" << endl;
			cout << "    True Answer :-)\n";
			cout << "***************************" << endl;
			Yes++;
		}
		else {
			system("color 4F");
			cout << "\a***************************" << endl;
			cout << "    False Answer : -(\n";
			cout << "***************************" << endl;
			cout << "The True Answer Is :" << z << endl;
			No++;
		}
	}
	else if (Type == 3) {
		z=MulType(Num1, Num2);
		if (GetAns() == z) {
			system("color 2F");
			cout << "***************************" << endl;
			cout << "    True Answer :-)\n";
			cout << "***************************" << endl;
			Yes++;
		}
		else {
			system("color 4F");
			cout << "\a***************************" << endl;
			cout << "    False Answer : -(\n";
			cout << "***************************" << endl;
			cout << "The True Answer Is :" << z << endl;
			No++;
		}
	}
	else if (Type == 4) {
		z=DevType(Num1, Num2);
		if (GetAns() == z) {
			system("color 2F");
			cout << "***************************" << endl;
			cout << "    True Answer :-)\n";
			cout << "***************************" << endl;
			Yes++;
		}
		else {
			system("color 4F");
			cout << "\a***************************" << endl;
			cout << "    False Answer : -(\n";
			cout << "***************************" << endl;
			cout << "The True Answer Is :" << z << endl;
			No++;
		}
	}else {
		enQType n = (enQType)MakeRandom(1, 4);
		MakeTypeQustions(n, Num1, Num2,Yes,No);
	}
}

void PrintReselts(int Num1,int Num2) {
	if (Num1 >= Num2) {
		system("color 2");
		cout << "\n\n\t------------------------------------------------------\t\n\n";
		cout << "                          +++ Pass Exam +++                     ";
		cout << "\n\n\t------------------------------------------------------\t\n\n";
		cout << "\tYour Corect Answer Are   : " << Num1 << endl;
		cout << "\tYour UnCorect Answer Are : " << Num2 << endl;
		cout << "\n\n\t------------------------------------------------------\t\n\n";
	}
	else {
		system("color 4");
		cout << "\n\n\t------------------------------------------------------\t\n\n";
		cout << "                          +++ Fill Exam +++                     ";
		cout << "\n\n\t------------------------------------------------------\t\n\n";
		cout << "\tYour Corect Answer Are   : " << Num1 << endl;
		cout << "\tYour UnCorect Answer Are : " << Num2 << endl;
		cout << "\n\n\t------------------------------------------------------\t\n\n";
	}
}

void ReplayCheck();

void PlayPage() {
	int Num1 = 0, Num2 = 0;
	InfoGame Player;
	int n = HowManyTimesReplay();
	cout << endl;
	enLevels n1 = EnterLevel();
	enQType n2 = EnterQType();
	for (int i = 0;i < n;i++) {
		MakeLevelQustions(n1, Num1, Num2);
		MakeTypeQustions(n2, Num1, Num2, Player.TrueAnswers, Player.FalseAnswers);
	}
	PrintReselts(Player.TrueAnswers, Player.FalseAnswers);
}

int main() {
	srand((unsigned)time(NULL));
	PlayPage();
	return 0;
}


void ReplayCheck() {
	cout << "Do You Woona To Replay This Game (Y\\N) ?";
	char a;
	cin >> a;
	switch (a)
	{
	case 'y':
	case'Y':
		PlayPage();
		break;
	default:
		break;
	}
}
