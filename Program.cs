// Single array 
// Initialize an Array with values (a)

string[] tester_1 = new string[4];
tester_1[0] = "Tan";
tester_1[1] = "Kien";
tester_1[2] = "Nghi";
tester_1[3] = "Hien";

//Initialize an Array with values (b)

string[] tester_2 = {"Loi", "Duong", "Thao"};

//Initialize an Array with values (c)

string[] tester_3 = new string[4] { "Tan", "loi", "Kien", "Nghi" };

//Initialize an Array with values (d)
string[] tester_4 = new string[] { "Tan", "loi", "Kien", "Nghi", "Duong" };

for (int row = 0; row  < tester_2.GetLength(0); row++)
{
     Console.WriteLine(tester_2[row]);
     Console.WriteLine();
}