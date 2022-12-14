// int n=4; string[] SourceArray={"hello","2","world",":-)"};
// int n=4; string[] SourceArray={"1234", "1567", "-2", "computer science"};
// int n=3; string[] SourceArray={"Russia", "Denmark", "Kazan"};
int n=8; string[] SourceArray={"Rus", "Denmark", "Kazan", "123", "PC", "AI", "Рython", ":0"};
int count=0;
for (int i=0; i< n; i++)
    {
        if (SourceArray[i].Length <=3)          
            count++;
    }
string[] ResultArray = new string[count];
int k=0;
for (int j=0; j< n; j++)
    {
        if (SourceArray[j].Length <=3) 
        {
            ResultArray[k]= SourceArray[j];
            k++;   
        }       
    }
Console.Write($"[");
for (int l=0; l<count; l++)
    {
        if (l==0)
            Console.Write(ResultArray[l]);
        else     
            Console.Write($", {ResultArray[l]}");
    }
Console.WriteLine($"]");
// Console.WriteLine(count);
