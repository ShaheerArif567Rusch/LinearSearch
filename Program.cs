// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static int BinarySearchInt(List<int> anArray, int item) {
  
    int LowerIndex = 0; 
    int UpperIndex = anArray.Count - 1; 
    while (LowerIndex <= UpperIndex) { 
        double mid = (LowerIndex + UpperIndex) / 2;
        int MiddleIndex = (int)Math.Floor(mid); 
        
        if (item == anArray[MiddleIndex]) {
            return MiddleIndex; 
        } else if (item < anArray[MiddleIndex]) {
            UpperIndex = MiddleIndex - 1; 
        } else {
            LowerIndex = MiddleIndex + 1; 
        }
    }
    return -1; 
}

static int BinarySearchStr(List<string> anArray, string item) {
    int LowerIndex = 0; 
    int UpperIndex = anArray.Count - 1; 
    while (LowerIndex <= UpperIndex) {
        double mid = (LowerIndex + UpperIndex) / 2; 
        int MiddleIndex = (int)Math.Floor(mid); 
    
        int compare = String.Compare(item, anArray[MiddleIndex]); 
        if (compare == 0) {
            return MiddleIndex; 
        } else if (compare < 0) {
            UpperIndex = MiddleIndex - 1; 
        } else {
            LowerIndex = MiddleIndex + 1; 
        }
    }
    return -1;    

}
List<int> numbers = new List<int>(){10, 20, 30, 40, 50, 60, 70, 80, 90, 100}; 
int index1 = BinarySearchInt(numbers, 40); 
Console.WriteLine(index1);

List<int> perfectSquares = new List<int>(){1, 4, 9, 16, 25, 36, 49, 64, 81, 100, 121, 144, 169, 225}; 
int index2 = BinarySearchInt(perfectSquares, 122); 
Console.WriteLine(index2);
List<string> words1 = new List<string>(){"Thomas", "Gordon", "Percy", "Edward", "Henry", "Toby", "Emily"}; 
int index3 = BinarySearchStr(words1, "Gordon"); 
Console.WriteLine(index3); 
int index4 = BinarySearchStr(words1, "Spencer"); 
Console.WriteLine(index4); 
List<string> Phones = new List<string>(){"IPhone1", "IPhone2", "IPhone3", "IPhone4", "IPhone5SE", "IPhone6s+", "IPhone7", "IPhone8", "IPhoneX", "IPhoneXS", "IPhoneXR", "IPhoneXSMax", "IPhone11", "IPhone11Pro", "IPhone11ProMax"}; 
int index5 = BinarySearchStr(Phones, "IPhone7"); 
Console.WriteLine(index5); 
int index6 = BinarySearchStr(Phones, "IPhoneXS"); 
Console.WriteLine(index6); 
int index7 = BinarySearchStr(Phones, "IPhone999"); 
Console.WriteLine(index7); 








