--
-- Complete the 'jumpingOnClouds' function below.
--
-- The function is expected to return an INTEGER.
-- The function accepts INTEGER_ARRAY c as parameter.
--

function jumpingOnClouds(c)
    local count = 0;
    local cloud = 1;
    
    while cloud < #c do
        if cloud + 2 == #c - 1 or c[cloud + 2] == 1 then
            cloud = cloud + 1
        else
            cloud = cloud + 2
        end
        count = count + 1
    end
    
    return count;
end
