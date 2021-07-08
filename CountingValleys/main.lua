--
-- Complete the 'countingValleys' function below.
--
-- The function is expected to return an INTEGER.
-- The function accepts following parameters:
--  1. INTEGER steps
--  2. STRING path
--

function countingValleys(steps, path)
    local valleys = 0;
    local level = 0;
    local isUnderSeaLevel = false;
    
    for c in string.gmatch(path, ".") do
        if c == "U" then
            if isUnderSeaLevel and level == -1 then
                valleys = valleys + 1
            end
            level = level + 1
        elseif c == "D" then
            level = level - 1
        end
        
        if level < 0 then
            isUnderSeaLevel = true
        else
            isUnderSeaLevel = false
        end
    end
    
    return valleys;

end
