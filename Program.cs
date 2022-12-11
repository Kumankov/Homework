int n=4; string[] SourceArray={"hello","2","world",":-)"};
//int n=4; string[] SourceArray={"1234", "1567", "-2", "computer science"};
//int n=3; string[] SourceArray={"Russia", "Denmark", "Kazan"};
string[] ResultArray = new string[n];
int count=0;
for (int i=0; i< n; i++)
    {
        if (SourceArray[i].Length <=3)
        {
            ResultArray[count]= SourceArray[i];
            count++;
        }       
    }
Console.Write($"[");
for (int j=0; j<count; j++)
    {
        if (j==0)
            Console.Write(ResultArray[j]);
        else     
            Console.Write($", {ResultArray[j]}");
    }
Console.WriteLine($"]");

