class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int valleys = 0;
        int level = 0;
        bool underSeaLevel = false;
        
        foreach(char step in path){
            if(step == 'U'){
                if(underSeaLevel && level == -1) valleys++;
                level++;
            }
            if(step == 'D') level--;
            if(level < 0) underSeaLevel = true;
            if(level >= 0) underSeaLevel = false;
        }
        
        return valleys;
    }
}
