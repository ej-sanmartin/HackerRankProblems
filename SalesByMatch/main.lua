--
-- Complete the 'sockMerchant' function below.
--
-- The function is expected to return an INTEGER.
-- The function accepts following parameters:
--  1. INTEGER n
--  2. INTEGER_ARRAY ar
--

function sockMerchant(n, ar)
    local socks = {}
    local pairs = 0
    
    for _, sock in ipairs(ar) do
        if socks[sock] == nil or socks[sock] == 0 then
            socks[sock] = 1
        else
            socks[sock] = socks[sock] + 1
            if socks[sock] == 2 then
                socks[sock] = 0
                pairs = pairs + 1
            end
        end
    end
    
    return pairs
end
