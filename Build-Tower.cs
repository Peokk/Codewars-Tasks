public class Kata{
    public static string[] TowerBuilder(int nFloors)    {
        int x;
        string[] tower = new string[nFloors];
        for (int i = 0; i < nFloors; i++){
            x = 1 + (i * 2);
            for (int j = 0; j < nFloors - i - 1; j++) 
                tower[i] += " ";
            for (int j = 0; j < x; j++)            
                tower[i] += "*";
            for (int j = 0; j < nFloors - i - 1; j++)           
                tower[i] += " ";           }   
        return tower;
    }    }