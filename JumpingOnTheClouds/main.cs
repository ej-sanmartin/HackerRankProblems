class Result
{

    /*
     * Complete the 'jumpingOnClouds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY c as parameter.
     */

    public static int jumpingOnClouds(List<int> c)
    {
        int count = 0;
        int cloud = 0;
        
        while(cloud < c.Count - 1){
            if(cloud + 2 == c.Count || c[cloud + 2] == 1){
                cloud++;
            } else {
                cloud += 2;
            }
            count++;
        }
        
        return count;
    }

}
