// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static int linearSearchInt(List<int> anArray, int item) {
    for (int i = 0; i < anArray.Count; i++) {
         if (anArray[i] == item) {
             return i; 
    }
    }
    return -1;
    
} 

static int linearSearchStr(List<string> anArray, string item) {
    // Test Code
    for (int i = 0; i < anArray.Count; i++) {
        if (anArray[i] == item) {
            return i; 
        }
    }
    return -1;
}




List<string> words = new List<string>(){"Pandas", "Thomas", "Destruction", "Snakes", "Water", "Iphone"}; 
List<string> vowels = new List<string>(){"a", "e", "i", "o", "u"};
List<int> odds = new List<int>(){1, 3, 5, 7, 9, 11, 13, 15, 17}; 
List<int> evens = new List<int>(){2, 4, 6, 8, 10, 12, 14}; 



int index1 = linearSearchInt(odds, 53);
Console.WriteLine(index1);

int index2 = linearSearchInt(evens, 4);
Console.WriteLine(index2);

int index3 = linearSearchStr(words, "hi");
Console.WriteLine(index3);

int index4 = linearSearchStr(vowels, "e");
Console.WriteLine(index4);



